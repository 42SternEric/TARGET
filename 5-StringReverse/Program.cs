
string texto = ("Hello World!");

Console.WriteLine($"\nTexto Normal : {texto}\n");

string textoInvertido = new string(texto.Reverse().ToArray());

Console.WriteLine($"Texto Convertido : {textoInvertido}\n");

//Eric Stern