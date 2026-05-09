using AutoMapper;
using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public class AlterarClienteHandler : IRequestHandler<AlterarClienteCommand, int>
{
    private readonly ICleanArchitectureCQRSRepository<Cliente> _repo;
    private readonly IMapper mapper;
    private readonly IRabbitService rabbitService;
    const string routeKey = "CleanArchitectureCQRS.eventsourcing.cliente.update";
    public AlterarClienteHandler(ICleanArchitectureCQRSRepository<Cliente> repo,IMapper mapper, IRabbitService rabbitService)
    {
        _repo = repo;
        this.mapper = mapper;
        this.rabbitService = rabbitService;
    }

    public async Task<int> Handle(AlterarClienteCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<Cliente>(request.entity);
        await rabbitService.PublishAsync<Cliente>(routeKey, entity);
        await _repo.UpdadeAsync(entity);
        return entity.Id;
    }
}