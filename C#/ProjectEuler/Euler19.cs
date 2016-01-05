using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Euler19 : Problem
    {
        public Euler19()
        {
            ProblemName = "Counting Sundays";
            ProblemNumber = 19;
        }

        public int currentYear = 1900;
        public Month currentMonth = Month.January;
        public Day currentDay = Day.Monday;
        public int dayOfTheMonth = 1;
        public int numberOfStartingSundays = -2;

        protected override void CalculateAnswer()
        {
            CalculateNumberOfStartingSundays();
            Answer = String.Format("Total number of months starting with a sunday is {0}", numberOfStartingSundays);
        }

        public void CalculateNumberOfStartingSundays()
        {
            while (currentYear <= 2000)
            {
                if (dayOfTheMonth == 1 && currentDay == Day.Sunday)
                {
                    numberOfStartingSundays++;
                }
                MoveForwardOneDay();
                if (currentYear == 1901)
                {
                }
            }
        }

        private void MoveForwardOneDay()
        {
            switch (currentMonth)
            {
                case Month.January:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.February;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.February:
                    if (dayOfTheMonth < 28)
                    {
                        dayOfTheMonth++;
                    }
                    else if (dayOfTheMonth == 28)
                    {
                        if (currentYear % 100 == 0)
                        {
                            if (currentYear % 400 == 0)
                            {
                                dayOfTheMonth = 29;
                            }
                            else
                            {
                                dayOfTheMonth = 1;
                                currentMonth = Month.March;
                            }
                        }
                        else if (currentYear % 4 == 0)
                        {
                            dayOfTheMonth = 29;
                        }
                        else
                        {
                            dayOfTheMonth = 1;
                            currentMonth = Month.March;
                        }
                    }
                    else if (dayOfTheMonth == 29)
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.March;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.March:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.April;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.April:
                    if (dayOfTheMonth < 30)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.May;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.May:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.June;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.June:
                    if (dayOfTheMonth < 30)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.July;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.July:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.August;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.August:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.September;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.September:
                    if (dayOfTheMonth < 30)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.October;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.October:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.November;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.November:
                    if (dayOfTheMonth < 30)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentMonth = Month.December;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;

                case Month.December:
                    if (dayOfTheMonth < 31)
                    {
                        dayOfTheMonth++;
                    }
                    else
                    {
                        dayOfTheMonth = 1;
                        currentYear++;
                        currentMonth = Month.January;
                    }
                    currentDay = GetNextDay(currentDay);
                    break;
            }
        }

        private Day GetNextDay(Day day)
        {
            switch (day)
            {
                case Day.Monday:
                    return Day.Tuesday;

                case Day.Tuesday:
                    return Day.Wednesday;

                case Day.Wednesday:
                    return Day.Thursday;

                case Day.Thursday:
                    return Day.Friday;

                case Day.Friday:
                    return Day.Saturday;

                case Day.Saturday:
                    return Day.Sunday;

                case Day.Sunday:
                    return Day.Monday;

                default:
                    throw new Exception("Some weird shit is going on");
            }
        }
    }

    public enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public enum Month
    {
        January, February, March, April, May, June, July, August, September,
        October, November, December
    }
}