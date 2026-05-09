using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities
{

    public partial class Estado : BaseEntity
    {
        

        public int PaisId { get; set; }

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;



        public virtual ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();

        public virtual Pai Pais { get; set; } = null!;
    }
}