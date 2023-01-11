using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using UserManagement.API.Data;
using UserManagement.Models;
using UserManagement.Queries;

namespace UserManagement.Handlers
{
    public class GetEmployeeSalaryRangeHandler : IRequestHandler<SelectRangeQuery, List<EmployeeModel>>
    {
        private readonly IDataAccess _dataAccess;
        public GetEmployeeSalaryRangeHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<EmployeeModel>> Handle(SelectRangeQuery query, CancellationToken cancellationToken)
        {
             return Task.FromResult(_dataAccess.GetEmployees().Where(x=>x.Salary >= query.MinSalary && x.Salary <= query.MaxSalary).ToList());
        }
    }
}
