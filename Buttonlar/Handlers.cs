using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using bot.Entity;
using bot.Services;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace bot
{
    public class Handlers
    {
        private readonly ILogger<Handlers> _logger;
        private readonly IStorageService _storage;
        private readonly ICacheService _cache;

        public Handlers(
            ILogger<Handlers> logger,
            IStorageService storage,
            ICacheService cache)
        {
            _logger = logger;
            _storage = storage;
            _cache = cache;
        }

        public Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken ctoken)
        {
            var errorMessage = exception switch
            {
                ApiRequestException => $"Error occured with Telegram Client: {exception.Message}",
                _ => exception.Message
            };

            _logger.LogCritical(errorMessage);

            return Task.CompletedTask;
        }

        public async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken ctoken)
        {
            var handler = update.Type switch
            {
                UpdateType.Message => BotOnMessageReceived(client, update.Message),
                UpdateType.EditedMessage => BotOnMessageEdited(client, update.EditedMessage),
                UpdateType.CallbackQuery => BotOnCallbackQueryReceived(client, update.CallbackQuery),
                UpdateType.InlineQuery => BotOnInlineQueryReceived(client, update.InlineQuery),
                UpdateType.ChosenInlineResult => BotOnChosenInlineResultReceived(client, update.ChosenInlineResult),
                _ => UnknownUpdateHandlerAsync(client, update)
            };

            try
            {
                await handler;
            }
            catch (Exception e)
            {

            }
        }

        private async Task BotOnMessageEdited(ITelegramBotClient client, Message editedMessage)
        {
            throw new NotImplementedException();
        }

        private async Task UnknownUpdateHandlerAsync(ITelegramBotClient client, Update update)
        {
            throw new NotImplementedException();
        }

        private async Task BotOnChosenInlineResultReceived(ITelegramBotClient client, ChosenInlineResult chosenInlineResult)
        {
            throw new NotImplementedException();
        }

        private async Task BotOnInlineQueryReceived(ITelegramBotClient client, InlineQuery inlineQuery)
        {
          throw new NotImplementedException(); 
        }

        private async Task BotOnCallbackQueryReceived(ITelegramBotClient client, CallbackQuery callbackQuery)
        {
            switch (callbackQuery.Data)
            {
                case "oz":


                    await client.SendTextMessageAsync(
                           chatId: callbackQuery.From.Id,
                           parseMode: ParseMode.Markdown,
                           text: "Iltimos o'zingizga kerakli Menyuni tanlang.",
                           replyMarkup: MessageBuilder.menu());
                    await client.DeleteMessageAsync(
                            chatId: callbackQuery.From.Id,
                            messageId: callbackQuery.Message.MessageId);
                    break;

                case "rus":

                    await client.SendTextMessageAsync(
                           chatId: callbackQuery.From.Id,
                           parseMode: ParseMode.Markdown,
                           text: "Пожалуйста выберите нужный вам меню.",
                           replyMarkup: MessageBuilder.menurus());
                    await client.DeleteMessageAsync(
                            chatId: callbackQuery.From.Id,
                            messageId: callbackQuery.Message.MessageId);
                    break;
                case "changelang":
                await client.SendTextMessageAsync(
                chatId: callbackQuery.From.Id,
                parseMode: ParseMode.Markdown,
                text: "Quyidagi tillardan birini tanlang.👇👇",
                replyMarkup: MessageBuilder.Greeting());

                 
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "changeloc":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text:"Yangi lokatsiyangizni tashlang.",
                        replyMarkup: MessageBuilder.location2());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "noviylang":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Выберите нужный вам язык.👇👇",
                        replyMarkup: MessageBuilder.Greeting());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "noviyloc":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Отправьте новую локацию.",
                        replyMarkup: MessageBuilder.location2ru());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;

                case "1-33":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Al_Asma());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "33-66":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Asma2());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "66-99":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Asma3());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "back":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Asosiy());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;


            }
        }

        private async Task BotOnMessageReceived(ITelegramBotClient client, Message message)
        {
            if ( message.Location != null)
            {
                var lon = message.Location.Longitude;
                var lat = message.Location.Latitude;
                Math.Round(lon, 6);
                Math.Round(lat, 6);
                var user = new BotUser(
                    chatId: message.Chat.Id,
                    username: message.From.Username,
                fullname: $"{message.From.FirstName} {message.From.LastName}",
                longitude:lon,
                latitude:lat,
                address: "");
                 var res1=  await _storage.InsertUserAsync(user);

                if (res1.IsSuccess)
                {
                    _logger.LogInformation($"New user added: {message.Chat.Id}");
                    await _storage.InsertUserAsync(user);
                }
                else
                {
                    await _storage.UpdateUserAsync(user);
                    _logger.LogInformation($"User already exists!");
                }
                Console.WriteLine(lon + " " + lat);

                var res = await _storage.GetUserAsync(message.Chat.Id);
                var result = await _cache.GetOrUpdatePrayerTimeAsync(res.ChatId, res.Longitude, res.Latitude);
                var times = result.prayerTime;
                await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: @$"
             *Fajr*: {times.Fajr}
             *Sunrise*: {times.Sunrise}
             *Dhuhr*: {times.Dhuhr}
             *Asr*: {times.Asr}
             *Maghrib*: {times.Maghrib}
             *Isha*: {times.Isha}
             *Midnight*: {times.Midnight}
                    
             *Method*: {times.CalculationMethod}
                    ",
                    parseMode: ParseMode.Markdown);
            }
            switch (message.Text)
            {
                case "/start":
                 
                    await client.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        parseMode: ParseMode.Markdown,
                        text: "Assalomu Alaykum iltimos bo't bilan muloqot tilini tanlang.\n🗣💬👇👇\n" +
                        "Здравствуйте пожалуйста выберите язык общения с ботом.\n🗣💬👇👇  ",
                        replyMarkup: MessageBuilder.Greeting());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                case "Namoz Vaqtlari 📍 .":
                    await client.SendTextMessageAsync(
                       chatId: message.Chat.Id,
                       parseMode: ParseMode.Markdown,
                       text: "Iltimos Lokatsiyangizni jo'nating yoki \n yoki kerakli menyuni tanlang.✅",
                       replyMarkup: MessageBuilder.webapi());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                case "Shaharlar nomi bilan\n namoz vaqtlarini qidirish 🔎":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Kerakli shaxarni kiriting ⬇️",
                      replyMarkup: MessageBuilder.webapi2());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                   

                case "Asma-ul-Husna ☪️💟":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Siz bu yerda Allohning go'zal ismlarini va Ularning manosini yodlab olishingiz mumkun..😍😍",
                      replyMarkup:MessageBuilder.Asosiy()
                      );
                 
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                case "Foydali Kanallar 🔗":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Quyidagi linklar Zamonamizning mashhur ulamolari va"+
                      "\n ularnign darslari tarqatiladigan kanallarga olib o'tadi ⬇️ ⬇️",
                      replyMarkup: MessageBuilder.SendLinks());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                case "Hijriy kalendar 🗓🕌":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Iltimos kerakli Menyuni tanlang✅",
                      replyMarkup: MessageBuilder.webapi3());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                case "Tuzatishlar ⚙️":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Iltimos kerakli Menyuni tanlang✅",
                      replyMarkup: MessageBuilder.Greeting2());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;


                case "Время молитв.📍 ":
                    await client.SendTextMessageAsync(
                       chatId: message.Chat.Id,
                       parseMode: ParseMode.Markdown,
                       text: "Пожалуйста отправьте свойу локацию или выберите нужный вам меню.✅",
                       replyMarkup: MessageBuilder.webapiru());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                case "Ищите время молитв\n по названию желаемого города.🔎":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Ведите названия города. ⬇️",
                      replyMarkup: MessageBuilder.webapi2ru());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                case "Асма-Уль-Хусна ☪️💟":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Вы можете узнать значение имён всевышнего Аллаха.😍😍"
                      );
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                case "Полезные каналы 🔗":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id, 
                      parseMode: ParseMode.Markdown,
                      text: "Внизу некоторые ссылки полезных каналов современности. ⬇️⬇️",
                      replyMarkup: MessageBuilder.SendLinks()) ;
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                case "Исламский календарь🗓🕌":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Пожалуйста выберите нужный вам меню.✅",
                      replyMarkup: MessageBuilder.webapi3ru());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                case "Настройки ⚙️":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Пожалуйста выберите нужный вам меню.✅",
                      replyMarkup: MessageBuilder.Greeting2ru());
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
            }
        }
    }
}