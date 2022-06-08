// See https://aka.ms/new-console-template for more information
Console.WriteLine("--[M2S02] Ex 1 - Cálculo Salário Funcionário --");

string name = "Marcelo";
int birth = 1987;
int wage = 5280;
float readjustment = 0.07f;
float calc = (wage * readjustment) + wage;

Console.WriteLine($"Nome: {name}");
Console.WriteLine($"Ano de nascimento: {birth}");
Console.WriteLine($"Salário com reajuste de 7%: {calc}");

