using System;

class BuscaLinear
{
    static void Main()
    {
        int[] numeros = { 5, 8, 12, 20, 3 };
        Console.Write("Digite o número a buscar: ");
        int busca = int.Parse(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == busca)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
            Console.WriteLine("Número encontrado.");
        else
            Console.WriteLine("Número não encontrado.");
    }
}
