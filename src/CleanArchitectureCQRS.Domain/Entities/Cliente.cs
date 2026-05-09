using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities {



    public partial class Cliente : BaseEntity
    {
        public string Nome { get; set; } = null!;

        public DateOnly? DataNascimento { get; set; }

        public string? Observacao { get; set; }

        public bool ConsentimentoMarketing { get; set; }

        public bool ConsentimentoDados { get; set; }


        public virtual ICollection<ClienteContato> ClienteContatos { get; set; } = new List<ClienteContato>();

        public virtual ICollection<ClienteDocumento> ClienteDocumentos { get; set; } = new List<ClienteDocumento>();

        public virtual ICollection<ClienteEndereco> ClienteEnderecos { get; set; } = new List<ClienteEndereco>();

    }
}