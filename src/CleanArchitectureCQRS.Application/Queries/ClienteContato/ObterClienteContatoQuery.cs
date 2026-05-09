using MediatR;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Queries
{

    public record ObterClienteContatoQuery(int Id) : IRequest<ClienteContato>;
}