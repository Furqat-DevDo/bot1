using System;
using System.Collections.Generic;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace bot{
    public partial class MessageBuilder{
        
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

        public static ReplyKeyboardMarkup menurus()

             => new ReplyKeyboardMarkup()
             {
                 Keyboard = new List<List<KeyboardButton>>()
                            {
                                new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Время молитв.📍 ", RequestLocation = true },
                                   new KeyboardButton(){ Text = "Исламский календарь🗓🕌" }

                                },
                                 new List<KeyboardButton>()
                                {
                                   new KeyboardButton(){ Text = "Асма-Уль-Хусна ☪️💟" },
                                   new KeyboardButton(){ Text =  "Полезные каналы 🔗" }

                                }, new List<KeyboardButton>()
                                {
                                   
                                   new KeyboardButton(){ Text = "Настройки ⚙️" }

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
           public static InlineKeyboardMarkup Asosiyru()
        {
            InlineKeyboardButton Button11 = new InlineKeyboardButton();
            InlineKeyboardButton Button12 = new InlineKeyboardButton();
            InlineKeyboardButton Button21= new InlineKeyboardButton();
            Button11.Text = "1-33";
            Button11.CallbackData = "1-33ru";
            Button12.Text = "33-66";
            Button12.CallbackData = "33-66ru";
            Button21.Text = "66-99";
            Button21.CallbackData = "66-99ru";
            InlineKeyboardButton boshmenyu= new InlineKeyboardButton();
            boshmenyu.Text="На главную меню 🔰";
            boshmenyu.CallbackData="glavniyru";  
            InlineKeyboardButton[] help = new InlineKeyboardButton[] {boshmenyu};
            InlineKeyboardButton[] help2 = new InlineKeyboardButton[] {Button11, Button12 ,Button21};
            InlineKeyboardButton[][] buttons = new InlineKeyboardButton[][] {help2,help};
            InlineKeyboardMarkup inline3 = new InlineKeyboardMarkup(buttons);
            return inline3;
        } 
         public static InlineKeyboardMarkup SendLinksru() {


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

                        InlineKeyboardButton.WithCallbackData("На главную меню 🔰", "glavniyru"),
                    },
                }
            );

            return keyboard;
        }
    }
}