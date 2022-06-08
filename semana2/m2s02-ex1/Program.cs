// See https://aka.ms/new-console-template for more information
Console.WriteLine("--[M2S02] Ex 1 - Cálculo Salário Funcionário --");

Console.WriteLine("Digite o nome do funcionário");
var name = Convert.ToString(Console.ReadLine());

Console.WriteLine("Digite o ano em que você nasceu");
var birth = Convert.ToInt32(Console.ReadLine());
int year = 2022;
int age = year - birth;

Console.WriteLine("Digite o seu salário");
var wage = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a porcentagem do reajuste");
decimal readjustment = Convert.ToDecimal(Console.ReadLine());

decimal calc = ((wage * readjustment / 100)) + wage;

Console.WriteLine($"Nome do funcionário: {name}");
Console.WriteLine($"Idade do funcionário: {age}");
Console.WriteLine($"Salário com reajuste de {readjustment}%: R$ {calc}");

