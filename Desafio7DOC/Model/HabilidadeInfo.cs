using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio7DOC.Model
{
    public class HabilidadeInfo
    {
        [JsonPropertyName("name")]
        public string NomeHabilidade { get; set; }
    }
}
