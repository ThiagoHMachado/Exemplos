using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarEstadoHandler : IRequestHandler<AlterarEstadoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Estado> _repo;

    public AlterarEstadoHandler(ICleanArchitectureCQRSRepository<Estado> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarEstadoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}