using CleanArchitectureCQRS.Domain.DTO.Request;
using MediatR;

public record CriarTipoContatoCommand(TipoContatoRequest entity) : IRequest<int>;