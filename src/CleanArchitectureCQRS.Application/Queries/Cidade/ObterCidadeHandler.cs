using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.DTO.Response;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;


namespace CleanArchitectureCQRS.Application.Queries;

public class ObterCidadeHandler : IRequestHandler<ObterCidadeQuery, CidadeResponse>
{
    private readonly ICleanArchitectureCQRSRepository<Cidade> _repo;
    private readonly IMapper mapper;

    public ObterCidadeHandler(ICleanArchitectureCQRSRepository<Cidade> repo, IMapper mapper)
    {
        _repo = repo;
        this.mapper = mapper;
    }

    public async Task<CidadeResponse> Handle(ObterCidadeQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByIdAsync(request.Id);
        return mapper.Map<CidadeResponse>(entity);
    }
}