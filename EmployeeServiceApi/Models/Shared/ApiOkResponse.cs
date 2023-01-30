using System.Net;

namespace EmployeeServiceApi.Models
{
    public class ApiOkResponse : ApiResponse
    {
        public object Result { get; }

        public ApiOkResponse(object result)
            : base(StatusCodes.Status200OK)
        {
            Result = result;
        }
    }
}
