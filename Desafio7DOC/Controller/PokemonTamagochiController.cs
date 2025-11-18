using Desafio7DOC.Model;
using Desafio7DOC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7DOC.Controller
{
    public class PokemonTamagochiController
    {
        public string BuscarPokemon()
        {
            Console.Clear();
            Console.WriteLine("DIGÍTE O NOME DO POKEMON QUE DESEJA PESQUISAR: ");
            string nomePokemonBuscar = Console.ReadLine();

            return nomePokemonBuscar;
        }

        public void AdicionarPokemon(List<Pokemon> listaPokemonsAdicionar, Pokemon pokemon)
        {
            Pokemon pokemonAdicionar = new Pokemon(pokemon.Nome, pokemon.Altura, pokemon.Peso, pokemon.Habilidades);
            listaPokemonsAdicionar.Add(pokemonAdicionar);
        }

        public void ExibirInformacoesPokemon(Pokemon pokemonBuscaResultado)
        {
            Console.WriteLine($"Nome do Pokémon: {pokemonBuscaResultado.Nome.ToUpper()}\n" +
                                              $"Altura: {pokemonBuscaResultado.Altura}\n" +
                                              $"Peso: {pokemonBuscaResultado.Peso}\n" +
                                              $"HABILIDADES:");
            foreach (var habilidade in pokemonBuscaResultado.Habilidades)
            {
                Console.WriteLine(habilidade.InfoHabilidade.NomeHabilidade.ToUpper());
            }
        }
    }
}
