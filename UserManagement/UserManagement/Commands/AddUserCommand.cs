using MediatR;
using UserManagement.API.Models;

namespace UserManagement.Commands
{
    public class AddUserCommand : IRequest<UserModel>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
