using fasWebMediatR.Domain.Entities;
using MediatR;

namespace fasWebMediatR.Users.Commands;

public class CreateUserCommand : IRequest<User>
{
    public string Name { get; set; }
    public string Email { get; set; }
}
