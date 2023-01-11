using MediatR;
using UserManagement.API.Models;
using UserManagement.Models;

namespace UserManagement.Queries
{
    public record GetEmployeesListQuery() : IRequest<List<EmployeeModel>>;
}
