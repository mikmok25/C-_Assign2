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

        /// <summary>
        /// Determines the number of ways Diana can roll the value of 10 with two dice of given sides.
        /// </summary>
        /// <param name="m">Number of sides on the first die</param>
        /// <param name="n">Number of sides on the second die</param>
        /// <returns>The number of ways to roll the value of 10</returns>
        /// <example>
        ///     GET : /api/J2/DiceGame/6/8/  ->  "There are 5 total ways to get the sum 10."
        ///     GET : /api/J2/DiceGame/12/4  ->  "There are 4 ways to get the sum 10."
        ///     GET : /api/J2/DiceGame/3/3  ->  "There are 0 ways to get the sum 10."
        ///     GET : /api/J2/DiceGame/5/5  ->  "There is 1 way to get the sum 10."
        ///     
        /// </example>


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
