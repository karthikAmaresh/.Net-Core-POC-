using MediatR;
using UserManagement.Models;

namespace UserManagement.Queries
{
    public class SelectRangeQuery : IRequest<List<EmployeeModel>>
    {
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; } 
    }
}
