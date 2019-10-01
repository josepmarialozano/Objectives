namespace Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Entities;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase {

        // GET api/Training
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll([FromQuery]Guid ObjectiveId, [FromQuery]int ItemsPerPage, [FromQuery]int Page) {
            return new string[] { "Training Get All" };
        }

        // GET api/Training/5
        [HttpGet("{Id}")]
        public ActionResult<string> Get(Guid Id) {
            return "Training Get by Id";
        }

        // POST api/Training
        [HttpPost]
        public ActionResult<string> Add([FromBody]Training Training) {
            return "Training Post";
        }

        // PUT api/Training/5
        [HttpPut("{Id}")]
        public ActionResult<string> Update(Guid Id, [FromBody]Training Training) {
            return "Training Put";
        }

        // DELETE api/Training/5
        [HttpDelete("{Id}")]
        public ActionResult<string> Delete(Guid Id) {
            // async Task<IActionResult>
            return "Training Delete";
        }
    }
}