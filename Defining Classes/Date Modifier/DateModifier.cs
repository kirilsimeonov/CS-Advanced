using System;
using System.Linq;
namespace DefiningClasses
{
    public class DateModifier
    {
        //public int Difference { get; set; }
        public string Date1 { get; set; }
        public string Date2 { get; set; }


        public DateModifier()
        {

        }
        public DateModifier(string day1, string day2)
        {
            Date1 = day1;
            Date2 = day2;
        }


        public double Calculate()

        {
            var a = Date1.Split().ToList();
            int aYear = int.Parse(a[0]);
            int aMonth = int.Parse(a[1]);
            int aDay = int.Parse(a[2]);
            var b = Date2.Split().ToList();
            int bYear = int.Parse(b[0]);
            int bMonth = int.Parse(b[1]);
            int bDay = int.Parse(b[2]);

            DateTime d1 = new DateTime(aYear,aMonth,aDay);
            DateTime d2 = new DateTime(bYear, bMonth, bDay);
            TimeSpan time = d1 - d2;
            return Math.Abs(time.TotalDays);
        }
    }
}