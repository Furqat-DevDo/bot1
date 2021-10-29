using System;
using System.Threading.Tasks;
using bot.Entity;
using System.Globalization;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
namespace bot{
    public partial class Handlers{
         private async Task BotOnMessageReceived(ITelegramBotClient client, Message message)
        {  if ( message.Location != null)
            {
                var lon = message.Location.Longitude;
                var lat = message.Location.Latitude;
                var user = await _storage.GetUserAsync(message.Chat.Id);
                user.Longitude = lon;
                user.Latitude = lat;
                await _storage.UpdateUserAsync(user);

                var result = await _cache.GetOrUpdatePrayerTimeAsync(user.ChatId, user.Longitude, user.Latitude);
                var times = result.prayerTime;
                await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text:
 @$"                   
Bomdod : {times.Fajr}
Quyosh Chiqishi : {times.Sunrise}
Peshin : {times.Dhuhr}
Asr : {times.Asr}
Shom : {times.Maghrib}
Hufton : {times.Isha}
Yarim tun : {times.Midnight}
Asosiy Manba : {times.CalculationMethod}",
parseMode: ParseMode.Default

);}

            if(!await _storage.ExistsAsync(message.Chat.Id))
            {
                var user = new BotUser(
                    chatId: message.Chat.Id,
                    username: message.From.Username,
                    fullname: $"{message.From.FirstName} {message.From.LastName}",
                    longitude:0.0,
                    latitude:0.0,
                    address: "");

                if(!(await _storage.InsertUserAsync(user)).IsSuccess)
                {
                    throw new Exception($"Could not add a new user to DB. CHAT ID: {user.ChatId}");
                }
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
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                    case "Orqaga🔙":
                    await client.SendTextMessageAsync(
                       chatId: message.Chat.Id,
                       parseMode: ParseMode.Markdown,
                       text: "Iltimos kerakli Menyuni tanlang✅",
                       replyMarkup: MessageBuilder.menu());
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
                     DateTime today =  DateTime.Now;
                     DateTime myDT2 = new DateTime( today.Year, today.Month,today.Day, new GregorianCalendar() );
                     HijriCalendar myCal2 = new HijriCalendar(); 

                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      text:
@$"                         
Yil: { myCal2.GetYear( myDT2 ) }
Oy: { myCal2.GetMonth( myDT2 )} 
Kun: { myCal2.GetDayOfMonth( myDT2 )} 
Hafta kuni: { myCal2.GetDayOfWeek( myDT2 ) }"                   
                      
                     );
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
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                     case "Назад🔙":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Пожалуйста выберите нужный вам меню.✅",
                      replyMarkup:MessageBuilder.menurus()
                      );
                 
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;

                case "Асма-Уль-Хусна ☪️💟":
                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      parseMode: ParseMode.Markdown,
                      text: "Вы можете узнать значение имён всевышнего Аллаха.😍😍",
                      replyMarkup:MessageBuilder.Asosiyru()
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
                      replyMarkup: MessageBuilder.SendLinksru()) ;
                    await client.DeleteMessageAsync(
                        chatId: message.Chat.Id,
                        messageId: message.MessageId);
                    break;
                     case "Исламский календарь🗓🕌":
                   
                    DateTime todayru =  DateTime.Now;
                     DateTime myDTru = new DateTime( todayru.Year, todayru.Month,todayru.Day, new GregorianCalendar() );
                     HijriCalendar myCalru= new HijriCalendar(); 

                    await client.SendTextMessageAsync(
                      chatId: message.Chat.Id,
                      text:
@$"                         
Год:{ myCalru.GetYear( myDTru ) }
Месяц:{ myCalru.GetMonth( myDTru )} 
День месяца:{ myCalru.GetDayOfMonth( myDTru )} 
День недели:{ myCalru.GetDayOfWeek( myDTru) }"                   
                      
                    );
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
    
