using bot.Models;

namespace bot.Extensions
{
    public static class PrayerTimeExtensions
    {
        public static PrayerTime ToPrayerTimeModel(this Dto.Aladhan.PrayerTimeDto dto)
        {
            return new PrayerTime()
            {
                Fajr = dto.Data.Timings.Fajr,
                Dhuhr = dto.Data.Timings.Dhuhr,
                Sunrise = dto.Data.Timings.Sunrise,
                Asr = dto.Data.Timings.Asr,
                Maghrib = dto.Data.Timings.Maghrib,
                Isha = dto.Data.Timings.Isha,
                Sunset = dto.Data.Timings.Sunset,
                Midnight = dto.Data.Timings.Midnight,
                Source = "aladhan.com",
                CalculationMethod = dto.Data.Meta.Method.Name,
                Timezone = dto.Data.Meta.Timezone
            };
        }
    
    }
}