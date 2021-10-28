using System;
using System.Collections.Generic;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace bot
{
    public class MessageBuilder
    {
        public static InlineKeyboardMarkup Greeting()
        {
            InlineKeyboardButton Button = new InlineKeyboardButton();
            InlineKeyboardButton Button2 = new InlineKeyboardButton();

            Button.Text = "O'zbek Tili 🇺🇿 🇺🇿";
            Button.CallbackData = "oz";

            Button2.Text = "Русский Язык 🇷🇺 🇷🇺";
            Button2.CallbackData = "rus";



            InlineKeyboardButton[] buttons = new InlineKeyboardButton[] { Button, Button2 };

            InlineKeyboardMarkup inline = new InlineKeyboardMarkup(buttons);

            return inline;
        }
        public static InlineKeyboardMarkup Greeting2()
        {
            InlineKeyboardButton Button = new InlineKeyboardButton();
            InlineKeyboardButton Button2 = new InlineKeyboardButton();

            Button.Text = "Tilni O'zgartirish🔄🔁";
            Button.CallbackData = "changelang";

            Button2.Text = "Lokatsiyani O'zgartirish 🔄🔁";
            Button2.CallbackData = "changeloc";



            InlineKeyboardButton[] buttons = new InlineKeyboardButton[] { Button, Button2 };

            InlineKeyboardMarkup inline = new InlineKeyboardMarkup(buttons);

            return inline;
        }
        public static InlineKeyboardMarkup Greeting2ru()
        {
            InlineKeyboardButton Button = new InlineKeyboardButton();
            InlineKeyboardButton Button2 = new InlineKeyboardButton();

            Button.Text = "Изменить язык.🔄🔁";
            Button.CallbackData = "noviylang";

            Button2.Text = "Изменить локацию. 🔄🔁";
            Button2.CallbackData = "noviyloc";



            InlineKeyboardButton[] buttons = new InlineKeyboardButton[] { Button, Button2 };

            InlineKeyboardMarkup inline = new InlineKeyboardMarkup(buttons);

            return inline;
        }

        public static ReplyKeyboardMarkup menu()
         => new ReplyKeyboardMarkup()
         {
             Keyboard = new List<List<KeyboardButton>>()
                            {
                                new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Namoz Vaqtlari 📍 .", RequestLocation = true },
                                   new KeyboardButton(){ Text = "Shaharlar nomi bilan\n namoz vaqtlarini qidirish 🔎" }

                                },
                                 new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Asma-ul-Husna ☪️💟" },
                                   new KeyboardButton(){ Text =  "Foydali Kanallar 🔗" }

                                }, new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Hijriy kalendar 🗓🕌" },
                                   new KeyboardButton(){ Text = "Tuzatishlar ⚙️" }

                                }
                            },
             ResizeKeyboard =true,
             OneTimeKeyboard = true
         };
        public static ReplyKeyboardMarkup location2()
              => new ReplyKeyboardMarkup()
              {
                  Keyboard = new List<List<KeyboardButton>>()
                            {
                                new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Yangi Lokatsiya 📍 ", RequestLocation = true },
                                   new KeyboardButton(){ Text = "Orqaga🔙" }

                                }

                  },
                  ResizeKeyboard = true,
                  OneTimeKeyboard = true
              };
        public static ReplyKeyboardMarkup location2ru()
          => new ReplyKeyboardMarkup()
          {
              Keyboard = new List<List<KeyboardButton>>()
                            {
                                new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Новая локация 📍", RequestLocation = true },
                                   new KeyboardButton(){ Text = "Назад🔙" }

                                }

              },
              ResizeKeyboard = true,
              OneTimeKeyboard = true
          };
        public static ReplyKeyboardMarkup menurus()

             => new ReplyKeyboardMarkup()
             {
                 Keyboard = new List<List<KeyboardButton>>()
                            {
                                new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Время молитв.📍 ", RequestLocation = true },
                                   new KeyboardButton(){ Text = "Ищите время молитв\n по названию желаемого города.🔎" }

                                },
                                 new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Асма-Уль-Хусна ☪️💟" },
                                   new KeyboardButton(){ Text =  "Полезные каналы 🔗" }

                                }, new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Исламский календарь🗓🕌" },
                                   new KeyboardButton(){ Text = "Настройки ⚙️" }

                                }
                            },
                 ResizeKeyboard = true,
                 OneTimeKeyboard = true
             };
        public static InlineKeyboardMarkup Al_Asma() {

            InlineKeyboardButton[][] button1 = new InlineKeyboardButton[][]
            {

                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Alloh", "1"),

                        InlineKeyboardButton.WithCallbackData("Ar-Rohman", "2"),

                        InlineKeyboardButton.WithCallbackData("Ar-Rohim", "3"),
                    },
                     new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Malik", "4"),

                        InlineKeyboardButton.WithCallbackData("Al-Quddus", "5"),

                        InlineKeyboardButton.WithCallbackData("As-Salam", "6"),
                    },
                     new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Mumin", "7"),

                        InlineKeyboardButton.WithCallbackData("Al-Muhaymin", "8"),

                        InlineKeyboardButton.WithCallbackData("Al-Aziz", "9"),
                    },
                      new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Jabbar", "10"),

                        InlineKeyboardButton.WithCallbackData("Al-Mutakabbir", "11"),

                        InlineKeyboardButton.WithCallbackData("Al-Holiq", "12"),
                    },
                        new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Bari", "13"),

                       InlineKeyboardButton.WithCallbackData("Al-Musovvir", "14"),

                        InlineKeyboardButton.WithCallbackData("Al-G'offar", "15"),
                    },
                          new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Qohhar", "16"),

                        InlineKeyboardButton.WithCallbackData("Al-Vahhab", "17"),

                        InlineKeyboardButton.WithCallbackData("Ar-Rozzaq", "18"),
                    },
                            new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Fattah", "19"),

                        InlineKeyboardButton.WithCallbackData("Al-Alim", "20"),

                        InlineKeyboardButton.WithCallbackData("Al-Qobiz", "21"),
                    },
                              new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Basit", "22"),

                        InlineKeyboardButton.WithCallbackData("Al-Hofis", "23"),

                        InlineKeyboardButton.WithCallbackData("Ar-Rafi", "24"),
                    },
                                new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Muizz", "25"),

                        InlineKeyboardButton.WithCallbackData("Al-Muzill", "26"),

                        InlineKeyboardButton.WithCallbackData("As-Sami", "27"),
                    },
                                  new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Basir", "28"),

                        InlineKeyboardButton.WithCallbackData("Al-Hakam", "29"),

                        InlineKeyboardButton.WithCallbackData("Al-Adl", "30"),
                    },
                                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Latif", "31"),

                        InlineKeyboardButton.WithCallbackData("Al-Hobir", "32"),

                        InlineKeyboardButton.WithCallbackData("Al-Halim", "33"),
                    },
                                     new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData("Orqaga🔙", "back"),
                    },

         };
           

            InlineKeyboardMarkup javob = new InlineKeyboardMarkup(button1);

            return javob;

        }

        public static InlineKeyboardMarkup Asosiy()
        {
            InlineKeyboardButton Button11 = new InlineKeyboardButton();
            InlineKeyboardButton Button12 = new InlineKeyboardButton();
            InlineKeyboardButton Button21= new InlineKeyboardButton();
            InlineKeyboardButton orqaga = new InlineKeyboardButton();
            Button11.Text = "1-33";
            Button11.CallbackData = "1-33";

            Button12.Text = "33-66";
            Button12.CallbackData = "33-66";

            Button21.Text = "66-99";
            Button21.CallbackData = "66-99";
            orqaga.Text = "Orqaga🔙";
            orqaga.CallbackData = "back";
            InlineKeyboardButton[] buttons = new InlineKeyboardButton[] { Button11, Button12 ,Button21};

            InlineKeyboardMarkup inline3 = new InlineKeyboardMarkup(buttons);

            return inline3;
        }

        public static InlineKeyboardMarkup Asma2(){

            InlineKeyboardButton[][] button2 = new InlineKeyboardButton[][]
                 {

                     new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Azim", "34"),

                        InlineKeyboardButton.WithCallbackData("Al-G'ofur", "35"),

                        InlineKeyboardButton.WithCallbackData("Ash-Shakur", "36"),
                    },
                                        new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Aliyy", "37"),

                        InlineKeyboardButton.WithCallbackData("Al-Kabir", "38"),

                        InlineKeyboardButton.WithCallbackData("Al-Hafiz", "39"),
                    },
                                          new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Muqid", "40"),

                        InlineKeyboardButton.WithCallbackData("An-Hasib", "41"),

                        InlineKeyboardButton.WithCallbackData("Al-Jalil", "42"),
                    },
                                            new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Karim", "43"),

                        InlineKeyboardButton.WithCallbackData("Ar-Roqib", "44"),

                        InlineKeyboardButton.WithCallbackData("Al-Mujib", "45"),
                    },
                                              new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Vasi", "46"),

                        InlineKeyboardButton.WithCallbackData("Al-Hakim", "47"),

                        InlineKeyboardButton.WithCallbackData("Al-Vadud", "48"),
                    },
                                                new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Majid", "49"),

                        InlineKeyboardButton.WithCallbackData("Al-Ba'is", "50"),

                        InlineKeyboardButton.WithCallbackData("Ash-Shahid", "51"),
                    },
                                                  new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Haqq", "52"),

                        InlineKeyboardButton.WithCallbackData("Al-Vakil", "53"),

                        InlineKeyboardButton.WithCallbackData("Al-Qovviyy", "54"),
                    },
                          new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Matin", "55"),

                        InlineKeyboardButton.WithCallbackData("Al-Valiyy", "56"),

                        InlineKeyboardButton.WithCallbackData("Al-Hamid", "57"),

                    },
                            new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Muhsi", "58"),

                        InlineKeyboardButton.WithCallbackData("Al-Mubdi", "59"),

                        InlineKeyboardButton.WithCallbackData("Al-Muid", "60"),
                    },
                       new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Muhyi", "61"),

                        InlineKeyboardButton.WithCallbackData("Al-Mumit", "62"),

                        InlineKeyboardButton.WithCallbackData("Al-Hayy", "63"),
                    },
                         new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Qoyyum", "64"),

                        InlineKeyboardButton.WithCallbackData("Al-Vajid", "65"),

                        InlineKeyboardButton.WithCallbackData("Al-Majid", "66"),
                    },
                           new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData("Orqaga🔙", "back"),
                    },
           }; 
            
            InlineKeyboardMarkup javob2 = new InlineKeyboardMarkup(button2);

          return javob2;
        }
        public static InlineKeyboardMarkup Asma3()
        {

            InlineKeyboardButton[][] button3 = new InlineKeyboardButton[][]
                 {

                     new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Vahid", "67"),

                        InlineKeyboardButton.WithCallbackData("As-Somad", "68"),

                        InlineKeyboardButton.WithCallbackData("Al-Qodir", "69"),
                    },
                             new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Muqtadir", "70"),

                        InlineKeyboardButton.WithCallbackData("Al-Muqoddim", "71"),

                        InlineKeyboardButton.WithCallbackData("Al-Muahhir", "72"),
                    },
                               new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Avval", "73"),

                        InlineKeyboardButton.WithCallbackData("Al-Ahir", "74"),

                        InlineKeyboardButton.WithCallbackData("Az-Zohir", "75"),
                    },
                                 new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Batin", "76"),

                        InlineKeyboardButton.WithCallbackData("Al-Vali", "77"),

                        InlineKeyboardButton.WithCallbackData("Al-Mutaali", "78"),
                    },
                                   new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Barr", "79"),

                        InlineKeyboardButton.WithCallbackData("At-Tavvab", "80"),

                        InlineKeyboardButton.WithCallbackData("Al-Muntaqim", "81"),
                    },
                                     new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Afuvv", "82"),

                        InlineKeyboardButton.WithCallbackData("Ar-Rouf", "83"),

                        InlineKeyboardButton.WithCallbackData("Malik-Ul-Mulk", "84"),
                    },
                          new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Zil-Jalali val'ikrom", "85"),

                        InlineKeyboardButton.WithCallbackData("Al-Muqsit", "86"),

                        InlineKeyboardButton.WithCallbackData("Al-Jami", "87"),
                    },
                            new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-G'oni", "88"),

                        InlineKeyboardButton.WithCallbackData("Al-Mug'ni", "89"),

                        InlineKeyboardButton.WithCallbackData("Al-Mani", "90"),
                    },
                              new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Az-Zorr", "91"),

                        InlineKeyboardButton.WithCallbackData("An-Nafi", "92"),

                        InlineKeyboardButton.WithCallbackData("An-Nur", "93"),
                    },
                                new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Hadi", "94"),

                        InlineKeyboardButton.WithCallbackData("Al-Badi", "95"),

                        InlineKeyboardButton.WithCallbackData("Al-Baqi", "96"),
                    },
                                  new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Al-Varis", "97"),

                        InlineKeyboardButton.WithCallbackData("Ar-Roshid", "98"),

                        InlineKeyboardButton.WithCallbackData("A-Sobur", "99"),
                    },
                                    new InlineKeyboardButton[] {
                        InlineKeyboardButton.WithCallbackData("Orqaga🔙", "back"),
                    },
           };

            InlineKeyboardMarkup javob3 = new InlineKeyboardMarkup(button3);

            return javob3;
        }

        internal static IReplyMarkup webapi2()
        {
            throw new NotImplementedException();
        }

        internal static IReplyMarkup webapi()
        {
            throw new NotImplementedException();
        }

        internal static IReplyMarkup webapi3()
        {
            throw new NotImplementedException();
        }

        public static InlineKeyboardMarkup SendLinks() {


            var keyboard = new InlineKeyboardMarkup
            (
                new InlineKeyboardButton[][]
                {
                   
                    new InlineKeyboardButton[] {
                        
                        InlineKeyboardButton.WithUrl("Abdullooh Domla Maruzalari. ↗️", "https://t.me/Abdulloh_maruzalar_ilmnuri_domla"),
                    },
                       new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithUrl("Shayx Muhammad Sodiq Muhlislari. ↗️", "https://t.me/Shayx_MuhammadSodiquzb"),
                    },
                          new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithUrl("Shukrulloh Domla Maruzalari. ↗️", "https://t.me/abdulloh_islom_SHukrulloh_Domla"),
                    },
                             new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithUrl("Abror Muxtor Aliy. ↗️", "https://t.me/AbrorMuxtorAliy"),
                    },
                }
            );

            return keyboard;
        }

        internal static IReplyMarkup webapiru()
        {
            throw new NotImplementedException();
        }

        internal static IReplyMarkup webapi2ru()
        {
            throw new NotImplementedException();
        }

        internal static IReplyMarkup webapi3ru()
        {
            throw new NotImplementedException();
        }
    }
}

