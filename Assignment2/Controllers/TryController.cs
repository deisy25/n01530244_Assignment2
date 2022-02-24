using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class TryController : ApiController
    {
        [HttpGet]
        [Route("api/try/FizzyBuzzy/{start}/{limit}/{step}/{fizzy}/{buzzy}")]
        public string FizzyBuzzy(int start, int limit, int step, int fizzy, int buzzy)
        {
            string temp = "";
            for (int i = start; i <= limit; i += step)
            {
                if (i % fizzy==0)
                {
                    temp += "fizzy, ";
                }
                else if (i % buzzy == 0)
                {
                    temp += "buzzy, ";
                }
                else if (i % fizzy == 0 && i % buzzy == 0)
                {
                    temp += "FizzyBuzzy, ";
                }else
                {
                    temp += i.ToString() + ", ";
                }
            }
            return temp;
        }
    }
}
