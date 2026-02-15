/*
Ejercicio: Valores devueltos y parámetros de los métodos

Objetivo:
Comprender cómo los métodos pueden devolver valores y cómo aceptar
parámetros en distintas sobrecargas.

Descripción:
Se prueban diferentes versiones (sobrecargas) del método Random.Next():
- Sin parámetros
- Con límite superior
- Con límite inferior y superior

Los valores generados se almacenan en variables y se muestran en consola.

Conceptos practicados:
- Valores devueltos
- Parámetros y argumentos
- Sobrecarga de métodos
- Uso de interpolación de cadenas
*/

Random dice = new Random();

int roll1 = dice.Next(); //Devuelve un número entre 0 y int.MaxValue
int roll2 = dice.Next(101); //Devuelve un número entre 0 y 100
int roll3 = dice.Next(50, 101); //Devuelve un número entre 50 y 100

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
