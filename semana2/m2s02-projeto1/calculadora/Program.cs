using System;
namespace calculadora
{

  internal class Program
  {

    static void Main(string[] args)
    {
      Console.Write("\n\n ---- Menu Calculadora ----\n\n");

      foreach (int i in Enum.GetValues(typeof(OpcoesMenu)))
      {
        Console.WriteLine($"{i} - {Enum.GetName(typeof(OpcoesMenu), i)}\n\n");
      }
      Console.Write("Tecle o número correspondente a ação desejada\n");
      OpcoesMenu opcao = (OpcoesMenu)int.Parse(Console.ReadLine());
      Console.WriteLine($"Opção escolhida: {opcao}");
    }
  }
}


