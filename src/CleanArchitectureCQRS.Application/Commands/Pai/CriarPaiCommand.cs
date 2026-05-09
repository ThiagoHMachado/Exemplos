using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

public record CriarPaiCommand(Pai entity) : IRequest<int>;