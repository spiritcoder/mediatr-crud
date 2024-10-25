using fasWebMediatR.Domain.Entities;
using fasWebMediatR.Infrastructure.Repositories;
using MediatR;

namespace fasWebMediatR.Users.Queries;

public class GetAllUsersHandler(IUserRepository userRepository): IRequestHandler<GetAllUsersQuery, User[]>
{
    public async Task<User[]> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await userRepository.GetAllUsersAsync();
    }
}