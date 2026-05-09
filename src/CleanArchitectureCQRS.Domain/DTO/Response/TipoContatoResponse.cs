using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{

    public partial class TipoContatoResponse : BaseResponse
    {
        

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;

  

        


    }
}