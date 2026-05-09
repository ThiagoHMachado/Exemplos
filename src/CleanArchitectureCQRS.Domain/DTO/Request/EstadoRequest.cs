using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request
{

    public partial class EstadoRequest : BaseRequest
    {

        public int PaisId { get; set; }

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;


        public virtual ICollection<CidadeRequest> Cidades { get; set; } = new List<CidadeRequest>();

        public virtual PaiRequest Pais { get; set; } = null!;
    }
}