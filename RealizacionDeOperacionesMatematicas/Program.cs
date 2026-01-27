/*<------Realización de operaciones matemáticas básicas------>*/
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Suma: " + sum);
Console.WriteLine("Resta: " + difference);
Console.WriteLine("Multiplicación: " + product);
Console.WriteLine("División: " + quotient);

/*
Resultado:

Suma: 12
Resta: 2
Multiplicación: 35
División: 1
*/

/*<------Incorporación de código para efectuar la división con datos decimales literales------>*/
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"División decimal: {decimalQuotient}"); //División decimal: 1,4

/*<------Agregar código para convertir los resultados de la división de enteros------>*/
int first = 7;
int second = 5;
decimal division = (decimal)first / (decimal)second;
Console.WriteLine(division); // 1,4

/*<------Escritura de código para determinar el resto después de la división de enteros------>*/
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

/*
Resultado:

Modulus of 200 / 5 : 0
Modulus of 7 / 5 : 2
*/