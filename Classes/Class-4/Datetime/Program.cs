using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            //Console.WriteLine(today);

            //DateTime threeDaysLater = today.AddDays(3);
            //Console.WriteLine(threeDaysLater);

            //DateTime threeHoursLater = today.AddHours(3);
            //Console.WriteLine(threeHoursLater);

            //DateTime threeMinutesLater = today.AddMinutes(3);
            //Console.WriteLine(threeMinutesLater);

            //DateTime threeMonthsLater = today.AddMonths(3);
            //Console.WriteLine(threeMonthsLater);

            //DateTime threeYearsLater = today.AddYears(-3);
            //Console.WriteLine(threeYearsLater);

            //DateTime myBirthDay = new DateTime(1998, 7, 19, 9, 57, 30);
            //Console.WriteLine(myBirthDay);

            //Console.WriteLine(today.Year);
            //Console.WriteLine(today.Month);
            //Console.WriteLine(today.Day);

            //bool isSameDate = myBirthDay > today;
            //Console.WriteLine(isSameDate);

            //Console.WriteLine(today.ToShortDateString());
            //Console.WriteLine(today.ToShortTimeString());
            //Console.WriteLine(today.DayOfYear);
            //Console.WriteLine(today.DayOfWeek);
            //Console.WriteLine(today.IsDaylightSavingTime());

            Console.WriteLine("Enter how old you are:");
            string myAge = Console.ReadLine();
            if(int.TryParse(myAge, out int inputNum))
            {
            if(today.Year > inputNum)
            {
            Console.WriteLine($"You were born in the year of {today.Year - inputNum}");
            } 
            else
            {
                Console.WriteLine("You are older then time!");
            }
            }
        }
    }
}
