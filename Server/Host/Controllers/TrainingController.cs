namespace Controller.Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Controller.DtoEntity;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase {

        // GET api/Training
        [HttpGet]
        public ActionResult<List<Training>> GetAll([FromQuery]Guid objectiveId, [FromQuery]int itemsPerPage, [FromQuery]int page) {
            return null;
        }

        // GET api/Training/5
        [HttpGet("{Id}")]
        public ActionResult<Training> Get(Guid id) {
            return null;
        }

        // POST api/Training
        [HttpPost]
        public ActionResult<Guid> Add([FromBody]Training training) {
            return null;
        }

        // PUT api/Training/5
        [HttpPut("{Id}")]
        public ActionResult<Training> Update(Guid id, [FromBody]Training training) {
            return null;
        }

        // DELETE api/Training/5
        [HttpDelete("{Id}")]
        public void Delete(Guid id) {
            
        }
    }
}