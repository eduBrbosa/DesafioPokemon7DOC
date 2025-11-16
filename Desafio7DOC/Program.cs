using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio7DOC
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Escolha o seu Pokémon");
            string pokemonEscolhido = Console.ReadLine();
            Console.Clear();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon/{pokemonEscolhido}");
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();

                    var pokemon = JsonSerializer.Deserialize<Pokemon>(content);

                    Console.WriteLine($"INFORMAÇÕES DE {pokemonEscolhido}");
                    Console.WriteLine($"Nome do Pokémon: {pokemon.Nome.ToUpper()}\n" +
                                      $"Altura: {pokemon.Altura}\n" +
                                      $"Peso: {pokemon.Peso}\n" +
                                      $"HABILIDADES:\n");

                    foreach (var habilidade in pokemon.Habilidades)
                    {
                        Console.WriteLine(habilidade.InfoHabilidade.NomeHabilidade.ToUpper());
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadLine();
        }
    }

    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("height")]
        public int Altura { get; set; }

        [JsonPropertyName("weight")]
        public int Peso { get; set; }

        [JsonPropertyName("abilities")]
        public List<HabilidadePokemon> Habilidades { get; set; }
    }

    public class HabilidadePokemon
    {
        [JsonPropertyName("ability")]
        public HabilidadeInfo InfoHabilidade { get; set; }
    }

    public class HabilidadeInfo
    {
        [JsonPropertyName("name")]
        public string NomeHabilidade { get; set; }
    }
}
