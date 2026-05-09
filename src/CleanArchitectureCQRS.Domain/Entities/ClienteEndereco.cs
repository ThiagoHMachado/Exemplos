using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities
{

    public partial class ClienteEndereco : BaseEntity
    {
        



        public int ClienteId { get; set; }

        public int CidadeId { get; set; }

        public string Logradouro { get; set; } = null!;

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Cep { get; set; }

        public bool Principal { get; set; }


        public virtual Cidade Cidade { get; set; } = null!;

        public virtual Cliente Cliente { get; set; } = null!;


    }

}