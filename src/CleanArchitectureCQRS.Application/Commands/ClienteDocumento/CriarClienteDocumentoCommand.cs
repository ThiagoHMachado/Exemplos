using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record CriarClienteDocumentoCommand(ClienteDocumento entity) : IRequest<int>;