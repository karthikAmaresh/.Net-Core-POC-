using System.ComponentModel.DataAnnotations;

namespace UserManagement.API.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
