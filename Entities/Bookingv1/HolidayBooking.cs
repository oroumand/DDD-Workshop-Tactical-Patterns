using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Bookingv1
{
    /// <summary>
    /// تاریخ شروع باید قبل از پایان باشد
    /// حداقل زمان مجاز توقف باید چک شود
    /// 
    /// </summary>
    public class HolidayBooking
    {
        public HolidayBooking(int travelerId, DateTime firstNight,
        DateTime lastNight, DateTime booked)
        {
            this.TravelerId = travelerId;
            this.FirstNight = firstNight;
            this.LastNight = lastNight;
            this.Booked = booked;
            this.Id = GenerateId(travelerId, firstNight, lastNight, booked);
        }
        public string Id { get; private set; }
        public int TravelerId { get; private set; }
        public DateTime FirstNight { get; private set; }
        public DateTime LastNight { get; private set; }
        public DateTime Booked { get; private set; }
        private string GenerateId(int travelerId, DateTime firstNight,
        DateTime lastNight, DateTime booked)
        {
            return string.Format(
            "{0}-{1}-{2}-{3}",
            travelerId, ToIdFormat(firstNight),
            ToIdFormat(lastNight), ToIdFormat(booked)
            );
        }
        private string ToIdFormat(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }

    }
}

