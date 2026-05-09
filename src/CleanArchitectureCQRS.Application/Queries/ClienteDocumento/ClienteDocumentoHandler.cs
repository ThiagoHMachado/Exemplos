using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Queries;

public class ClienteDocumentoHandler : IRequestHandler<ClienteDocumentoQuery, ClienteDocumento>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteDocumento> _repo;

    public ClienteDocumentoHandler(ICleanArchitectureCQRSRepository<ClienteDocumento> repo)
    {
        _repo = repo;
    }

    public async Task<ClienteDocumento> Handle(ClienteDocumentoQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}