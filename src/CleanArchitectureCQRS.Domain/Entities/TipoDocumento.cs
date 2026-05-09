using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities
{

    public partial class TipoDocumento : BaseEntity
    {
        

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;



        public virtual ICollection<ClienteDocumento> ClienteDocumentos { get; set; } = new List<ClienteDocumento>();


    }
}