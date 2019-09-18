using System;

namespace Entities.Bookingv2
{
    public class Stay
    {
        public Stay(DateTime firstNight, DateTime lastNight)
        {
            if (firstNight > lastNight)
                throw new Exception("First Night Of Stay Cannot Be After Last Night");
            if (DoesNotMeetMinimumStayDuration(firstNight, LastNight))
                throw new Exception("Stay Does Not Meet Minimum Duration");
            this.FirstNight = firstNight;
            this.LastNight = lastNight;
        }
        public DateTime FirstNight { get; private set; }
        public DateTime LastNight { get; private set; }
        private bool DoesNotMeetMinimumStayDuration(DateTime firstNight, DateTime lastNight)
        {
            return (lastNight - firstNight) < TimeSpan.FromDays(3);
        }
    }
}
