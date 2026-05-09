using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{

    public partial class ClienteDocumentoResponse : BaseResponse
    {
        


        public int ClienteId { get; set; }

        public int TipoDocumentoId { get; set; }

        public string Numero { get; set; } = null!;

        public DateOnly Emissao { get; set; }

        public DateOnly? Validade { get; set; }



    }
}
