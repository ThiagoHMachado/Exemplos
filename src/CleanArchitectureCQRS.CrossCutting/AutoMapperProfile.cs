using AutoMapper;
using CleanArchitectureCQRS.Application.Commands;
using CleanArchitectureCQRS.Application.Events;
using CleanArchitectureCQRS.Application.Queries;
using CleanArchitectureCQRS.Domain.DTO.Request;
using CleanArchitectureCQRS.Domain.DTO.Response;
using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;



namespace CleanArchitectureCQRS.CrossCutting
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<ClienteContato, ClienteContatoRequest>().ReverseMap();
            CreateMap<ClienteContato, ClienteContatoResponse>().ReverseMap();
            CreateMap<ClienteDocumentoResponse, ClienteDocumento>().ReverseMap();
            CreateMap<ClienteDocumento, ClienteDocumentoRequest>().ReverseMap();
            CreateMap<ClienteEndereco, ClienteEnderecoRequest>().ReverseMap();
            CreateMap<ClienteEnderecoResponse, ClienteEndereco>().ReverseMap();
            CreateMap<Cliente, ClienteRequest>().ReverseMap();
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<CriarClienteCommand, ClienteRequest>().ReverseMap();
            CreateMap<ObterClienteQuery, ClienteResponse>().ReverseMap();
            CreateMap<Cidade, CidadeRequest>().ReverseMap();
            CreateMap<CidadeResponse, Cidade>().ReverseMap();

            CreateMap<CriarCidadeCommand, CidadeRequest>().ReverseMap();
            CreateMap<ObterCidadeQuery, CidadeResponse>().ReverseMap();

            CreateMap(typeof(CleanArchitectureCQRS.Application.Events.BaseEventCommand<>.CriarCommand), typeof(ClienteRequest)).ReverseMap();







        }
    }
}
