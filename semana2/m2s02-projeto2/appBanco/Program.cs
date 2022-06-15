using appBanco;
Console.WriteLine("\n---- Bem vindo(a) ao DevInBank! -----\n\n");

ContaCorrente conta1 = new ContaCorrente();
conta1.saldo = 0;
Console.Clear();
MenuOpcoes opcaoEscolhida = Menu.ExibirMenu();
Console.Clear();
Console.WriteLine($"\n ---- Opção escolhida: {opcaoEscolhida} ----\n\n");

while (opcaoEscolhida != MenuOpcoes.Sair)
{
  bool validador = Menu.ValidarOpcaoMenu(opcaoEscolhida);
  if (validador == false)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n Desculpe, algo deu errado. A opção digitada é inválida!\n\n");
    Console.ForegroundColor = ConsoleColor.White;
    opcaoEscolhida = Menu.ExibirMenu();
    Console.Clear();
    Console.WriteLine($"\n ---- Opção escolhida: {opcaoEscolhida} ----\n\n");
  }
  if (validador == true)
  {
    switch (opcaoEscolhida)
    {
      case MenuOpcoes.Saldo:
        conta1.ConsultarSaldo();

        break;
      case MenuOpcoes.Deposito:
        conta1.Depositar();
        break;
      case MenuOpcoes.Saque:
        conta1.Sacar();
        break;
      case MenuOpcoes.Extrato:
        conta1.ConsultarExtrato();
        break;
      case MenuOpcoes.Sair:
        return;
    }
    opcaoEscolhida = Menu.ExibirMenu();
    Console.WriteLine($"\n Opção escolhida: {opcaoEscolhida}\n\n");
  }
}
Console.Clear();


