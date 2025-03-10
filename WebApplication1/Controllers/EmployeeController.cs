using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Web.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IClientResponse _restAPIResponse;
        private readonly IGetOldestEmployee _getEmployee;

        public EmployeeController(ILogger<EmployeeController> logger, IGetOldestEmployee getEmployee, IClientResponse restAPIResponse)
        {
            _logger = logger;
            _getEmployee = getEmployee;
            _restAPIResponse = restAPIResponse;
        }

        [HttpGet(Name = "GetOldestEmployee")]
        public async Task<EmployeeResponse> GetOldestEmployee()
        {
            return await _getEmployee.GetOldestEmployeeList(_restAPIResponse.GetThirdPartyResponse());
        }

    }
}
