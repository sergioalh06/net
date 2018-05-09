using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEjercicio01.Services
{
    public class OutputDataMLS
    {
        public Output1List Results { get; set; }

        public Output1 GetResponse() => Results.output1.First();
    }
}