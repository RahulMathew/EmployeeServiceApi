namespace EmployeeServiceApi.Models
{
    public class ApiResponse
    {
        public int StatusCode { get; }

        public ApiResponse(int statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
