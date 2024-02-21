using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfStatementW2024.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame(int m, int n)
        {
            int count = 0;
            int minFirstDieValue = Math.Max(1, 10 - n);
            int maxFirstDieValue = Math.Min(m, 10 - 1);

            for (int i = minFirstDieValue; i <= maxFirstDieValue; i++)
            {
                count++;
            }

            if (count == 0)
            {
                return "There are 0 ways to get the sum 10";
            }
            else if (count == 1)
            {
                return "There is 1 way to get the sum of 10";
            }
            else
            {
                return $"There are {count} total ways to get the sum 10.";
            }
        }
    }
}
