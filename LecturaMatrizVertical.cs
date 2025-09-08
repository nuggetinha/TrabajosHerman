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
            Console.Write("[");
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write(matriz[i, j]);
                if (j < matriz.GetLength(1) - 1) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        Console.WriteLine("\nLectura vertical (todos en una sola línea):");
        for (int columna = 0; columna < 3; columna++) {
            for (int fila = 0; fila < 3; fila++) {
                Console.Write(matriz[fila, columna] + " ");
            }
        }
        Console.WriteLine(); // Nueva línea al final
    }
}
