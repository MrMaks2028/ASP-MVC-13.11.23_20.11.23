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

        public string calendar()
        {
            DateTime myDT = new DateTime();
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;
            int countMonthDays = 0;
            if(myDT.Month == 1 ||  myDT.Month == 3 || myDT.Month == 5 || myDT.Month == 7 || myDT.Month == 8 || myDT.Month == 10 || myDT.Month == 12)
            {
                countMonthDays = 31;

            }
            else if(myDT.Month == 4 || myDT.Month == 6 || myDT.Month == 9 || myDT.Month == 11)
            {
                countMonthDays = 30;
            }
            else
            {
                countMonthDays = 28;
            }
            string getCalendar()
            {
                string output = $"Год: {myCal.GetYear(myDT)}\nМесяц: {myCal.GetDayOfMonth(myDT)}\n\n";
                for (int i = 1; i <= countMonthDays; i++)
                {
                    if(i == 7 || i == 14 || i == 21 || i == 28)
                    {
                        output += "\n\n";
                    }
                   output += $"Число: {myCal.GetDayOfMonth(myDT) + 1}  ";
                }
                return output;
            }
            return getCalendar();
        }
    }
}
