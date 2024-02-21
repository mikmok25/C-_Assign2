using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfStatementW2024.Controllers
{
    public class RouteController : ApiController
    {

        // GET api/route/rabbit ->  Rabbit Method

        [HttpGet]
        [Route("api/Route/rabbit")]
        public string Method1()

        {
            return "Rabbit Method";
        }

        [HttpGet]
        [Route("api/Route/fish")]

        public string Method2()
        {
            return "Fish Method";
        }

        [HttpGet]
        [Route("api/Route/{x}/{y}")]
        public int Multiply(int x, int y)
        {
            int product = x * y;
            return product;
        }
    }
}
