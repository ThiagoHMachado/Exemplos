using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarClienteContatoHandler : IRequestHandler<CriarClienteContatoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteContato> _repo;

    public CriarClienteContatoHandler(ICleanArchitectureCQRSRepository<ClienteContato> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarClienteContatoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}