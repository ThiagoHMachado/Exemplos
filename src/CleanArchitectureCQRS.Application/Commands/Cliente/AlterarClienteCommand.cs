using CleanArchitectureCQRS.Domain.DTO.Request;
using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record AlterarClienteCommand(ClienteRequest entity) : IRequest<int>;