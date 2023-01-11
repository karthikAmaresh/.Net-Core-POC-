using MediatR;
using UserManagement.API.Data;
using UserManagement.Models;
using UserManagement.Queries;

namespace UserManagement.Handlers
{
    public class GetEmployeesListHandler : IRequestHandler<GetEmployeesListQuery , List<EmployeeModel>>
    {
        private readonly IDataAccess _dataAccess;
        public GetEmployeesListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<EmployeeModel>> Handle(GetEmployeesListQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetEmployees());
        }
    }
}
