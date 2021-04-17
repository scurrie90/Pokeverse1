using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokeVerse.Data;
using PokeVerse.Models;
using PokeVerse.ViewModels;

namespace PokeVerse.Pages.Pokedex
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PokeVerseDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexModel(PokeVerseDbContext db, UserManager<IdentityUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public Models.Pokedex TrainerPokedex { get; set; }

        public PokedexPokemon PokedexPokemon { get; set; }



        public async Task OnGetAsync()
        {
            System.Threading.Thread.Sleep(2000);



            //Finds Id of Trainer logged in

            string userId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

            //Finds Pokedex of Trainer logged in, assign to TrainerPokedex
            await Task.Run(() => TrainerPokedex = _db.PokeDex
                .Include(pp => pp.PokedexPokemons)
                .ThenInclude(p => p.Pokemon)
                .Where(pp => pp.TrainerId == userId)
            .FirstOrDefault());



            //PokedexPokemon = await _db.PokedexPokemon
            //    .Include(c => c.Pokedex).ToListAsync();
            ///*.ThenInclude(c => c.Id)*/
            ///

            //_db.PokedexPokemon.Update(PokedexPokemon);
            //_db.SaveChanges();


        }

        public async Task<IActionResult> OnPostAsync(PokemonVM testPokemon)
        {
            //Finds Id of Trainer logged in

            string userId = _userManager.FindByNameAsync(User.Identity.Name).Result.Id;

         

            //Finds Pokedex of Trainer logged in, assign to TrainerPokedex
            TrainerPokedex = _db.PokeDex
                .Include(pp => pp.PokedexPokemons)
                .ThenInclude(p => p.Pokemon)
                .Where(pp => pp.TrainerId == userId)
            .FirstOrDefault();

            //Check if pokemon is in the pokedex
            //If not, Adds pokemon to TrainerPokedex  

            try
            {
                PokedexPokemon p = new PokedexPokemon(TrainerPokedex.Id, testPokemon.Id);
                TrainerPokedex.PokedexPokemons.Add(p);
                await _db.SaveChangesAsync();
                p.Pokemon = new Pokemon(testPokemon.PokeNumber, testPokemon.Name, testPokemon.Type0, testPokemon.Type1, testPokemon.Attack, testPokemon.Defense, testPokemon.Speed);
                //Response.Redirect("Pokedex/Index", false);
            }
            catch
            {
                Console.Write("Pokemon has already been added");

            }
            
            return RedirectToPage("/Pokedex/index");


        }


        public async Task<IActionResult> OnPostDeleteAsync(PokedexPokemon pokemon)
        {
            
            //TrainerPokedex.PokedexPokemons.Remove(pokemon);
           

           
                _db.PokedexPokemon.Remove(pokemon);
                
            
            await _db.SaveChangesAsync();
            return RedirectToPage();
        }
    }
}
