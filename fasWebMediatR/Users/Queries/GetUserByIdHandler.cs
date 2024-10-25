using fasWebMediatR.Domain.Entities;
using fasWebMediatR.Infrastructure.Repositories;
using MediatR;

namespace fasWebMediatR.Users.Queries;

public class GetUserByIdHandler(IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery, User>
{
    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return await userRepository.GetUserByIdAsync(request.Id);
    }
}