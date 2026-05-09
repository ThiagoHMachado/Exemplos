using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request
{

    public partial class PaiRequest : BaseRequest
    {
        

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;


        public virtual ICollection<EstadoRequest> Estados { get; set; } = new List<EstadoRequest>();
    }
}