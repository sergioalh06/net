using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEjercicio01.Services
{
    public class Output1
    {
        public string age { get; set; }
        public string workclass { get; set; }
        public string fnlwgt { get; set; }
        public string education { get; set; }
        [JsonProperty("education.num")]
        public string educationum { get; set; }
        [JsonProperty("marital.status")]
        public string maritalstatus { get; set; }
        public string occupation { get; set; }
        public string relationship { get; set; }
        public string race { get; set; }
        public string sex { get; set; }
        [JsonProperty("capital.gain")]
        public string capitalgain { get; set; }
        [JsonProperty("capital.loss")]
        public string capitaloss { get; set; }
        [JsonProperty("hours.per.week")]
        public string hoursperweek { get; set; }
        [JsonProperty("native.country")]
        public string nativecountry { get; set; }
        public string income { get; set; }




        [JsonProperty("Scored Labels")]
        public string ScoredLabels { get; set; }
    }
}