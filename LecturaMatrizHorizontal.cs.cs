using System;

class Program {
    static void Main() {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("\nMatriz ingresada:");
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nLectura horizontal:");
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write(matriz[i, j] + " ");
            }
        }
        Console.WriteLine(); // Nueva línea al final
    }
}

