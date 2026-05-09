using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities
{

    public partial class Pai : BaseEntity
    {
        

        public string Codigo { get; set; } = null!;

        public string Descricao { get; set; } = null!;



        public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
    }
}