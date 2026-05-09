using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarEstadoHandler : IRequestHandler<ApagarEstadoCommand>
{
    private readonly ICleanArchitectureCQRSRepository<Estado> _repo;

    public ApagarEstadoHandler(ICleanArchitectureCQRSRepository<Estado> repo)
    {
        _repo = repo;
    }

    public async Task Handle(ApagarEstadoCommand request, CancellationToken cancellationToken)
    {
        var entity = request.entity;
        _repo.DeleteAsync(entity);

    }
}