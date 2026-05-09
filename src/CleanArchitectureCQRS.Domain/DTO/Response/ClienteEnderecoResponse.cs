using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{

    public partial class ClienteEnderecoResponse : BaseResponse
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