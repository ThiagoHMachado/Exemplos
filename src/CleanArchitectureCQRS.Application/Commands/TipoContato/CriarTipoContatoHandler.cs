using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public class CriarTipoContatoHandler : IRequestHandler<CriarTipoContatoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<TipoContato> _repo;
    private readonly IMapper mapper;

    public CriarTipoContatoHandler(ICleanArchitectureCQRSRepository<TipoContato> repo,IMapper mapper)
    {
        _repo = repo;
        this.mapper = mapper;
    }

    public async Task<int> Handle(CriarTipoContatoCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<TipoContato>(request.entity);
        await _repo.AddAsync(entity);
        return entity.Id;
    }
}