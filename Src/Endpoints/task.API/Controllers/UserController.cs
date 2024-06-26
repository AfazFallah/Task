using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Application.Models.User.Commands.CreateUser;
using Task.Application.Models.User.Commands.DeleteUser;
using Task.Application.Models.User.Commands.UpdateUser;
using Task.Application.Models.User.Queries.GetAllUser;
using Task.Application.Models.User.Queries.GetUserById;
using Task.Domain.User.Repositories;

namespace task.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        #region IUserRepository
        public readonly ISender _sender;

        public UserController(ISender sender)
        {
            _sender = sender;
        }

        #endregion

        [HttpPost("GetAllUser")]
        public async Task<IActionResult> GetAllUser(GetAllUserQuery query) 
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }
        [HttpPost("GetUserById")]
        public async Task<IActionResult> GetUserById(GetUserByIdQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(CreateUserCommand Command)
        {
            var result = await _sender.Send(Command);
            return Ok(result);
        }
        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand Command)
        {
            var result = await _sender.Send(Command);
            return Ok(result);
        }
        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> Delete(int id)
        {
           var result = await _sender.Send(new DeleteUserCommand { Id = id });
            return Ok(result);
        }
    }
}
