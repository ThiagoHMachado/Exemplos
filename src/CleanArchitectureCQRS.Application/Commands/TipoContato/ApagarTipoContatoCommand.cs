using CleanArchitectureCQRS.Domain.DTO.Request;

using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record ApagarTipoContatoCommand(TipoContatoRequest entity) : IRequest;