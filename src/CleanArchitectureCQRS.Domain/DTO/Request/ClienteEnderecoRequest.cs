using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request
{

    public partial class ClienteEnderecoRequest : BaseRequest
    {
        

     

        public int ClienteId { get; set; }

        public int CidadeId { get; set; }

        public string Logradouro { get; set; } = null!;

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Cep { get; set; }

        public bool Principal { get; set; }




    }

}