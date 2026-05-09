using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarClienteEnderecoHandler : IRequestHandler<AlterarClienteEnderecoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteEndereco> _repo;

    public AlterarClienteEnderecoHandler(ICleanArchitectureCQRSRepository<ClienteEndereco> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarClienteEnderecoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}