using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ASPEjercicio01.Services
{
    public class PredictML
    {
        public async Task<Output1> ConsumeMLS(InputDataMLS inputDataMLS)
        {
            using (var client = new HttpClient())
            {
                

                const string apiKey = "BEdWUb/Ix9/ucdFKXFg+BhQq2wg1xXJj//F0PJdWjB51Ljj2/fWrP+8Kjp/9uUnIAq+VIdvjWc4BA1wGjr4iLg=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/949a380cf2f84207ae5e92627b131799/services/6350e9b2689f44b0b473ad04a953b8f9/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client.PostAsJsonAsync("", inputDataMLS).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    OutputDataMLS outputDataMLS = JsonConvert.DeserializeObject<OutputDataMLS>(result);
                    return outputDataMLS.GetResponse();
                }
                else
                {
                    throw new HttpRequestException(string.Format("The request failed with status code: {0}", response.StatusCode));
                }
            }
        }
    }
}