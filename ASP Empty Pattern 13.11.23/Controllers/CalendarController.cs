using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ASP_Empty_Pattern_13._11._23.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Current_Month()
        {
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            List<DateTime> days = new List<DateTime>();

            int countMonthDays = 0;
            if(DateTime.Now.Month == 1 
            || DateTime.Now.Month == 3 
            || DateTime.Now.Month == 5 
            || DateTime.Now.Month == 7
            || DateTime.Now.Month == 8
            || DateTime.Now.Month == 10
            || DateTime.Now.Month == 12)
            {
                countMonthDays = 31;

            }
            else if(DateTime.Now.Month == 4
                || DateTime.Now.Month == 6
                || DateTime.Now.Month == 9
                || DateTime.Now.Month == 11)
            {
                countMonthDays = 30;
            }
            else
            {
                countMonthDays = 28;
            }

            for (int i = 1; i <= countMonthDays; i++)
            {
                DateTime myDT = new DateTime(DateTime.Now.Year, DateTime.Now.Month, i);
                days.Add(myDT);
            }

            string getCalendar()
            {
                string output = $"Год: {myCal.GetYear(days[0])}\nМесяц: {myCal.GetMonth(days[0])}\n\nЧисло:\n";
                for (int i = 0; i < countMonthDays; i++)
                {
                    if(i == 7 || i == 14 || i == 21 || i == 28)
                    {
                        output += "\n\n";
                    }
                    if (myCal.GetDayOfMonth(days[i]) == DateTime.Now.Day)
                    {

                    }
                   output += $"{myCal.GetDayOfMonth(days[i])}  ";
                }
                return output;
            }
            return getCalendar();
        }
    }
}
