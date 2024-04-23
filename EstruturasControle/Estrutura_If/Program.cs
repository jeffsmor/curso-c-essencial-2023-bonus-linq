Console.WriteLine("## Instrução if ##\n");

#region
// Console.WriteLine("Cliente Especial (S/N)");
//
// var resposta = Console.ReadLine();
//
// if (resposta == "S")
// {
//     Console.WriteLine("Desconto de 10%");
// }
#endregion

#region
// Console.WriteLine("Cliente Especial (true/false)");
//
// var resposta = Convert.ToBoolean(Console.ReadLine());
//
// if (resposta)
// {
//     Console.WriteLine("Desconto de 10%");
// }
#endregion

Console.WriteLine("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}

if (x < y)
{
    Console.WriteLine("x é menor que y");
}

if (x == y)
{
    Console.WriteLine("x é igual a y");
}

Console.WriteLine("Fim do procecssamento");
Console.ReadKey();
