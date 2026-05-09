using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarTipoDocumentoHandler : IRequestHandler<CriarTipoDocumentoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<TipoDocumento> _repo;

    public CriarTipoDocumentoHandler(ICleanArchitectureCQRSRepository<TipoDocumento> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarTipoDocumentoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}