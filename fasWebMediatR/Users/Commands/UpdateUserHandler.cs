using fasWebMediatR.Domain.Entities;
using fasWebMediatR.Infrastructure.Repositories;
using MediatR;

namespace fasWebMediatR.Users.Commands;

public class UpdateUserHandler(IUserRepository userRepository): IRequestHandler<UpdateUserCommand, User>
{
    
    public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.GetUserByIdAsync(request.Id);
        
        if (user == null) return null;

        user.Name = request.Name;
        user.Email = request.Email;

        var updatedUser = await userRepository.UpdateUserAsync(user);
        return updatedUser;
    }

}