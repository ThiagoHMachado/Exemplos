using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarTipoDocumentoHandler : IRequestHandler<AlterarTipoDocumentoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<TipoDocumento> _repo;

    public AlterarTipoDocumentoHandler(ICleanArchitectureCQRSRepository<TipoDocumento> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(AlterarTipoDocumentoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}