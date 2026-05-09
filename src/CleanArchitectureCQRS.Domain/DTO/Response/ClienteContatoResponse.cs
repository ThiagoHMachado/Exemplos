using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response
{


public partial class ClienteContatoResponse : BaseResponse
    {
    



    public int ClienteId { get; set; }

    public int TipoContatoId { get; set; }

    public string Descricao { get; set; } = null!;

    public bool Principal { get; set; }


}

}