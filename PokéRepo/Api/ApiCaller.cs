using Newtonsoft.Json;
using PokéRepo.Models;

namespace PokéRepo.Api
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();

            Client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                //hämta json, 
                string json = await response.Content.ReadAsStringAsync();

                //gör om json till objekt genom api modellen för root
                Root? result = JsonConvert.DeserializeObject<Root>(json);
                //returnera result

                if (result != null)
                {
                    return result;
                }
            }

            throw new HttpRequestException();
        }

    }
}
