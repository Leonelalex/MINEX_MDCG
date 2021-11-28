using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgFormatoBc
    {
        public int Codigo { get; set; }
        public byte[] Encabezado { get; set; }
        public byte[] Pie { get; set; }
    }
}
