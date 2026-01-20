/*------Secuencias de escape de caracteres------*/

Console.WriteLine("Hello\nWorld!"); //Hello
                                    //World!
Console.WriteLine("Hello\tWorld!"); //Hello   World!
Console.WriteLine("Hello \"World\"!"); //Hello "World"!
Console.WriteLine("c:\\source\\repos"); //c:\source\repos

/*------Aplicación de formato a la salida mediante secuencias de escape de caracteres------*/

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");

/*
Resultado:

Generating invoices for customer "Contoso Corp" ...

Invoice: 1021           Complete!
Invoice: 1022           Complete!

Output Directory:
*/


/*------Literal de cadena textual------*/
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
/*
Resultado:

c:\source\repos    
        (this is where your code goes)
*/


/*------Aplicación de formato a la salida mediante literales de cadena textual------*/
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
/*
Resultado:
Generating invoices for customer "Contoso Corp" ...

Invoice: 1021           Complete!
Invoice: 1022           Complete!

Output Directory:       c:\invoices
*/