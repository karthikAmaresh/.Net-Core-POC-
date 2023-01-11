using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.API.Models;
using UserManagement.API.Queries;
using UserManagement.Commands;

namespace UserManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<UserModel>> GetUsersList()
        {
            return await _mediator.Send(new GetUsersListQuery());
        }

        [HttpPost]
        public async Task<UserModel> AddUser([FromBody] AddUserCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
