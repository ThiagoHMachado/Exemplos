using CleanArchitectureCQRS.Domain.Entities;
using MediatR;

namespace CleanArchitectureCQRS.Application.Commands;

public record CriarClienteEnderecoCommand(ClienteEndereco entity) : IRequest<int>;