using CleanArchitectureCQRS.Domain.DTO.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureCQRS.Application.Events
{
    public class BaseEventCommand<T>
    {
        public record CriarCommand(T entity) : IRequest;
    }
}
