using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

public record CriarTipoDocumentoCommand(TipoDocumento entity) : IRequest<int>;