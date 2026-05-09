using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request
{

    public partial class ClienteDocumentoRequest : BaseRequest
    {
        

 

        public int ClienteId { get; set; }

        public int TipoDocumentoId { get; set; }

        public string Numero { get; set; } = null!;

        public DateOnly Emissao { get; set; }

        public DateOnly? Validade { get; set; }




    }
}
