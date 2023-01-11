using MediatR;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Models;
using UserManagement.Queries;

namespace UserManagement.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Here's a small example of retrieving employeelist
        /// </summary>
        /// <returns>employees list</returns>
       
        [HttpGet]
        [Route("/Employee")]
        public async Task<List<EmployeeModel>> GetEmployeesList()
        {
            return await _mediator.Send(new GetEmployeesListQuery());
        }

        /// <summary>
        /// To retrieve employees within the salary Range
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("/Employee/SalaryRange")]
        public async Task<IActionResult> SortEmployeeList([FromQuery] SelectRangeQuery query)
        {  
            if(query.MaxSalary >= query.MinSalary)
            {
                var response = await _mediator.Send(query);
                return new OkObjectResult(response);
            }
            else
            {
                return new BadRequestObjectResult("Maximum salary should be greater than minimum salary");
            }
             
        }
    }
}
