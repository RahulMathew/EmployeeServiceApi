using EmployeeServiceApi.Models;
using BusinessLayer.Interfaces;
using EmployeeServiceApi.Services.Interfaces;

namespace EmployeeServiceApi.Services.Core
{
    public class EmployeeService : IEmployeeService
    {
        #region Declaration

        private readonly IEmployeeRepository _employeeRepository;

        #endregion Declaration

        #region Constructor

        public EmployeeService(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        }

        #endregion Constructor

        #region Public Methods

        public async Task<ApiResponse> GetEmployees(int page, int pageSize)
        {
            return new ApiOkResponse(await _employeeRepository.GetEmployees(page, pageSize));
        }

        #endregion Public Methods
    }
}
