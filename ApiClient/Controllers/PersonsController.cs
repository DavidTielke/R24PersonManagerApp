using Microsoft.AspNetCore.Mvc;
using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Logic.Domain.PersonManagement;

namespace ApiClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly PersonManager _personManager;

        public PersonsController()
        {
            _personManager = new PersonManager(null);
        }

        [Route("Adults")]
        [HttpGet()]
        public IEnumerable<Person> GetAllAdults()
        {
            return _personManager.GetAllAdults();
        }


        [Route("Children")]
        [HttpGet()]
        public IEnumerable<Person> GetAllChildren()
        {
            return _personManager.GetAllChildren();
        }
    }
}
