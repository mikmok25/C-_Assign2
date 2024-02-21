using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfStatementW2024.Controllers
{
    public class IfPracticeController : ApiController
    {
        //<summary>
        // Receives information for a track team qualifier, returns if the student 
        // Qualified or not
        //</summary>
        // <param name="HighJump">The maximum highjump in CM</param>
        //<return>
        // QUALIFIED if the student qualified and NOT QUALIFIED if the student did not qualify
        //</return>
        //<example>
        // GET api/ifPractice/TrackAudition/134 => "NOT QUALIFIED"
        // GET api/ifPractice/TrackAudition/150 => "QUALIFIED"
        //</example>


        [HttpGet]
        [Route("api/ifPractice/TrackAudition/{HighJump}")]
        public string TrackAudition(int HighJump)
        {
            string result;
            if (HighJump >= 145)
            {
                result = "QUALIFIED";
            } else if(HighJump < 145 && HighJump >= 120)
            {
                result = "TRYOUTS";
            }
                
           else
            {
                result = "NOT QUALIFIED";
            }

            return result;
        }
    }
}
