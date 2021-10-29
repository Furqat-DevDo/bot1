﻿using System;
using System.Threading.Tasks;
using bot.Entity;
using bot.Services;
using Telegram_Bot.Http_So_rovlar;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using bot;

namespace Telegram_Bot
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; private set; }

        static Task Main(string[] args)
            => CreateHostBuilder(args)
                .Build()
                .RunAsync();

        private static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .ConfigureServices(Configure)
                .ConfigureAppConfiguration((context, configuration) =>
                {
                configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                Configuration = configuration.Build();
                 });

        private static void Configure(HostBuilderContext context, IServiceCollection services)
        {
            services.AddDbContext<BotDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("BotConnection"));
            }, ServiceLifetime.Singleton);

            services.AddMemoryCache();
            services.AddTransient<ICacheService, PrayerTimeCacheService>();
            services.AddSingleton<TelegramBotClient>(b => new TelegramBotClient(Configuration.GetSection("Bot:Token").Value));
            services.AddHostedService<Bot>();

            services.AddTransient<IStorageService, DbStorageService>();
            services.AddTransient<Handlers>();
            services.AddHttpClient<IPrayerTimeClient, AladhanClient>
            (client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("Aladhan:BaseUrl").Value);
            });

        }
    }
}

