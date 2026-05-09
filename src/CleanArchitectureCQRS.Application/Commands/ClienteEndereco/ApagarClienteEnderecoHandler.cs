using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarClienteEnderecoHandler : IRequestHandler<ApagarClienteEnderecoCommand>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteEndereco> _repo;

    public ApagarClienteEnderecoHandler(ICleanArchitectureCQRSRepository<ClienteEndereco> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarClienteEnderecoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}