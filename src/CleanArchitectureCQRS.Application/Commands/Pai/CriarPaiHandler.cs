using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarPaiHandler : IRequestHandler<CriarPaiCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Pai> _repo;

    public CriarPaiHandler(ICleanArchitectureCQRSRepository<Pai> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarPaiCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}