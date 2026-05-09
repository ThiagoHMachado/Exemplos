using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record ApagarClienteDocumentoCommand(ClienteDocumento entity) : IRequest;