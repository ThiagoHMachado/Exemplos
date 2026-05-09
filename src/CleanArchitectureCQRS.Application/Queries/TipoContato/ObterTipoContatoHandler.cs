using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.DTO.Response;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterTipoContatoHandler : IRequestHandler<ObterTipoContatoQuery, TipoContatoResponse>
{
    private readonly ICleanArchitectureCQRSRepository<TipoContato> _repo;
    private readonly IMapper mapper;

    public ObterTipoContatoHandler(ICleanArchitectureCQRSRepository<TipoContato> repo,IMapper mapper)
    {
        _repo = repo;
        this.mapper = mapper;
    }

    public async Task<TipoContatoResponse> Handle(ObterTipoContatoQuery request, CancellationToken cancellationToken)
    {
         var entity = await _repo.GetByIdAsync(request.Id);

        return mapper.Map<TipoContatoResponse>(entity);
    }
}