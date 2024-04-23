Console.WriteLine("## Instrução if-else ##\n");

#region
// Console.WriteLine("Informe a nota do aluno \t");
// var nota = Convert.ToInt32(Console.ReadLine());
//
// if (nota > 5)
// {
//     Console.WriteLine("Aluno aprovado");
// }
// else
// {
//     Console.WriteLine("Aluno reprovado");
// }
#endregion

Console.WriteLine("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x maior que y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("x menor que y");
    }
    else
    {
        Console.WriteLine("x igual a y");
    }
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();