/*
Desafío: Detectar e implementar una llamada de método

Objetivo:
Buscar e implementar correctamente un método de la clase System.Math
que permita obtener el mayor de dos números enteros.

Descripción:
Se declaran dos valores enteros y se utiliza el método Math.Max()
para determinar cuál es el mayor. El resultado se almacena en la
variable largerValue y se muestra en consola.

Conceptos practicados:
- Uso de la clase Math
- Asignación del valor devuelto de un método
- Consulta de documentación o IntelliSense
*/


int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
