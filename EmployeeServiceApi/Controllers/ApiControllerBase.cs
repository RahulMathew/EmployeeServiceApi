using System.Net;
using Microsoft.AspNetCore.Mvc;
using EmployeeServiceApi.Models;

namespace EmployeeServiceApi.Controllers
{
    public abstract class ApiControllerBase : ControllerBase
    {
        #region Protected Methods

        protected internal IActionResult GetResult(ApiResponse apiResponse)
        {
            if (apiResponse.StatusCode == StatusCodes.Status200OK)
                return Ok(apiResponse);
            if (apiResponse.StatusCode == StatusCodes.Status400BadRequest)
                return BadRequest(apiResponse);
            else if (apiResponse.StatusCode == StatusCodes.Status204NoContent)
                return NotFound(apiResponse);
            else if (apiResponse.StatusCode == StatusCodes.Status404NotFound)
                return NotFound(apiResponse);
            else
                return Ok(apiResponse);
        }

        #endregion Protected Methods
    }
}
