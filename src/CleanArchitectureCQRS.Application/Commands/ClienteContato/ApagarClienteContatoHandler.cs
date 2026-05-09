using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarClienteContatoHandler : IRequestHandler<ApagarClienteContatoCommand>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteContato> _repo;

    public ApagarClienteContatoHandler(ICleanArchitectureCQRSRepository<ClienteContato> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarClienteContatoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}