using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record ApagarClienteEnderecoCommand(ClienteEndereco entity) : IRequest;