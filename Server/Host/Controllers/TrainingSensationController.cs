namespace Controller.Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Controller.DtoEntity;
    using LogicSingleton;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class TrainingSensationController : ControllerBase {
        // GET api/TrainingSensation
        [HttpGet()]
        public ActionResult<List<TrainingSensation>> GetAll([FromQuery]int itemsPerPage, [FromQuery]int page) {
            return Singleton.TrainingSensationSelectAll.ExecuteSelectAll(itemsPerPage, page);
        }

        // GET api/TrainingSensation/5
        [HttpGet("{id}")]
        public ActionResult<TrainingSensation> Get(Guid id) {
            return Singleton.TrainingSensationSelect.ExecuteSelect(id);
        }

        // POST api/TrainingSensation
        [HttpPost]
        public ActionResult<Guid> Add([FromBody]TrainingSensation trainingSensation) {
            return Singleton.TrainingSensationAdd.ExecuteAdd(trainingSensation);
        }

        // PUT api/TrainingSensation/5
        [HttpPut("{Id}")]
        public ActionResult<TrainingSensation> Update(Guid id, [FromBody]TrainingSensation trainingSensation) {
            trainingSensation.Id = id;
            return Singleton.TrainingSensationUpdate.ExecuteUpdate(trainingSensation);
        }

        // DELETE api/TrainingSensation/5
        [HttpDelete("{Id}")]
        public void Delete(Guid id) {
            Singleton.TrainingSensationDelete.ExecuteDelete(id);
        }

    }
}