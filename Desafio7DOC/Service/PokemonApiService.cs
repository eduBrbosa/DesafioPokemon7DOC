using Desafio7DOC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desafio7DOC.Service
{
    public class PokemonApiService
    {
        public Stack<Pokemon> pokemonsBuscados = new Stack<Pokemon>();
        public Pokemon Pokemon { get; set; }
        public async Task BuscarPokemonNaApiAsync(string nomePokemonBuscar)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{nomePokemonBuscar.ToLower()}");
                    response.EnsureSuccessStatusCode();

                    var content = await response.Content.ReadAsStringAsync();

                    var pokemon = JsonSerializer.Deserialize<Pokemon>(content);

                    Pokemon pokemonAdicionar = new Pokemon(pokemon.Nome, pokemon.Altura, pokemon.Peso, pokemon.Habilidades);
                    
                    pokemonsBuscados.Push(pokemonAdicionar);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
