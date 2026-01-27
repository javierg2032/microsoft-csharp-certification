/*<------Incremento y disminución------>*/
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.

/*<------Escribir código para incrementar y disminuir un valor------>*/
value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

/*
Resultado:

First increment: 2
Second increment: 3
Third increment: 4
First decrement: 3
Second decrement: 2
Third decrement: 1
*/

/*<------Utiliza el operador de incremento antes y después del valor------>*/
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

/*
Resultado:

First: 2
Second: 2
Third: 3
Fourth: 4
*/