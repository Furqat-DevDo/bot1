using System;
using System.Threading.Tasks;
using bot.Models;

namespace Telegram_Bot.Http_So_rovlar
{                     // INTERFACE KLASS HTTP KLIENT SHABLONI.
  public interface IPrayerTimeClient
  {
    Task<(bool IsSuccess, PrayerTime prayerTime, Exception exception)>
            GetPrayerTimeAsync(double longitude, double latitude);
  }
}
