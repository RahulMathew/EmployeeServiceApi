using System;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeServiceApi.Models
{
    public class ApiBadRequestResponse : ApiResponse
    {
        public List<ValidationResult> Errors { get; }

        public ApiBadRequestResponse(List<ValidationResult> validationResults)
            : base(StatusCodes.Status400BadRequest)
        {
            Errors = validationResults;
        }
    }
}
