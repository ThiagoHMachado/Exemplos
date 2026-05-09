using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.Entities {


public partial class ClienteContato : BaseEntity
    {
    


    public int ClienteId { get; set; }

    public int TipoContatoId { get; set; }

    public string Descricao { get; set; } = null!;

    public bool Principal { get; set; }

 
    public virtual Cliente Cliente { get; set; } = null!;



    public virtual TipoContato TipoContato { get; set; } = null!;
}

}