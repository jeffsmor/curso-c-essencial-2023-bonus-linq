Console.WriteLine("## Instrução for ##\n");

#region
// int numero, resultado;
//
// Console.WriteLine("Informe o número inteiro: \t");
// numero = Convert.ToInt32(Console.ReadLine());
//
// for (int i = 0; i <=10; i++)
// {
//     resultado = numero * i;
//     Console.WriteLine($"{numero} x {i} = {resultado}");
// }
#endregion

#region
// for (int i = 0, j=0; i+j <= 20; i++, j++)
// {
//     Console.WriteLine($"i={i} e j={j}");
// }
#endregion

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x}, {y}) ");
    }
    
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();