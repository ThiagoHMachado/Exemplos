using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarClienteDocumentoHandler : IRequestHandler<ApagarClienteDocumentoCommand>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteDocumento> _repo;

    public ApagarClienteDocumentoHandler(ICleanArchitectureCQRSRepository<ClienteDocumento> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarClienteDocumentoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}