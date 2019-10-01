
namespace Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Entities;

    [Route("api/[controller]")]
    [ApiController]
    public class ObjectiveController : ControllerBase {
        // GET api/Objective
        [HttpGet()]
        public ActionResult<IEnumerable<string>> GetAll([FromQuery]int ItemsPerPage, [FromQuery]int Page) {
            return new string[] { "Objective Get All" };
        }

        // GET api/Objective/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid Id) {
            return "Objective Get by Id";
        }

        // POST api/Objective
        [HttpPost]
        public ActionResult<string> Add([FromBody]Objective Objective) {
            return "Objective Post";
        }

        // PUT api/Objective/5
        [HttpPut("{Id}")]
        public ActionResult<string> Update(Guid Id, [FromBody]Objective Objective) {
            return "Objective Put";
        }

        // PATCH api/Objective/5
        [HttpPatch("{Id}")]
        public ActionResult<string> UpdateStatus(Guid Id) {
            return "Objective Patch";
        }

        // DELETE api/Objective/5
        [HttpDelete("{Id}")]
        public ActionResult<string> Delete(Guid Id) {
            return "Objective Delete";
        }
    }
}