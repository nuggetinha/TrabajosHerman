let matriz = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

console.log("\nMatriz ingresada:");
matriz.forEach(fila => {
    console.log(fila.join(" "));
});

console.log("\nLectura horizontal:");
matriz.forEach(fila => {
    fila.forEach(elemento => {
        process.stdout.write(elemento + " ");
    });
});
console.log(); // Nueva línea al final