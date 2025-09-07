matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]

print("\nMatriz ingresada:")
for fila in matriz:
    print(fila)

print("\nLectura vertical (todos en una sola línea):")
for columna in range(3):
    for fila in range(3):
        print(matriz[fila][columna], end=" ")
print()  # Nueva línea al final