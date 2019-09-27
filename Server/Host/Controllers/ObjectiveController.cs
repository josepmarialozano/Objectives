using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectiveController : ControllerBase
    {
        // GET api/Objective
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() {
            return new string[] { "Objective1", "Objective2" };
        }

    }
}