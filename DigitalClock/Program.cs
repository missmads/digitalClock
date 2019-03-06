using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class NumberDisplay
    {
        int value;
        int limit;

        public NumberDisplay(int rolloverLimit)
        {
            limit = rolloverLimit;
            value = 0;
        }

        public void increment()
        {
            value = (value + 1) % limit;
        }

        public string getDisplayValue()
        {
            if (value < 10)
                return "0" + value;
            else
                return "" + value;
        }

        public void setDisplayValue(int newValue)
        {
            if (newValue >= 0 && newValue < limit)
                value = newValue;
        }
    }

    class ClockDisplay
    {
        NumberDisplay hours;
        NumberDisplay minutes;
        //NumberDisplay seconds;

        public ClockDisplay()
        {
            hours = new NumberDisplay(24);
            minutes = new NumberDisplay(60);
            //seconds = new NumberDisplay(60);
        }

        public ClockDisplay(int hour, int minute)
        {
            hours = new NumberDisplay(24);
            minutes = new NumberDisplay(60);
            SetTime(hour, minute);
        }

        void SetTime(int hour, int minute)
        {
            hours.setDisplayValue(hour);
            minutes.setDisplayValue(minute);
        }
    }
}