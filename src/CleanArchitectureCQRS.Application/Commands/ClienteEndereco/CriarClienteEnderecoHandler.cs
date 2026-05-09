using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarClienteEnderecoHandler : IRequestHandler<CriarClienteEnderecoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteEndereco> _repo;

    public CriarClienteEnderecoHandler(ICleanArchitectureCQRSRepository<ClienteEndereco> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarClienteEnderecoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}