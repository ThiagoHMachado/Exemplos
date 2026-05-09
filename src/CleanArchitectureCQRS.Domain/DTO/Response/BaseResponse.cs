using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureCQRS.Domain.DTO.Response {

    public class BaseResponse {
        public int Id { get; set; }
        public bool Ativo { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? Tenantid { get; set; }

    }
}
