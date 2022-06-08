// See https://aka.ms/new-console-template for more information
Console.WriteLine("-- [M2S02] Ex 1 - Cálculo Salário Funcionário --");
string nome = "Marcelo";
int anoNascimento = 1987;
float salario = 5287.85f;
float reajuste = 7.8f;
float calc = ((salario * reajuste) / 100) + salario;

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Ano de nascimento: {anoNascimento}");
Console.WriteLine($"Salário com o reajuste: {calc}");




