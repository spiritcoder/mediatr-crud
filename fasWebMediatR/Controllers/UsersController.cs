using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using fasWebMediatR.Domain.Entities;
using fasWebMediatR.Users.Commands;
using fasWebMediatR.Users.Queries;

namespace fasWebMediatR.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var query = new GetUserByIdQuery(id);
        var user = await mediator.Send(query);
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserCommand command)
    {
        var user = await mediator.Send(command);
        return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await mediator.Send(new GetAllUsersQuery());
        return Ok(users);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserDTO user)
    {
        var command = new UpdateUserCommand(id, user.Name, user.Email);
        var result = await mediator.Send(command);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var command = new DeleteUserCommand(id);
        var result = await mediator.Send(command);
        return Ok(result);
    }
}
