using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarPaiHandler : IRequestHandler<AlterarPaiCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Pai> _repo;

    public AlterarPaiHandler(ICleanArchitectureCQRSRepository<Pai> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarPaiCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}