using Microsoft.AspNetCore.Mvc;
using EmployeeServiceApi.Models;
using EmployeeServiceApi.Services.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace EmployeeServiceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ApiControllerBase
    {
        #region Declaration

        private readonly IEmployeeService _employeeService;

        #endregion Declaration

        #region Constructor

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        #endregion Constructor

        #region Public Methods

        [HttpGet("GetEmployees/{pageNumber}/{pageSize}")]
        public async Task<IActionResult> GetEmployees(int pageNumber, int pageSize)
        {
            return GetResult(await _employeeService.GetEmployees(pageNumber, pageSize));
        }

        #endregion Public Methods
    }
}