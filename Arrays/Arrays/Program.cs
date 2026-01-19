using System;

class ArraysCompletos
{
    static void Main()
    {
        // 1D Array 
        int[] array1D = { 1, -2, 3, 4, 5 };
        int somaImpares = 0;

        Console.WriteLine("Array 1D - Números positivos e soma dos ímpares:");

        for (int i = 0; i < array1D.Length; i++)
        {
            if (array1D[i] <= 0)
                continue; 

            Console.WriteLine(array1D[i]);

            if (array1D[i] % 2 != 0)
                somaImpares += array1D[i];
        }

        Console.WriteLine($"Soma dos ímpares positivos: {somaImpares}");
        Console.WriteLine();

        // 2D Array        
        int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine("Array 2D - Matriz original:");

        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write(array2D[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Alterando valor e mostrando
        array2D[0, 0] = 9;
        Console.WriteLine("\nArray 2D após alteração [0,0] = 9:");
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write(array2D[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // 3D Array 
        int[,,] array3D = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        Console.WriteLine("\nArray 3D - Percorrendo com break e continue:");

        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    // Pula valores pares
                    if (array3D[i, j, k] % 2 == 0)
                        continue;

                    Console.WriteLine($"Valor ímpar encontrado: {array3D[i, j, k]}");

                    // Para o loop se encontrar o valor 7
                    if (array3D[i, j, k] == 7)
                    {
                        Console.WriteLine("Valor 7 encontrado! Saindo do loop 3D...");
                        break; 
                    }
                }
            }
        }

        // Array 4D 
        int[,,,] array4D = {
            { { {1, 2}, {3, 4} }, { {5, 6}, {7, 8} } },
            { { {9, 10}, {11, 12} }, { {13, 14}, {15, 16} } }
        };

        Console.WriteLine("Array 4D - Percorrendo com break e continue:");

        for (int i = 0; i < array4D.GetLength(0); i++)
        {
            for (int j = 0; j < array4D.GetLength(1); j++)
            {
                for (int k = 0; k < array4D.GetLength(2); k++)
                {
                    for (int l = 0; l < array4D.GetLength(3); l++)
                    {
                        // Pula valores pares
                        if (array4D[i, j, k, l] % 2 == 0)
                            continue;

                        Console.WriteLine($"Valor ímpar encontrado: {array4D[i, j, k, l]}");

                        // Para o loop se encontrar o valor 15
                        if (array4D[i, j, k, l] == 15)
                        {
                            Console.WriteLine("Valor 15 encontrado! Saindo do loop 4D...");
                            break; 
                        }
                    }
                }
            }
        }

        Console.WriteLine("\nFim do programa.");
    }
}
