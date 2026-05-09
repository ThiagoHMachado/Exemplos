using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterEstadoHandler : IRequestHandler<ObterEstadoQuery, Estado>
{
    private readonly ICleanArchitectureCQRSRepository<Estado> _repo;

    public ObterEstadoHandler(ICleanArchitectureCQRSRepository<Estado> repo)
    {
        _repo = repo;
    }

    public async Task<Estado> Handle(ObterEstadoQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}