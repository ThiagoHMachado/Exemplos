using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterPaisHandler : IRequestHandler<ObterPaisQuery, Pai>
{
    private readonly ICleanArchitectureCQRSRepository<Pai> _repo;

    public ObterPaisHandler(ICleanArchitectureCQRSRepository<Pai> repo)
    {
        _repo = repo;
    }

    public async Task<Pai> Handle(ObterPaisQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}