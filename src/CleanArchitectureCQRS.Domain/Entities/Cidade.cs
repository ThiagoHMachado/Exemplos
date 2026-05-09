
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities {

    public partial class Cidade : BaseEntity
    {

        public int EstadoId { get; set; }

        public string? Codigo { get; set; }

        public string Descricao { get; set; } = null!;

  
        public virtual ICollection<ClienteEndereco> ClienteEnderecos { get; set; } = new List<ClienteEndereco>();

        public virtual Estado Estado { get; set; } = null!;


    }
}