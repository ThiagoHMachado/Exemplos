using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record ApagarTipoDocumentoCommand(TipoDocumento entity) : IRequest;