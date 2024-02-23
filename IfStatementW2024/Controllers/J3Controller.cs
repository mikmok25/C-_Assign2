using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfStatementW2024.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Finds the next year after the given year with distinct digits.
        /// </summary>
        /// <param name="year">The starting year</param>
        /// <returns>The next year after the given year with distinct digits</returns>
        /// <example>
        ///     GET : /api/J3/NextDistinctYear/1987 -> 2013
        ///     GET : /api/J3/NextDistinctYear/999 -> 1023
        /// </example>
        /// <remarks>
        /// This function iterates through years starting from the next year after the given year
        /// until it finds a year where all the digits are distinct.
        /// </remarks>
        [HttpGet]
        [Route("api/J3/NextDistinctYear/{year}")]

        public int nextDistinctYear(int year)
        {
            year++;
            while (true)
            {
                char[] digits = year.ToString().ToCharArray();
                bool isDistinct = true;
                for (int i = 0; i < digits.Length; i++)
                {
                    for (int j = i + 1; j < digits.Length; j++)
                    {
                        if (digits[i] == digits[j])
                        {
                            isDistinct = false;
                            break;
                        }
                    }
                    if (!isDistinct) break;
                }
                if (isDistinct) return year;
                year++;
            }

        }
    }
}
