using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record ApagarCidadeCommand(Cidade entity) : IRequest;