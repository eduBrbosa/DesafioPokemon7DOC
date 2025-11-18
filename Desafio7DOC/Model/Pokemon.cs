using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio7DOC.Model
{
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

        public Pokemon(string nome, int altura, int peso, List<HabilidadePokemon> habilidades)
        {
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Habilidades = habilidades;
        }
    }
}
