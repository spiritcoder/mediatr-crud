using fasWebMediatR.Infrastructure.Repositories;
using MediatR;

namespace fasWebMediatR.Users.Commands;

public class DeleteUserHandler(IUserRepository userRepository) : IRequestHandler<DeleteUserCommand, bool>
{
    public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        return await userRepository.DeleteUserAsync(request.Id);
    }
}