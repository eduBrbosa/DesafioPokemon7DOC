using Desafio7DOC.Controller;
using Desafio7DOC.Model;
using Desafio7DOC.Service;
using Desafio7DOC.Views;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio7DOC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Pokemon> pokemonsAdotads = new List<Pokemon>();
            PokeMenu menus = new PokeMenu();
            var servicos = new PokemonApiService();
            var controller = new PokemonTamagochiController();

            menus.MenuBoasVindas();

            menus.MenuInicial();

            do
            {
                switch (menus.EscolhaUsuario())
                {
                    case 1:
                        string nomePokemonBuscar = controller.BuscarPokemon();
                        await servicos.BuscarPokemonNaApiAsync(nomePokemonBuscar);

                        controller.ExibirInformacoesPokemon(servicos.pokemonsBuscados.Peek());

                        menus.ConfirmarAdocao();
                        switch (menus.EscolhaUsuario())
                        {
                            case 1:
                                controller.AdicionarPokemon(pokemonsAdotads, servicos.pokemonsBuscados.Peek());
                                Console.WriteLine("Pokémon adotado com sucesso!!");
                                servicos.pokemonsBuscados.Pop();
                                break;
                            case 2:
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }

                        break;

                    case 2:
                        foreach (var pokemon in pokemonsAdotads)
                            Console.WriteLine(pokemon.Nome);
                        break;
                }

            }while (menus.EscolhaUsuario() != 0);
        }
    }

}
