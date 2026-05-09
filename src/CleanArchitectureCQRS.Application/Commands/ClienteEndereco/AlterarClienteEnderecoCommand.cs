using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record AlterarClienteEnderecoCommand(ClienteEndereco entity) : IRequest<int>;