using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Desafio7DOC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/1");
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(content);

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
        

    }



}
