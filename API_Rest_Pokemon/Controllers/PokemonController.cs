using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API_Rest_Pokemon.Models;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace API_Rest_Pokemon.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        private static int codigo = 0;
        private static List<Pokemon> listaPokemon = new List<Pokemon>();

        [HttpPost]
        public void CadastrarPokemon([FromBody] Pokemon pokemon)
        {
            codigo++;
            pokemon.Codigo = codigo;
            listaPokemon.Add(pokemon);
            Console.WriteLine($"[POKÉMON CADASTRADO COM SUCESSO]\n\nCódigo: {pokemon.Codigo}\nNome: {pokemon.Nome}\nTipo: {pokemon.Tipo}\n");
        }

        [HttpDelete("{codigo}")]
        public IActionResult RemoverPokemon(int codigo)
        {
            foreach (Pokemon pokemon in listaPokemon)
            {
                if (pokemon.Codigo == codigo)
                {
                    listaPokemon.Remove(pokemon);
                    Console.WriteLine($"[POKÉMON REMOVIDO COM SUCESSO]\n\nCódigo: {pokemon.Codigo}\nNome: {pokemon.Nome}\nTipo: {pokemon.Tipo}\n");
                    return Ok(pokemon);
                }
            }
            return NotFound();
        }

        [HttpGet]
        public IEnumerable<Pokemon> VisualizarListaDePokemon()
        {
            Console.WriteLine("[EXIBINDO LISTA DE POKÉMON]\n");
            return listaPokemon;
        }
    }
}