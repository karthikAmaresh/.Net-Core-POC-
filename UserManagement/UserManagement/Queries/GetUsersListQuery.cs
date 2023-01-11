using MediatR;
using UserManagement.API.Models;

namespace UserManagement.API.Queries
{
    public record GetUsersListQuery() : IRequest<List<UserModel>>;
}
