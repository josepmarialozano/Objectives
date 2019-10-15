namespace Controller.Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Controller.DtoEntity;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ObjectiveController : ControllerBase {
        // GET api/Objective
        [HttpGet()]
        public ActionResult<List<Objective>> GetAll([FromQuery]int ItemsPerPage, [FromQuery]int Page) {
            return null;
        }

        // GET api/Objective/5
        [HttpGet("{id}")]
        public ActionResult<Objective> Get(Guid Id) {
            return null;
        }

        // POST api/Objective
        [HttpPost]
        public ActionResult<Guid> Add([FromBody]Objective Objective) {
            return Guid.Empty;
        }

        // PUT api/Objective/5
        [HttpPut]
        public ActionResult<Objective> Update([FromBody]Objective Objective) {
            return null;
        }

        // PATCH api/Objective/5
        [HttpPatch("{Id}")]
        public void UpdateStatus(Guid Id) {

        }

        // DELETE api/Objective/5
        [HttpDelete("{Id}")]
        public void Delete(Guid Id) {
        }
    }
}