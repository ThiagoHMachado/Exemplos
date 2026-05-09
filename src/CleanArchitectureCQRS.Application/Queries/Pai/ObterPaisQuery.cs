using MediatR;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Queries
{

    public record ObterPaisQuery(int Id) : IRequest<Pai>;
}