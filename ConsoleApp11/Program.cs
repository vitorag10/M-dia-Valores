double[] valores = new double[5];
double soma = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}° valor: ");
    valores[i] = double.Parse(Console.ReadLine());
    soma += valores[i];
}

double media = soma / 5;
Console.WriteLine("A media é: " + media);
  