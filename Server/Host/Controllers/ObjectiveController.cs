namespace Controller.Host.Controllers {
    using System;
    using System.Collections.Generic;
    using Controller.DtoEntity;
    using Microsoft.AspNetCore.Mvc;
    using LogicSingleton;

    [Route("api/[controller]")]
    [ApiController]
    public class ObjectiveController : ControllerBase {
        // GET api/Objective
        [HttpGet()]
        public ActionResult<List<Objective>> GetAll([FromQuery]int itemsPerPage, [FromQuery]int page) {
            return Singleton.ObjectiveSelectAll.ExecuteSelectAll(itemsPerPage, page);
        }

        // GET api/Objective/5
        [HttpGet("{id}")]
        public ActionResult<Objective> Get(Guid id) {
            return Singleton.ObjectiveSelect.ExecuteSelect(id);
        }

        // POST api/Objective
        [HttpPost]
        public ActionResult<Guid> Add([FromBody]Objective objective) {
            return Singleton.ObjectiveAdd.ExecuteAdd(objective);
        }

        // PUT api/Objective/5
        [HttpPut]
        public ActionResult<Objective> Update([FromBody]Objective objective) {
            return Singleton.ObjectiveUpdate.ExecuteUpdate(objective);
        }

        // PATCH api/Objective/5
        [HttpPatch("{Id}")]
        public void UpdateStatus(Guid id) {
            Singleton.ObjectiveUpdateStatus.ExecuteUpdateStatus(id);
        }

        // DELETE api/Objective/5
        [HttpDelete("{Id}")]
        public void Delete(Guid id) {
            Singleton.ObjectiveDelete.ExecuteDelete(id);
        }
    }
}