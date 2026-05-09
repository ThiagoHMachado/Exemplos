using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarCidadeHandler : IRequestHandler<AlterarCidadeCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Cidade> _repo;

    public AlterarCidadeHandler(ICleanArchitectureCQRSRepository<Cidade> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarCidadeCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}