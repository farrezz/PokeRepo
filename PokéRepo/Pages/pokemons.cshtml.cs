using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokéRepo.Api;
using PokéRepo.Models;

namespace PokéRepo.Pages
{
    public class pokemonsModel : PageModel
    {
        public Root? Pokemon { get; set; }
        public string? PokemonName { get; set; }
        public Exception Message { get; set; }
        public async Task<IActionResult> OnGet(string name)
        {
            //sätter namnet som vi skickar med från index sidan till PokemonName i vår property som vi skapat i klassen. 
            PokemonName = name;
            //Här kör vi funktionen GetPokemons, som skapar en ny instans av ApiCaller()
            //och kör  MakeCall metoden, där vi skickar med vårt name, på pokemonen alltså
            await GetPokemon(name);
            return Page();
        }

        public async Task GetPokemon(string name)
        {
            try
            {
                //försöker hämta den pokemon som stämmer överens med namnet vi skickade med. alltså name
                //vi väntar på svaret (response) med await och sätter svaret till vår pokemon property, den propertien håller en Root, en pokemon då. 
                Pokemon = await new ApiCaller().MakeCall(name.ToLower());

            }
            catch (Exception ex)
            {
                Message = ex;
            }

        }

    }
}
