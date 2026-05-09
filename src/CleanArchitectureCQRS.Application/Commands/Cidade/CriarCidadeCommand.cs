using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record CriarCidadeCommand(Cidade entity) : IRequest<int>;