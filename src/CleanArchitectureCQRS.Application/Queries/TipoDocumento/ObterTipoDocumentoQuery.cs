using MediatR;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Queries
{
    public record ObterTipoDocumentoQuery(int Id) : IRequest<TipoDocumento>;
}