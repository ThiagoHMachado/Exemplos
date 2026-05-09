using MediatR;
using CleanArchitectureCQRS.Domain.Entities;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.DTO.Response;
using AutoMapper;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterClienteHandler : IRequestHandler<ObterClienteQuery, ClienteResponse>
{
    private readonly ICleanArchitectureCQRSRepository<Cliente> _repo;
    private readonly IMapper mapper;

    public ObterClienteHandler(ICleanArchitectureCQRSRepository<Cliente> repo, IMapper mapper)
    {
        _repo = repo;
        this.mapper = mapper;
    }

    public async Task<ClienteResponse> Handle(ObterClienteQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByIdAsync(request.Id);

        return mapper.Map<ClienteResponse>(entity);
    }
}