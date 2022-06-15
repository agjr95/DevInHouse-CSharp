namespace appBanco
{

  public enum MenuOpcoes
  {
    Saldo = 1,
    Deposito,
    Saque,
    Extrato,
    Sair
  }
  public static class Menu
  {

    public static MenuOpcoes ExibirMenu()
    {
      System.Console.WriteLine(" ----- MENU ----\n\n");
      ExibirOpcoesMenu();
      MenuOpcoes opcao = ObterOpcaoMenu();
      return opcao;
    }
    public static void ExibirOpcoesMenu()
    {
      foreach (int index in Enum.GetValues(typeof(MenuOpcoes)))
      {
        Console.WriteLine($" -> {index} - {Enum.GetName(typeof(MenuOpcoes), index)}\n");
      }
    }
    public static MenuOpcoes ObterOpcaoMenu()
    {
      System.Console.WriteLine(" -- Digite a opção desejada --\n");
      return (MenuOpcoes)int.Parse(Console.ReadLine());
    }

    public static bool ValidarOpcaoMenu(MenuOpcoes opcao)
    {
      if (opcao != MenuOpcoes.Saldo && opcao != MenuOpcoes.Saque && opcao != MenuOpcoes.Deposito && opcao != MenuOpcoes.Extrato && opcao != MenuOpcoes.Sair)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public static void VoltarParaMenu()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Tecle [ENTER] para voltar para o Menu");
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();
      Console.Clear();
    }
  }
}