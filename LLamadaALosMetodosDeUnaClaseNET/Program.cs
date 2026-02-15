/*
Ejercicio: Llamada a métodos de una clase .NET

Objetivo:
Aprender a invocar métodos de la biblioteca de clases .NET diferenciando
entre métodos estáticos (sin estado) y métodos de instancia (con estado).

Descripción:
Se crea una instancia de la clase Random para generar un número entero
aleatorio entre 1 y 6 mediante el método Next().
Posteriormente, se utiliza el método estático Console.WriteLine()
para mostrar el resultado en la consola.

Conceptos practicados:
- Creación de objetos con el operador new
- Métodos de instancia vs métodos estáticos
- Invocación de métodos
*/

Random dice = new Random();
int roll = dice.Next(1, 7); //Genera un número entre 1 y 6 (el 7 no se incluye).
Console.WriteLine(roll);
