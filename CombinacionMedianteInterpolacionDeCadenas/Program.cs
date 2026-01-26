/*<------Uso de la interpolación de cadenas para combinar una cadena literal y un valor de variable------>*/
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message); //Hello Bob!

/*<------Uso de la interpolación de cadenas con varias variables y cadenas literales------>*/
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message); //Update to Windows 11

/*<------Evitar variables intermedias------>*/
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!"); //Update to Windows 11!

/*<------Combinar literales textuales y interpolación de cadenas------>*/
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data"); //C:\Output\First-Project\Data