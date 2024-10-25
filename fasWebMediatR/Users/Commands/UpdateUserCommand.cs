using fasWebMediatR.Domain.Entities;
using MediatR;

namespace fasWebMediatR.Users.Commands;

public record UpdateUserCommand(int Id, string Name, string Email) : IRequest<User>;
public record UpdateUserDTO(string Name, string Email) : IRequest<User>;