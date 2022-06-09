float[] notas = new float[6];
int notasZero = 0;
int notasMenorQueSete = 0;
int notasMaiorQueSete = 0;
for (int i = 0; i < notas.Length; i++)
{
  Console.Write($"Informe a nota do aluno {i + 1} : ");
  notas[i] = float.Parse(Console.ReadLine());
  if (notas[i] == 0)
  {
    notasZero++;
  }
  if (notas[i] > 0 && notas[i] < 7)
  {
    notasMenorQueSete++;

  }
  if (notas[i] >= 7)
  {
    notasMaiorQueSete++;
  }

}
float media = notas.Average();
Console.WriteLine($"A media dos alunos foi: {media}");
Console.WriteLine($"{notasZero} alunos tiraram 0");
Console.WriteLine($"{notasMenorQueSete} alunos tiraram a baixo de 7");
Console.WriteLine($"{notasMaiorQueSete} alunos tiraram acima de 7");

