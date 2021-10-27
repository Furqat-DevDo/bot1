using System;
using System.Threading.Tasks;
using bot;
using bot.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;

namespace ConsoleApp2
{
    class Program
    {
        static Task Main(string[] args)
            => CreateHostBuilder(args)
                .Build()
                .RunAsync();

        private static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .ConfigureServices(Configure);

        private static void Configure(HostBuilderContext context, IServiceCollection services)
        {
            services.AddSingleton<TelegramBotClient>(b => new TelegramBotClient("2003195499:AAErbRdOr3caPeBdaHV9txjoWJ7Az1wTDpI"));
            services.AddHostedService<Bot>();
            services.AddTransient<IStorageService, InternalStorageService>();
            services.AddTransient<Handlers>();
            // services.AddTransient<IStorageService, DbStorageService>();
        }
    }
}
