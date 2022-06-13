namespace appBanco
{
  public class ContaCorrente
  {
    string titular;
    string conta;
    internal double saldo;


    public void ConsultarSaldo()
    {
      if (this.saldo == 0)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
      }
      if (this.saldo > 0)
      {
        Console.ForegroundColor = ConsoleColor.Green;
      }
      if (this.saldo < 0)
      {
        Console.ForegroundColor = ConsoleColor.Red;
      }
      Console.WriteLine($"O saldo da conta é de R$ {this.saldo}\n\n");
      Console.ForegroundColor = ConsoleColor.White;
    }

    public double Depositar()
    {
      Console.WriteLine("Digite o valor que deseja depositar\n");
      double valor = Double.Parse(Console.ReadLine());
      if (valor <= 0)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n Valor inválido\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite o valor que deseja depositar\n");
        valor = Double.Parse(Console.ReadLine());

      }
      if (valor > 0)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n O valor de R$ {valor} foi depositado com sucesso!\n\n\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        this.saldo += valor;
      }
      return this.saldo;
    }
    public double Sacar()
    {
      Console.WriteLine("Digite o valor que deseja sacar\n");
      double valor = Double.Parse(Console.ReadLine());
      if (valor > this.saldo)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n O valor ultrapassou o saldo!\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite o valor que deseja sacar\n");
        valor = Double.Parse(Console.ReadLine());
      }
      if (valor <= this.saldo)
      {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n O valor de R$ {valor} foi sacado com sucesso!\n\n\n\n");
        Console.ForegroundColor = ConsoleColor.White;
        this.saldo -= valor;
      }

      return this.saldo;
    }
  }

}