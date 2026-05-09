using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.DTO.Request;
using CleanArchitectureCQRS.Domain.DTO.Response;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarTipoContatoHandler : IRequestHandler<AlterarTipoContatoCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<TipoContato> _repo;
    private readonly IMapper mapper;

    public AlterarTipoContatoHandler(ICleanArchitectureCQRSRepository<TipoContato> repo, IMapper mapper)
    {
        _repo = repo;
        this.mapper = mapper;
    }

    public async Task<int> Handle(AlterarTipoContatoCommand request, CancellationToken cancellationToken)
    {

        var entity = mapper.Map<TipoContato>(request.entity);
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}