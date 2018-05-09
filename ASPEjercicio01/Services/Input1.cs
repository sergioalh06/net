using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPEjercicio01.Services
{
    // Esta clase representa el objeto Auto
    public class Input1 
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


        public Input1() {
            age = "1";
            workclass = "1";
            fnlwgt = "1";
            education = "1";
            educationum = "1";
            maritalstatus = "1";
            occupation = "1";
            relationship = "1";
            race = "1";
            sex = "1";
            capitalgain = "1";
            capitaloss = "1";
            hoursperweek = "1";
            nativecountry = "1";
            income = "1";
        }
    }
}