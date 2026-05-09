using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities
{

    public partial class TipoContato : BaseEntity
    {
        

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;

  
        public virtual ICollection<ClienteContato> ClienteContatos { get; set; } = new List<ClienteContato>();


    }
}