using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarTipoDocumentoHandler : IRequestHandler<ApagarTipoDocumentoCommand>
{
    private readonly ICleanArchitectureCQRSRepository<TipoDocumento> _repo;

    public ApagarTipoDocumentoHandler(ICleanArchitectureCQRSRepository<TipoDocumento> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarTipoDocumentoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}