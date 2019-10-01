using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingSensationController : ControllerBase
    {
        // GET api/TrainingSensation
        [HttpGet()]
        public ActionResult<IEnumerable<string>> GetAll([FromQuery]int ItemsPerPage, [FromQuery]int Page) {
            return new string[] { "TrainingSensation Get All" };
        }

        // GET api/TrainingSensation/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(Guid Id) {
            return "TrainingSensation Get by Id";
        }

        // POST api/TrainingSensation
        [HttpPost]
        public ActionResult<string> Add([FromBody]TrainingSensation TrainingSensation) {
            return "TrainingSensation Post";
        }

        // PUT api/TrainingSensation/5
        [HttpPut("{Id}")]
        public ActionResult<string> Update(Guid Id, [FromBody]TrainingSensation TrainingSensation) {
            return "TrainingSensation Put";
        }

        // PATCH api/TrainingSensation/5
        [HttpPatch("{Id}")]
        public ActionResult<string> UpdateStatus(Guid Id) {
            return "TrainingSensation Patch";
        }

        // DELETE api/TrainingSensation/5
        [HttpDelete("{Id}")]
        public ActionResult<string> Delete(Guid Id) {
            return "TrainingSensation Delete";
        }

    }
}