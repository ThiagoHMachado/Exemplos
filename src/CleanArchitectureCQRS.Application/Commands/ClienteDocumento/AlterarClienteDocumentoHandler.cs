using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarClienteDocumentoHandler : IRequestHandler<AlterarClienteDocumentoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteDocumento> _repo;

    public AlterarClienteDocumentoHandler(ICleanArchitectureCQRSRepository<ClienteDocumento> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarClienteDocumentoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}