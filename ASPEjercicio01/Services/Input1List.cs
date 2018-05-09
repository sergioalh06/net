using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEjercicio01.Services
{
    public class Input1List
    {
        [JsonProperty("input1")]
        public IList<Input1> _input1 { get; }

        public Input1List(Input1 input1)
        {
            _input1 = new List<Input1>() { input1 };
        }
    }
}