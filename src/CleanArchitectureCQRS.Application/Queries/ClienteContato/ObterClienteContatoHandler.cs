using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Application.Queries;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Queries;

public class ObterClienteContatoHandler : IRequestHandler<ObterClienteContatoQuery, ClienteContato>
{
    private readonly ICleanArchitectureCQRSRepository<ClienteContato> _repo;

    public ObterClienteContatoHandler(ICleanArchitectureCQRSRepository<ClienteContato> repo)
    {
        _repo = repo;
    }

    public async Task<ClienteContato> Handle(ObterClienteContatoQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetByIdAsync(request.Id);
    }
}