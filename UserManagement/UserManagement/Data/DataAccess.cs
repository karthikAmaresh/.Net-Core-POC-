using UserManagement.API.Models;
using UserManagement.Models;

namespace UserManagement.API.Data
{
    public class DataAccess : IDataAccess
    {
        private List<UserModel> _users = new();
        private List<UserAddressModel> _userAddress = new();
        private List<EmployeeModel> _employees = new();

        public DataAccess()
        {

            // user data
            _users.Add(new UserModel { Id = 1, FirstName = "Raj", LastName = "kumar" });
            _users.Add(new UserModel { Id = 2, FirstName = "Kushi", LastName = "Ravindra" });
            _users.Add(new UserModel { Id = 3, FirstName = "Arya", LastName = "Arjun" });
            _users.Add(new UserModel { Id = 4, FirstName = "Shivani", LastName = "S" });
            _users.Add(new UserModel { Id = 5, FirstName = "Hitesh", LastName = "Kumar" });
            _users.Add(new UserModel { Id = 6, FirstName = "Bhoj", LastName = "Raj" });
            _users.Add(new UserModel { Id = 7, FirstName = "Chaitra", LastName = "Vs" });
            _users.Add(new UserModel { Id = 8, FirstName = "Aishwarya", LastName = "Rajendra" });
            _users.Add(new UserModel { Id = 9, FirstName = "Dishanth", LastName = "Raj" });
            _users.Add(new UserModel { Id = 10, FirstName = "Sanjay", LastName = "Kumar" });
            _users.Add(new UserModel { Id = 11, FirstName = "Abhishek", LastName = "Hatti" });
            _users.Add(new UserModel { Id = 12, FirstName = "Amulya", LastName = "Arjun" });

            // user Address

            _userAddress.Add(new UserAddressModel { Id = 1, UserId = 1, ApartmentName = "Sunflower", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 2, UserId = 2, ApartmentName = "Indraprastha", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 3, UserId = 3, ApartmentName = "Indraprastha", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 4, UserId = 4, ApartmentName = "Sunflower", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 5, UserId = 5, ApartmentName = "Swarna Residency", City = "Mysore" });
            _userAddress.Add(new UserAddressModel { Id = 6, UserId = 6, ApartmentName = "Sunflower", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 7, UserId = 7, ApartmentName = "Indraprastha", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 8, UserId = 8, ApartmentName = "Indraprastha", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 9, UserId = 9, ApartmentName = "Sunflower", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 10, UserId = 10, ApartmentName = "Swarna Residency", City = "Mysore" });
            _userAddress.Add(new UserAddressModel { Id = 11, UserId = 11, ApartmentName = "Indraprastha", City = "Bangalore" });
            _userAddress.Add(new UserAddressModel { Id = 12, UserId = 12, ApartmentName = "Sunflower", City = "Bangalore" });

            // employee data

            _employees.Add(new EmployeeModel { Id = 1, UserId = 1, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 50000 });
            _employees.Add(new EmployeeModel { Id = 2, UserId = 2, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 50000 });
            _employees.Add(new EmployeeModel { Id = 3, UserId = 3, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 80000 });
            _employees.Add(new EmployeeModel { Id = 4, UserId = 4, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 75000 });
            _employees.Add(new EmployeeModel { Id = 5, UserId = 5, CompanyName = "Vaporeo Technology Private Limited", OfficeLocation = "Mysore", Salary = 43000 });
            _employees.Add(new EmployeeModel { Id = 6, UserId = 6, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 35000 });
            _employees.Add(new EmployeeModel { Id = 7, UserId = 7, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 90000 });
            _employees.Add(new EmployeeModel { Id = 8, UserId = 8, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 12000 });
            _employees.Add(new EmployeeModel { Id = 9, UserId = 9, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 20000 });
            _employees.Add(new EmployeeModel { Id = 10, UserId = 10, CompanyName = "Vaporeo Technology Private Limited", OfficeLocation = "Mysore", Salary = 25000 });
            _employees.Add(new EmployeeModel { Id = 11, UserId = 11, CompanyName = "Inferno Technology Private Limited", OfficeLocation = "Bangalore", Salary = 60000 });
            _employees.Add(new EmployeeModel { Id = 12, UserId = 12, CompanyName = "Jolt Technology Private Limited", OfficeLocation = "Bangalore", Salary = 40000 });
        }

        public List<UserModel> GetUsers()
        {
            return _users;
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employees;
        }

        public UserModel AddUser(string FirstName, string LastName)
        {
            UserModel newUser = new() { FirstName = FirstName , LastName = LastName };
            newUser.Id = _users.Count() + 1;
            return newUser;
        }
    }
}
