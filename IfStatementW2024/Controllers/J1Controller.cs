using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfStatementW2024.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public string Menu(int burger, int drink, int side, int dessert)
        {   
            int burgerCalories;
            int drinkCalories;
            int sideCalories;
            int dessertCalories;

            if (burger == 1)
            {
                burgerCalories = 461;
            }
            else if (burger == 2)
            {
                burgerCalories = 431;
            }
            else if (burger == 3)
            {
                burgerCalories = 420;
            }
            else
            {
                burgerCalories = 0;
            }

            if (drink == 1)
            {
                drinkCalories = 130;
            }
            else if (drink == 2)
            {
                drinkCalories = 160;
            }
            else if (drink == 3)
            {
                drinkCalories = 118;
            }
            else
            {
                drinkCalories = 0;
            }

            if (side == 1)
            {
                sideCalories = 100;
            }
            else if (side == 2)
            {
                sideCalories = 57;
            }
            else if (side == 3)
            {
                sideCalories = 70;
            }
            else
            {
                sideCalories = 0;
            }

            if (dessert == 1)
            {
                dessertCalories = 167;
            }
            else if (dessert == 2)
            {
                dessertCalories = 266;
            }
            else if (dessert == 3)
            {
                dessertCalories = 75;
            }
            else
            {
                dessertCalories = 0;
            }


            int totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;

            return $"Your total calorie count is {totalCalories}";
        }
    }
}
