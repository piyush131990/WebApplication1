using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DateCalculatorController : ApiController
    {
        // GET: DateCalculator
        // Api/DateCalculator?Day=Tuesday
        //https://localhost:44347/Api/DateCalculator?Day=Tuesday
        public string Get(string Day)
        {
            DateTime result = DateTime.UtcNow.AddDays(1);
            while (result.DayOfWeek.ToString() != Day)
                result = result.AddDays(1);
            return result.AddDays(1).ToString();
        }
    }
}