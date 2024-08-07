using Microsoft.AspNetCore.Mvc;
using RV24.PMA.CrossCutting.DataClasses;
using RV24.PMA.Logic.Domain.PersonManagement;
using RV24.PMA.Logic.Domain.PersonManagement.Contract;

namespace ApiClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonManager _personManager;

        public PersonsController(IPersonManager personManager)
        {
            _personManager = personManager;
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
