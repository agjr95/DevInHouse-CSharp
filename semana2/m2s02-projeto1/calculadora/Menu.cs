namespace calculadora
{

  public enum Menu
  {

    Adicao = 1,
    Subtracao,
    Multiplicacao,
    Divisao,
    Sair

  }

  public class MostrarMenu
  {
    public static void Mostrar()
    {

      foreach (int i in Enum.GetValues(typeof(Menu)))
      {
        Console.WriteLine($"{i} - {Enum.GetName(typeof(Menu), i)}\n\n");
      }

    }
  }




}