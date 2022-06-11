namespace calculadora
{
  public class Operacoes
  {
    public double Calcular(int opcao, double num1, double num2)
    {
      double calc = 0;
      switch (opcao)
      {
        case (int)Menu.Adicao:
          calc = num1 + num2;
          break;
        case (int)Menu.Subtracao:
          calc = num1 - num2;
          break;
        case (int)Menu.Multiplicacao:
          calc = num1 * num2;
          break;
        case (int)Menu.Divisao:
          calc = num1 / num2;
          break;
      }

      return calc;
    }
  }
}