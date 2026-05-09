using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarCidadeHandler : IRequestHandler<ApagarCidadeCommand>
{
    private readonly ICleanArchitectureCQRSRepository<Cidade> _repo;

    public ApagarCidadeHandler(ICleanArchitectureCQRSRepository<Cidade> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarCidadeCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}