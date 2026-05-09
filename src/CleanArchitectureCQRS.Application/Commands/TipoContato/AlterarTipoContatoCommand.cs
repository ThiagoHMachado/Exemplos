using CleanArchitectureCQRS.Domain.DTO.Request;

using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record AlterarTipoContatoCommand(TipoContatoRequest entity) : IRequest<int>;