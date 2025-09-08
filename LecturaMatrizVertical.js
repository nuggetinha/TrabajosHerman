let matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

console.log("\nMatriz ingresada:");
matriz.forEach(fila => {
    console.log("[" + fila.join(", ") + "]");
});

console.log("\nLectura vertical (todos en una sola línea):");
for (let columna = 0; columna < 3; columna++) {
    for (let fila = 0; fila < 3; fila++) {
        process.stdout.write(matriz[fila][columna] + " ");
    }
}
console.log(); // Nueva línea al final
