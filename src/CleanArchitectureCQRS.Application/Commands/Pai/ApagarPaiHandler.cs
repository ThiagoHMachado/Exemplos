using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarPaiHandler : IRequestHandler<ApagarPaiCommand>
{
    private readonly ICleanArchitectureCQRSRepository<Pai> _repo;

    public ApagarPaiHandler(ICleanArchitectureCQRSRepository<Pai> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarPaiCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}