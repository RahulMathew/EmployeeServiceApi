using EmployeeServiceApi.Models;

namespace EmployeeServiceApi.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<ApiResponse> GetEmployees(int page, int pageSize);
    }
}
