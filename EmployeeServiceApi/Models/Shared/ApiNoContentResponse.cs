using System.Net;

namespace EmployeeServiceApi.Models
{
    public class ApiNoContentResponse : ApiResponse
    {
        public object Result { get; }

        public ApiNoContentResponse(object result)
            : base(StatusCodes.Status204NoContent)
        {
            Result = result;
        }
    }
}
