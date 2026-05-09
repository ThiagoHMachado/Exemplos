using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarClienteDocumentoHandler : IRequestHandler<CriarClienteDocumentoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteDocumento> _repo;

    public CriarClienteDocumentoHandler(ICleanArchitectureCQRSRepository<ClienteDocumento> repo)
    {
        _repo = repo;
    }

    public async Task<int> Handle(CriarClienteDocumentoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}