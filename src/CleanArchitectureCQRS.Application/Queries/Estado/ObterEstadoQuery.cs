using MediatR;
using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Queries;

public record ObterEstadoQuery(int Id) : IRequest<Estado>;