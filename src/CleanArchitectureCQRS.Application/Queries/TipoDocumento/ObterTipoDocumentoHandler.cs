using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterTipoDocumentoHandler : IRequestHandler<ObterTipoDocumentoQuery, TipoDocumento>
{
    private readonly ICleanArchitectureCQRSRepository<TipoDocumento> _repo;

    public ObterTipoDocumentoHandler(ICleanArchitectureCQRSRepository<TipoDocumento> repo)
    {
        _repo = repo;
    }

    public async Task<TipoDocumento> Handle(ObterTipoDocumentoQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}