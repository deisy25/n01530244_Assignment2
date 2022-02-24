using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    //--https://cemc.math.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf (J2)
    /// <summary>
    ///     to get total ways to get sum of 10
    /// </summary>
    /// <param name="PlayerA"> pick number </param>
    /// <param name="PlayerB">pick number</param>
    /// <returns>a string that shows the total ways</returns>
    /// <example>
    ///     GET: /api/J2/rolldice/6/8 --> 5
    ///     GET: /api/J2/rolldice/15/10  --> 9
    /// </example>

    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/rolldice/{PlayerA}/{PlayerB}")]
        public string rolldice(int PlayerA, int PlayerB)
        {
            int total=0;

            for (int i=1; i < PlayerB+1; i++)
            {
                if (10-i<= PlayerA && 10 - i > 0)
                {
                    total+= 1;
                }
            }

            if (total == 1 || total ==0){
                return "There is " + total + " ways to get the sum of 10";
            } else
            {
                return "There are " + total + " ways to get the sum of 10";
            }

        }

    }
}
