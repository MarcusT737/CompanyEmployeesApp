using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public WeatherForecastController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //_repository.Company.AnyMethodFromCompanyRepository();
            //_repository.Employee.AnyMethodFromEmployeeRepository();

            return new string[] { "value1", "value2" };
        }
        //{
        //    private ILoggerManager _repository;

        //    public WeatherForecastController(IRepositoryManager Repository)
        //    {
        //        _repository = Repository;
        //    }

        //    [HttpGet]
        //    public IEnumerable<string> Get()
        //    {
        //        //_logger.LogInfo("Info message from our controller");
        //        //_logger.LogDebug("Debug message from our controller");
        //        //_logger.LogWarn("Warn message from our controller");
        //        //_logger.LogError("Error message from our controller");

        //        //return new string[] { "Value 1", "Value 2" };
        //    }
        //}
    }
}
