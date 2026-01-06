using System;

class MediaNumeros
{
    static void Main()
    {
        Console.Write("Quantos números deseja informar? ");
        int n = int.Parse(Console.ReadLine());

        double soma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            double numero = double.Parse(Console.ReadLine());
            soma += numero;
        }

        double media = soma / n;
        Console.WriteLine($"Média dos números: {media}");
    }
}
