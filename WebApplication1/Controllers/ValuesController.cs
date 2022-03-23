using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DomainServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IValuesRepository _valuesRepository;

        public ValuesController(IValuesRepository valuesRepository)
        {
            _valuesRepository = valuesRepository;
        }

        [HttpGet]
        public int Get()
        {
            return _valuesRepository.GetValue();
        }
    }
}
