using fasWebMediatR.Domain.Entities;
using MediatR;

namespace fasWebMediatR.Users.Queries;

public class GetUserByIdQuery : IRequest<User>
{
    public int Id { get; set; }

    public GetUserByIdQuery(int id)
    {
        Id = id;
    }
}