using MediatR;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Queries;

public record ClienteDocumentoQuery(int Id) : IRequest<ClienteDocumento>;