namespace Controller.Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Controller.DtoEntity;
    using Microsoft.AspNetCore.Mvc;
    using LogicSingleton;

    [Route("api/[controller]")]
    [ApiController]
    public class TrainingTypeController : ControllerBase {
        // GET api/TrainingType
        [HttpGet()]
        public ActionResult<IEnumerable<TrainingType>> GetAll([FromQuery]int itemsPerPage, [FromQuery]int page) {
            return Singleton.TrainingTypeSelectAll.ExecuteSelectAll(itemsPerPage, page);
        }

        // GET api/TrainingType/5
        [HttpGet("{id}")]
        public ActionResult<TrainingType> Get(Guid id) {
            return Singleton.TrainingTypeSelect.ExecuteSelect(id);
        }

        // POST api/TrainingType
        [HttpPost]
        public ActionResult<Guid> Add([FromBody]TrainingType trainingType) {
            return Singleton.TrainingTypeAdd.ExecuteAdd(trainingType);
        }

        // PUT api/TrainingType/5
        [HttpPut]
        public ActionResult<TrainingType> Update(Guid id, [FromBody]TrainingType trainingType) {
            trainingType.Id = id;
            return Singleton.TrainingTypeUpdate.ExecuteUpdate(trainingType);
        }

        // DELETE api/TrainingType/5
        [HttpDelete("{Id}")]
        public void Delete(Guid id) {
            Singleton.TrainingTypeDelete.ExecuteDelete(id);
        }

    }
}