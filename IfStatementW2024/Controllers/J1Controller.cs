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

        /// <summary>
        /// Calculates the total calorie count based on choices of burger, drink, side, and dessert.
        /// </summary>
        /// <param name="burger">The choice of burger (1 for Cheeseburger, 2 for Fish Burger, 3 for Veggie Burger, 4 for no burger)</param>
        /// <param name="drink">The choice of drink (1 for Soft Drink, 2 for Orange Juice, 3 for Milk, 4 for no drink)</param>
        /// <param name="side">The choice of side order (1 for Fries, 2 for Baked Potato, 3 for Chef Salad, 4 for no side order)</param>
        /// <param name="dessert">The choice of dessert (1 for Apple Pie, 2 for Sundae, 3 for Fruit Cup, 4 for No Dessert)</param>
        /// <returns>The total calorie count based on the chosen items</returns>
        /// <example>
        ///     GET : /api/J1/Menu/4/4/4/4      ->      "Your total calorie count is 0"
        ///     GET : /api/J1/Menu/1/2/3/4      ->      "Your total calorie count is 691"
        ///     
        /// </example>
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
