using System;
using System.Collections.Generic;
using System.Globalization;
using Telegram.Bot.Types.ReplyMarkups;

namespace bot
{
    public partial class MessageBuilder
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
       
        public static ReplyKeyboardMarkup menu()
         => new ReplyKeyboardMarkup()
         {
             Keyboard = new List<List<KeyboardButton>>()
                            {
                                new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Namoz Vaqtlari 📍 .", RequestLocation = true },
                                   new KeyboardButton(){ Text = "Hijriy kalendar 🗓🕌" }
                                

                                },
                                 new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Asma-ul-Husna ☪️💟" },
                                   new KeyboardButton(){ Text =  "Foydali Kanallar 🔗" }

                                }, new List<KeyboardButton>()
                                {
                                  
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
       
        public static InlineKeyboardMarkup Asosiy()
        {
            InlineKeyboardButton Button11 = new InlineKeyboardButton();
            InlineKeyboardButton Button12 = new InlineKeyboardButton();
            InlineKeyboardButton Button21= new InlineKeyboardButton();
            Button11.Text = "1-33";
            Button11.CallbackData = "1-33";
            Button12.Text = "33-66";
            Button12.CallbackData = "33-66";
            Button21.Text = "66-99";
            Button21.CallbackData = "66-99";
            InlineKeyboardButton boshmenyu= new InlineKeyboardButton();
            boshmenyu.Text="Asosiy Menyu";
            boshmenyu.CallbackData="glavniy";  
            InlineKeyboardButton[] help = new InlineKeyboardButton[] {boshmenyu};
            InlineKeyboardButton[] help2 = new InlineKeyboardButton[] {Button11, Button12 ,Button21};
            InlineKeyboardButton[][] buttons = new InlineKeyboardButton[][] {help2,help};
            InlineKeyboardMarkup inline3 = new InlineKeyboardMarkup(buttons);
            return inline3;
        }

        public static InlineKeyboardMarkup bittaorqaga(){
            InlineKeyboardButton nazad =new InlineKeyboardButton();
            nazad.CallbackData="nazad";
            nazad.Text="Orqaga🔙";
            InlineKeyboardMarkup ans =new InlineKeyboardMarkup(nazad);
            return ans;
        }       
        
   public static void DisplayValues( Calendar myCal, DateTime myDT ){
      Console.WriteLine( "       Yil: {0}", myCal.GetYear( myDT ) );
      Console.WriteLine( "        Oy: {0}", myCal.GetMonth( myDT ) );
      Console.WriteLine( "       Kun: {0}", myCal.GetDayOfMonth( myDT ) );
      Console.WriteLine( "Hafta kuni: {0}", myCal.GetDayOfWeek( myDT ) );
      Console.WriteLine();
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
                    new InlineKeyboardButton[] {

                        InlineKeyboardButton.WithCallbackData("Asosiy Menyu", "glavniy"),
                    },
                }
            );

            return keyboard;
        }

       public static void webapiru()
        {
           throw new NotImplementedException();
        }
  
    }
}

