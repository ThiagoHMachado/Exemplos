using System;
using System.Collections.Generic;

namespace CleanArchitectureCQRS.Domain.DTO.Response {



    public partial class ClienteResponse : BaseResponse
    {
        



        public string Nome { get; set; } = null!;

        public DateOnly? DataNascimento { get; set; }

        public string? Observacao { get; set; }

        public bool ConsentimentoMarketing { get; set; }

        public bool ConsentimentoDados { get; set; }

    }
}