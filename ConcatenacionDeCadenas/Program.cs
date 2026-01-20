/*<------Concatenación de una cadena de literales y una variable------>*/
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message); //Hello Bob

/*<------Concatenación de varias variables y cadenas de literales------>*/
string firstName1 = "Bob";
string greeting = "Hello";
string message1 = greeting + " " + firstName1 + "!";
Console.WriteLine(message1); //Hello Bob!

/*<------Evitación de variables intermedias------>*/
string firstName2 = "Bob";
string greeting2 = "Hello";
Console.WriteLine(greeting2 + " " + firstName2 + "!"); //Hello Bob!