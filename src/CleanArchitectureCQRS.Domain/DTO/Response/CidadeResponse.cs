
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{

    public partial class CidadeResponse : BaseResponse
    {


        public int EstadoId { get; set; }

        public string? Codigo { get; set; }

        public string Descricao { get; set; } = null!;

    




    }
}