Console.WriteLine("## Tipos de Referência Anuláveis ##\n");

string? nome = null;

Console.WriteLine($"nome: {nome?.ToUpper()}");

nome = "Jeffs";

Console.WriteLine($"nome: {nome?.ToUpper()}");

Console.ReadKey();