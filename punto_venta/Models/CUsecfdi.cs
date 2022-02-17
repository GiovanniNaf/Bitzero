using System;
using System.Collections.Generic;

#nullable disable

namespace punto_venta.Models
{
    public partial class CUsecfdi
    {
        public long IdUseCfdi { get; set; }
        public string FlduseCfdi { get; set; }
        public byte FldindividualPerson { get; set; }
        public byte FldbusinessPerson { get; set; }
        public string Fldkey { get; set; }
    }
}
