using System.ComponentModel.DataAnnotations;

namespace UserManagement.Models
{
    public class UserAddressModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public string ApartmentName { get; set; }
        public string City { get; set; }

    }
}
