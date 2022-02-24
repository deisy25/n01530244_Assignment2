using System.Web.Http;

namespace Assignment2.Controllers
{
    //--https://www.cemc.uwaterloo.ca/contests/computing/2011/stage1/juniorEn.pdf (J3)
    /// <summary>
    ///     to get the length of the sumac sequences
    /// </summary>
    /// <param name="a">pick the number </param>
    /// <param name="b">pick the number</param>
    /// <returns>an array that shows the sumac sequences and the length of sumac sequences</returns>
    /// <example>
    ///     GET: /api/J3/sumacSequences/120/71 --> 
    ///             120, 71, 49, 22, 27
    ///             The length of sumac sequence is 5
    ///     GET: /api/J3/sumacSequences/100/39  --> 
    ///             100, 39, 61
    ///             The length of sumac sequence is 3
    /// </example>

    public class J3Controller : ApiController
    {
        [HttpGet]
        [Route("api/J3/sumacSequences/{a}/{b}")]
   
        public string[] sumacSequences(int a, int b)
        {
            int count = 2;
            int temp;
            string allTemp= a.ToString() + ", " + b.ToString();
            while(a >= b && a >= 0 && b >= 0)
            {
                count += 1;
                temp = a - b;
                a = b;
                b = temp;
                allTemp = allTemp +  " , " + temp;
            }
            return new string [] {allTemp, "The length of sumac sequence is " + count.ToString() };
        }
    }
}
