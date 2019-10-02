using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingTypeController : ControllerBase {
        // GET api/TrainingType
        [HttpGet()]
        public ActionResult<IEnumerable<string>> GetAll([FromQuery]int ItemsPerPage, [FromQuery]int Page) {
            return new string[] { "TrainingType Get All" };
        }

        // GET api/TrainingType/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid Id) {
            return "TrainingType Get by Id";
        }

        // POST api/TrainingType
        [HttpPost]
        public ActionResult<string> Add([FromBody]TrainingType TrainingType) {
            return "TrainingType Post";
        }

        // PUT api/TrainingType/5
        [HttpPut("{Id}")]
        public ActionResult<string> Update(Guid Id, [FromBody]TrainingType TrainingType) {
            return "TrainingType Put";
        }

        // PATCH api/TrainingType/5
        [HttpPatch("{Id}")]
        public ActionResult<string> UpdateStatus(Guid Id) {
            return "TrainingType Patch";
        }

        // DELETE api/TrainingType/5
        [HttpDelete("{Id}")]
        public ActionResult<string> Delete(Guid Id) {
            return "TrainingType Delete";
        }

    }
}