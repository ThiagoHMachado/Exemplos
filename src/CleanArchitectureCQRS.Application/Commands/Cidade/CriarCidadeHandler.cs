using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarCidadeHandler : IRequestHandler<CriarCidadeCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Cidade> _repo;

    public CriarCidadeHandler(ICleanArchitectureCQRSRepository<Cidade> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarCidadeCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}