using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarClienteContatoHandler : IRequestHandler<AlterarClienteContatoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteContato> _repo;

    public AlterarClienteContatoHandler(ICleanArchitectureCQRSRepository<ClienteContato> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarClienteContatoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}