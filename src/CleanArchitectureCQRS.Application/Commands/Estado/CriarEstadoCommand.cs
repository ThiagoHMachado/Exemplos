using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record CriarEstadoCommand(Estado entity) : IRequest<int>;