using System.Net;

namespace EmployeeServiceApi.Models
{
    public class ApiNotFoundResponse : ApiResponse
    {
        public object Result { get; }

        public ApiNotFoundResponse(object result)
            : base(StatusCodes.Status404NotFound)
        {
            Result = result;
        }
    }
}
