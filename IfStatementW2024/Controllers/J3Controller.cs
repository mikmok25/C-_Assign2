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
        [HttpGet]
        [Route("api/nextDistinctYear/{year}")]

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
