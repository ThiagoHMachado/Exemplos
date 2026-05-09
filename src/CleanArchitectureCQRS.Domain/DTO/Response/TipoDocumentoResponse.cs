using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{

    public partial class TipoDocumentoResponse : BaseResponse
    {


        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;





    }
}