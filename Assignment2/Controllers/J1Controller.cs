using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        //--https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf(J1)
        /// <summary>
        ///     count the total calories 
        /// </summary>
        /// <param name="burger">choose the burger menu by input number between 1-4 </param>
        /// <param name="drink">choose the drink menu by input number between 1-4</param>
        /// <param name="side">choose the side menu by input number between 1-4</param>
        /// <param name="dessert">choose the dessert menu by input number between 1-4</param>
        /// <returns>get the number of calories and added the 4 numbers together</returns>
        /// <example>
        ///     GET: /api/J1/Menu/1/2/3/4  --> 691
        ///     GET: /api/J1/Menu/2/2/3/1  --> 828
        /// </example>

        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] menuBurger = { 461, 431, 420, 0 };
            int[] menuDrink = { 130, 160, 118, 0 };
            int[] menuSide = { 100, 57, 70, 0 };
            int[] menuDessert = { 167, 266, 75, 0 };

            int total = 0;
            int tempA = 0;
            int tempB = 0;
            int tempC = 0;
            int tempD = 0;

            for (int i = 0; i < menuBurger.Length + 1; i++)
            {
                if (burger - 1 == i)
                {
                    tempA = menuBurger[i];
                }
            }

            for (int i = 0; i < menuDrink.Length + 1; i++)
            {
                if (drink - 1 == i)
                {
                    tempB = menuDrink[i];
                }
            }
            for (int i = 0; i < menuSide.Length + 1; i++)
            {
                if (side - 1 == i)
                {
                    tempC = menuSide[i];
                }
            }

            for (int i = 0; i < menuDessert.Length + 1; i++)
            {
                if(dessert - 1 == i)
                {
                    tempD = menuDessert[i];
                }
            }

            total += tempA + tempB + tempC + tempD;
            return ("Your total calorie count is " + total.ToString());
            
        }
    }
}
