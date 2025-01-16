using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    #region Q2
    public class HireDate
    {
        private int day;
        private int month;
        private int year;
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value <= 31)
                    day = value;
                else
                    day = 0;
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 31)
                    month = value;
                else
                    day = 0;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 2000 && value <= 2025)
                    year = value;

            }
        }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }

    #endregion
}
