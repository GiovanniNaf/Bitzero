using System;
using System.Collections.Generic;

namespace punto_venta.Models.DTOS
{
    public class ReponseDTO
    {
        public bool IsSuccess { get; set; }

        public object Result { get; set; }

        public string DisplayMessage { get; set; }

        public List<string> ErrorMessage { get; set; }

    }
}
