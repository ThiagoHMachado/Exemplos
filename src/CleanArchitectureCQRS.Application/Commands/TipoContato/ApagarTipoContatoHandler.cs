using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public class ApagarTipoContatoHandler : IRequestHandler<ApagarTipoContatoCommand>
{
    private readonly ICleanArchitectureCQRSRepository<TipoContato> _repo;
    private readonly IMapper mapper;

    public ApagarTipoContatoHandler(ICleanArchitectureCQRSRepository<TipoContato> repo, IMapper mapper)
    {
        _repo = repo;
        this.mapper = mapper;
    }

    public async Task Handle(ApagarTipoContatoCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<TipoContato>(request.entity);
        _repo.DeleteAsync(entity);

    }
}