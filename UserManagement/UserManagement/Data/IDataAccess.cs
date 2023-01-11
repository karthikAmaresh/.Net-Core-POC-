using UserManagement.API.Models;
using UserManagement.Models;

namespace UserManagement.API.Data
{
    public interface IDataAccess
    {
        List<UserModel> GetUsers();

        List<EmployeeModel> GetEmployees();

        UserModel AddUser(string firstName, string lastName);
    }
}
