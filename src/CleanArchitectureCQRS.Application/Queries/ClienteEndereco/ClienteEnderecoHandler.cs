using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterClienteEnderecoHandler : IRequestHandler<ObterClienteEnderecoQuery, ClienteEndereco>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteEndereco> _repo;

    public ObterClienteEnderecoHandler(ICleanArchitectureCQRSRepository<ClienteEndereco> repo)
    {
        _repo = repo;
    }

    public async Task<ClienteEndereco> Handle(ObterClienteEnderecoQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}