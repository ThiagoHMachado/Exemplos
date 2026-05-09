using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request
{

    public partial class TipoContatoRequest : BaseRequest
    {
        

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;

        


    }
}