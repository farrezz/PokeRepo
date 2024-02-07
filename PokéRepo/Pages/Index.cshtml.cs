using Microsoft.AspNetCore.Mvc.RazorPages;
using PokéRepo.Api;
using PokéRepo.Models;

namespace PokéRepo.Pages
{
    public class IndexModel : PageModel
    {
        public Root Pokemons { get; set; }

        public async Task OnGet()
        {
            Pokemons = await new ApiCaller().MakeCall("charizard");

        }




    }
}
