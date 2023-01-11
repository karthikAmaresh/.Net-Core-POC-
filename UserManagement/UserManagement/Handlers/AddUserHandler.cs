using MediatR;
using UserManagement.API.Data;
using UserManagement.API.Models;
using UserManagement.Commands;

namespace UserManagement.Handlers
{
    public class AddUserHandler : IRequestHandler<AddUserCommand ,UserModel>
    {
        private readonly IDataAccess _dataAccess;
        
        public AddUserHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<UserModel> Handle(AddUserCommand command , CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.AddUser(command.firstName, command.lastName));
        }
    }
}
