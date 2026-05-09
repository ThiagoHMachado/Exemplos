using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{

    public partial class EstadoRespose : BaseResponse
    {
        

        public int PaisId { get; set; }

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;

  
    }
}