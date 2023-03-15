using NewHireTask.Entities; 
using Microsoft.AspNetCore.Mvc;
using NewHireTask.Repositories;


namespace NewHireTask.Controllers
{
    [ApiController]
    [Route("ieps")]
    public class IepsController : ControllerBase
    {
        private readonly IepRepository repository;
        
        public IepsController(IepRepository repository){
            this.repository = repository;
        }
        [HttpGet]
        public IEnumerable<Iep> GetIeps()
        {
            var ieps = repository.GetIeps();
            return ieps;
        }

        [HttpGet("{id}")]
         public ActionResult<Iep> GetIep(Guid id)
        {
             var iep = repository.GetIep(id);

               if (iep == null)
              {
                 return NotFound();
              }
          // check for IEPs
           return Ok(iep);
         }
         //to delete IEPs
         [HttpDelete("{id}")]
        public IActionResult DeleteIep(Guid id)
         {
             var iep = repository.GetIep(id);

               if (iep == null)
              {
                return NotFound();
              }

             repository.DeleteIep(id);

               return NoContent();
          }

           }
}