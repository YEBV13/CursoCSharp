using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = CheckMonth(month);
            this.day = CheckDay(year, month, day); 
        }

        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            throw new DayException($"Invalid Day: {day}!");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            
            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)           
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}


            throw new NotImplementedException();
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException($"Invalid Month: {month}!");
        }
        public override string ToString()
        {
            return $"{year}/{month:00}/{day:00}";
        }
    }
}
