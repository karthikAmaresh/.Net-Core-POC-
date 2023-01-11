using MediatR;
using UserManagement.API.Data;
using UserManagement.API.Models;
using UserManagement.API.Queries;

namespace UserManagement.API.Handlers
{
    public class GetUsersListHandler : IRequestHandler<GetUsersListQuery,List<UserModel>>
    {
        private readonly IDataAccess _dataAccess;
        public GetUsersListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<UserModel>> Handle(GetUsersListQuery query, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetUsers());
        }
    }
}
