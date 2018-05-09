using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEjercicio01.Services
{
    public class InputDataMLS
    {
        public InputDataMLS(Input1 input1)
        {
            inputs = new Input1List(input1);
        }

        [JsonProperty("Inputs")]
        public Input1List inputs { get; }

        public Dictionary<string, string> GlobalParameters => new Dictionary<string, string>() { };

    }
}