using System;

class OrdenacaoBasica
{
    static void Main()
    {
        int[] numeros = { 5, 2, 8, 1, 3 };

        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] > numeros[j])
                {
                    int temp = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = temp;
                }
            }
        }

        Console.WriteLine("Vetor ordenado:");
        foreach (int n in numeros)
            Console.Write(n + " ");
    }
}
