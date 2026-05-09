using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarEstadoHandler : IRequestHandler<CriarEstadoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Estado> _repo;

    public CriarEstadoHandler(ICleanArchitectureCQRSRepository<Estado> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarEstadoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}