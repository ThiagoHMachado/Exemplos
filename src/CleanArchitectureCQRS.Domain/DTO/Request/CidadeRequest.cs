
using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request {

    public partial class CidadeRequest : BaseRequest
    {
  

        public int EstadoId { get; set; }

        public string? Codigo { get; set; }

        public string Descricao { get; set; } = null!;

 
        public virtual EstadoRequest Estado { get; set; } = null!;


    }
}