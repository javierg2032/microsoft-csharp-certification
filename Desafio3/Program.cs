/*<------Desafío: aplicación de formato y visualización de las instrucciones------>*/
//Escribe un programa en C# que, usando solo dos Console.WriteLine y sin modificar las variables dadas, muestre dos rutas de archivo (inglés y ruso) aplicando interpolación, Unicode y secuencias de escape para que la salida coincida exactamente con el formato indicado.
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n  c:\\Exercise\\{projectName}\\data.txt\n");
Console.WriteLine($"{russianMessage}:\n  c:\\Exercise\\{projectName}\\ru-RU\\data.txt");

/*
Resultado:

View English output:
  c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
  c:\Exercise\ACME\ru-RU\data.txt

*/