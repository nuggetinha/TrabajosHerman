public class LecturaMatrizVertical {
    public static void main(String[] args) {
        int[][] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        System.out.println("\nMatriz ingresada:");
        for (int[] fila : matriz) {
            System.out.print("[");
            for (int j = 0; j < fila.length; j++) {
                System.out.print(fila[j]);
                if (j < fila.length - 1) System.out.print(", ");
            }
            System.out.println("]");
        }

        System.out.println("\nLectura vertical (todos en una sola línea):");
        for (int columna = 0; columna < 3; columna++) {
            for (int fila = 0; fila < 3; fila++) {
                System.out.print(matriz[fila][columna] + " ");
            }
        }
        System.out.println(); // Nueva línea al final
    }
}