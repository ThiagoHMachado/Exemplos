using MediatR;

using CleanArchitectureCQRS.Domain.DTO.Response;

namespace CleanArchitectureCQRS.Application.Queries;

public record ObterTipoContatoQuery(int Id) : IRequest<TipoContatoResponse>;