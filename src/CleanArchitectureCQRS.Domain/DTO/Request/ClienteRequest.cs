using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request {



    public  class ClienteRequest : BaseRequest
    {
        


        public string Nome { get; set; }

        public DateOnly? DataNascimento { get; set; }

        public string? Observacao { get; set; }

        public bool ConsentimentoMarketing { get; set; }

        public bool ConsentimentoDados { get; set; }


        //public virtual ICollection<ClienteContatoRequest> ClienteContatos { get; set; } = new List<ClienteContatoRequest>();

        //public virtual ICollection<ClienteDocumentoRequest> ClienteDocumentos { get; set; } = new List<ClienteDocumentoRequest>();

        //public virtual ICollection<ClienteEnderecoRequest> ClienteEnderecos { get; set; } = new List<ClienteEnderecoRequest>();

    }
}