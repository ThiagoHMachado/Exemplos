using CleanArchitectureCQRS.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Request {


public partial class ClienteContatoRequest : BaseRequest
    {    

  

    public int ClienteId { get; set; }

    public int TipoContatoId { get; set; }

    public string Descricao { get; set; } = null!;

    public bool Principal { get; set; }

}

}