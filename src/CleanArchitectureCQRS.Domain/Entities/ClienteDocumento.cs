using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities
{

    public partial class ClienteDocumento : BaseEntity
    {
        


        public int ClienteId { get; set; }

        public int TipoDocumentoId { get; set; }

        public string Numero { get; set; } = null!;

        public DateOnly Emissao { get; set; }

        public DateOnly? Validade { get; set; }


        public virtual Cliente Cliente { get; set; } = null!;



        public virtual TipoDocumento TipoDocumento { get; set; } = null!;
    }
}
