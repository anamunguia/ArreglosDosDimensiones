using System;
public class ArreglosDosDimensiones
{
    public static void Main()
    {
        int i, j, n;
        int[,] primerBloque = new int[50, 50];
        int[,] segundoBloque = new int[50, 50];
        int[,] sumaDeBloques = new int[50, 50];

        Console.Write("\n\nSUMA DE DOS MATRICES\n");
        Console.Write("-----------------------------------------\n");
        Console.Write("Ingresa el número de elementos que contendra la matriz, deben ser menos de 5: ");
        n = Convert.ToInt32(Console.ReadLine());

        //ingresaar valores a la matriz
        Console.Write("Ingresa los elementos de la primera matriz :\n");

        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("Números - [{0},{1}] : ", i, j);
                primerBloque[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.Write("Ingresa los elementos de la segunda matriz :\n");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                Console.Write("Números - [{0},{1}] : ", i, j);
                segundoBloque[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("\nEl primer bloque es :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < n; j++)
                Console.Write("{0}\t", primerBloque[i, j]);
        }

        Console.Write("\nEl segundo bloque es :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < n; j++)
                Console.Write("{0}\t", segundoBloque[i, j]);
        }
       //for para calcular la suma de las matrices
        for (i = 0; i < n; i++)
            for (j = 0; j < n; j++)
                sumaDeBloques[i, j] = primerBloque[i, j] + segundoBloque[i, j];
        Console.Write("\nLa suma de la matriz es : \n");
        for (i = 0; i < n; i++)
        {
            Console.Write("\n");
            for (j = 0; j < n; j++)
                Console.Write("{0}\t", sumaDeBloques[i, j]);
        }
        Console.Write("\n\n");
    }
}