using fasWebMediatR.Domain.Entities;
using fasWebMediatR.Infrastructure.Repositories;
using MediatR;

namespace fasWebMediatR.Users.Commands;

public class CreateUserHandler(IUserRepository userRepository) : IRequestHandler<CreateUserCommand, User>
{
    public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var newUser = new User { Name = request.Name, Email = request.Email };
        await userRepository.AddUserAsync(newUser);
        return newUser;
    }
}
