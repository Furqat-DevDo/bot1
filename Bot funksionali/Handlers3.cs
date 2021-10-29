using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
namespace bot{
    public partial class Handlers{
        private async Task BotOnCallbackQueryReceived(ITelegramBotClient client, CallbackQuery callbackQuery)
        {
            switch (callbackQuery.Data)
            {
                case "oz":


                    await client.SendTextMessageAsync(
                           chatId: callbackQuery.From.Id,
                           parseMode: ParseMode.Markdown,
                           text: "Iltimos o'zingizga kerakli Menyuni tanlang🔻.",
                           replyMarkup: MessageBuilder.menu());
                    await client.DeleteMessageAsync(
                            chatId: callbackQuery.From.Id,
                            messageId: callbackQuery.Message.MessageId);
                    break;

                case "rus":

                    await client.SendTextMessageAsync(
                           chatId: callbackQuery.From.Id,
                           parseMode: ParseMode.Markdown,
                           text: "Пожалуйста выберите нужный вам меню🔻.",
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
                    case "backru":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Выберите нужный вам меню✅",
                        replyMarkup: MessageBuilder.Asosiyru());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                    case "nazad":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Asosiy());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                     case "glavniy":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Iltimos o'zingizga kerakli Menyuni tanlang🔻.",
                        replyMarkup: MessageBuilder.menu());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                      case "glavniyru":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Выберите нужный вам меню✅🔻.",
                        replyMarkup: MessageBuilder.menurus());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                    case "1-33ru":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Al_Asmaru());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "33-66ru":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Asma2ru());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "66-99ru":
                    await client.SendTextMessageAsync(
                        chatId: callbackQuery.From.Id,
                        text: "Kerakli tugmani bosing va go'zal isimning ma'nosini bilib oling.",
                        replyMarkup: MessageBuilder.Asma3ru());
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                     case "1":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-002.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;

                case "2":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-008.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "3":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-008.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "4":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-046.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                
                case "5":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-020.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "6":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-024.jpg",

                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "7":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-026.jpg",

                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "8":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-072.jpg",

                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "9":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-058.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "10":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-064.jpg",

                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "11":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-030.jpg",

                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                
                case "12":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-066.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "13":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-068.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "14":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-070.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "15":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-104.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "16":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-060.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "17":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-132.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "18":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-086.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "19":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-088.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "20":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-044.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "21":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-136.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "22":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-136.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "23":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"http://www.silsilaekamaliya.com/wp-content/uploads/2015/01/99-Names-Of-Allah-With-Translation-23.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "24":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/styles/content660scale/public/99names/23-Ar-Rafi-flower-white.jpg?itok=hpoeyvJq",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "25":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/styles/content660scale/public/99names/24-Al-Muizz-flower-black.jpg?itok=jAbXmFB8",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "26":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://png.pngtree.com/png-vector/20190622/ourlarge/pngtree-99-names-of-allah-vector-al-muzil-asma-ul-husna-png-image_1507063.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "27":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-114.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "28":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-116.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "29":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-094.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "30":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/e1/f3/7c/e1f37cf1cb6be2d1bc6aa2ab68e3b8b1.png",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "31":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-038.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "32":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-052.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "33":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-102.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "34":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/2e/c4/34/2ec4345e9f648cfe3f0ac346ff896745.png",
                        replyMarkup:MessageBuilder.bittaorqaga())
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "35":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/7906737_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "36":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://png.pngtree.com/png-clipart/20190613/original/pngtree-ash-shakoor-99-names-of-allah-with-meaning-and-explanation-png-image_3548084.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "37":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-036.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "38":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-052.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "39":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTsl17A5NfEg0nSA3ixgRaDGCtknrPDtcrTAQ&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "40":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/e9/70/c7/e970c7a80acb654d72e792bd146fe2f3.png",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "41":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/736x/de/0c/52/de0c5216caaa208bd86cddffb643ae54.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "42":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/styles/content660scale/public/99names/41-Al-Jalil-flower-white.jpg?itok=wL_9VjFO",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "43":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://image.shutterstock.com/image-vector/arabic-calligraphy-design-vector-alkareem-600w-1627871740.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "44":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://m.media-amazon.com/images/I/51Bodc4sCOL._SL1000_.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "45":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/2980182_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "46":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-042.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "47":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSK8gXfsscZ-JSOmwbGDHUDjGedQsewfMAqpQ&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "48":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.ytimg.com/vi/WccwryiHjSA/hqdefault.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "49":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.ytimg.com/vi/tAKJeQKgnME/hqdefault.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "50":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/styles/content660scale/public/99names/49-Al-Baith-flower-white.jpg?itok=dhTRUO5M",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "51":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/99names/50-Ash-Shahid-flower-white.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "52":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-028.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "53":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/7469330_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "54":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-054.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "55":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-056.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "56":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://c8.alamy.com/comp/2DFY363/99-allah-name-asma-ul-husna-the-name-of-allah-2DFY363.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "57":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://deensisters.files.wordpress.com/2018/09/img_1396.jpg?w=267",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "58":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.crushpixel.com/static18/preview2/stock-photo-allah-name--2801566.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "59":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/99names/58-Al-Mubdi-flower-white.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "60":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://data.whicdn.com/images/106094793/original.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "61":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/564x/79/dc/00/79dc0065cf05a4fcce3429551ec10542.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "62":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://64.media.tumblr.com/3f80e4bc20dab2f5a47f3f2e5b8c38e2/tumblr_oouacdbbAf1vkuwhbo1_1280.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "63":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-010.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "64":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-012.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "65":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/5e/f0/ba/5ef0bae55cd83ba0e0b8d2b6d293b658.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "66":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-050.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "67":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR37waDQfNAguHO33dFZVIvKrhDhYOFVqKntWOgLgqOaKFBcmtYsnpPRBm2RDzH70YJIv4&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "68":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/4269228_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "69":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/6595518_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "70":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRXHV1ySA3huMQpHW77UDe-swX9l28mn8BcUA&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "71":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRSiprV2ePWy-3MI2kc72Mvp2EOZltQPv8RpA&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "72":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/styles/content660scale/public/99names/72-Al-Muakhkhir-flower-white.jpg?itok=QW2OlmlI",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "73":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-014.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "74":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-014.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "75":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/eb/25/92/eb2592f22eca3f3bc5e43ff7a0d6bcdc.png",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "76":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"http://www.silsilaekamaliya.com/wp-content/uploads/2015/01/99-Names-Of-Allah-With-Translation-76.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "77":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://c8.alamy.com/comp/2DFY363/99-allah-name-asma-ul-husna-the-name-of-allah-2DFY363.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "78":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/99names/78-Al-Muta-ali-flower-white.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "79":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/ea/b4/72/eab4725645c446748049246c967f99ad.png",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "80":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/99names/80-At-Tawwab-flower-white.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "81":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/47/97/d4/4797d4c1ac10dd279ad9ae6de329482c.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "82":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/a0/ef/27/a0ef275183694f43c749dced589ddc6d.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "83":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/11/98/9b/11989bbb6fac54509bafb3a9327018d5.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "84":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/4299364_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "85":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/7810523_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "86":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://graphicjunction.com/sites/default/files/99names/86-Al-Muqsit-flower-white.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "87":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://1.bp.blogspot.com/-QgF9NMkFTJQ/XfpHm0N43OI/AAAAAAAABQs/w5-PcWC97uEi8ZFiI8ytE8bRc90KcdzngCLcBGAsYHQ/s320/al%2Bjaami.png",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "88":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/de/c6/8a/dec68a644d946aa231179113edd717d0.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "89":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://cdn4.vectorstock.com/i/1000x1000/99/23/al-mughni-allah-name-in-arabic-writing-god-name-vector-23849923.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "90":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQcICbTVPsCvEZaO7SiTXTO98rB_MGGlp3JQQ&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "91":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.quran-al-mubeen.com/uploads/2/6/8/1/26819534/193976_orig.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "92":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://c8.alamy.com/comp/2DFY2PH/99-allah-name-asma-ul-husna-the-name-of-allah-2DFY2PH.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "93":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://c8.alamy.com/comp/2DFY30Y/99-allah-name-asma-ul-husna-the-name-of-allah-2DFY30Y.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "94":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7W1unActMT8b1fEdv023lZHyqaOs2mRbwcW4-AR8tvEZt3_E5JQnVcxJpdiII9OAl0Rk&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "95":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/51/5d/6e/515d6e701cb6ffb9acb5530fd3558785.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "96":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/8d/23/4b/8d234b4a43fbda58fe2a5076c6b1c568.png",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "97":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://www.mustafacenter.org/wp-content/uploads/2020/09/99-Names-of-Allah-018.jpg",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "98":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ-a60IJXO2aTvdUlHSgG7yYaR_VK6oTSoJsi21JA4qmcQmxSUMQrg00XfN7HzXedSKNqw&usqp=CAU",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                        
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                case "99":
                    await client.SendPhotoAsync(
                        chatId: callbackQuery.From.Id,
                        photo :"https://i.pinimg.com/originals/01/a5/cb/01a5cb74582d8a6a1dd0a8f4801775e9.png",
                        replyMarkup:MessageBuilder.bittaorqaga()) 
                        ;
                    await client.DeleteMessageAsync(
                    chatId: callbackQuery.From.Id,
                    messageId: callbackQuery.Message.MessageId);
                    break;
                    
            }
        }
    }
}