 using Microsoft.AspNetCore.Mvc;
using RestWhitAspCoreUdemy.Business;
using RestWhitAspCoreUdemy.Data.VO;
using RestWhitAspCoreUdemy.Model;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using Tapioca.HATEOAS;

namespace RestWhitAspCoreUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonsController : Controller
    {
        private IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        [HttpGet]
        [SwaggerResponse((200), Type = typeof(List<PersonVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [SwaggerResponse((200), Type = typeof(PersonVO))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var person = _personBusiness.FindById(id);
                if (person == null) return NotFound();
                return Ok(person);
        }

        // POST api/values
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        [SwaggerResponse((201), Type = typeof(PersonVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        public IActionResult Post([FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [SwaggerResponse((202), Type = typeof(PersonVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]PersonVO person)
        {
            if (person == null) return BadRequest();
            var updatePerson = _personBusiness.Update(person);

            if (updatePerson == null) return BadRequest();

            return new ObjectResult(updatePerson);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
