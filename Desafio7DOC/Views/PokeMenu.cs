using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7DOC.Views
{
    public class PokeMenu
    {
        string nomeUsuario;
        public int EscolhaUsuario()
        {
            int escolha;
            while(!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 3)
            {
                Console.WriteLine("Opção escolhida inválida!");
            }
            return escolha;
        }
        public void MenuBoasVindas()
        {
            Console.WriteLine("\n=================");
            Console.WriteLine("Boas vindas ao programa!\n" +
                              "Insira o seu nome: ");
            nomeUsuario = Console.ReadLine();
        }

        public void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("\n=================");
            Console.WriteLine($"{nomeUsuario}, o que você gostaria de fazer?\n" +
                              "1. Adotar um Pokémon\n" +
                              "2. Listar seus Pokémons adotados\n" +
                              "0. Sair");
        }

        public void ConfirmarAdocao()
        {
            Console.WriteLine($"Você deseja adotar esse pokémon??\n" +
                              $"1. Sim\n" +
                              $"2. Não");
        }
    }
}
