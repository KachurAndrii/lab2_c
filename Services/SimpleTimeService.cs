using lab2.Services;
using System;

namespace lab2.Services
{
    public class SimpleTimeService : ITimeService
    {
        public DateTime GetTimeForTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}