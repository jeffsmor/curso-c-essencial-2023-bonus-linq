Console.WriteLine("## Instrução While ##\n");

#region
// var i = 1;
//
// while (i<=10)
// {
//     Console.WriteLine($"i={i}");
//     i++;
// }

// var i = 10;
//
// while (i>0)
// {
//     Console.WriteLine($"i={i}");
//     i--;
// }
#endregion

#region
// int numero;
// int contador = 1;
//
// Console.WriteLine("\nDigite um número maior que zero \t");
// numero = Convert.ToInt32(Console.ReadLine());
//
// if (numero > 0)
// {
//     while (contador <= 10)
//     {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//         contador++;
//     }
// }
// else
// {
//     Console.WriteLine("Número deve ser maior que zero");
// }
#endregion

#region

// while (true)
// {
//     Console.WriteLine("\nInforme um número inteiro: (Para sair tecle 999)");
//     int numero = Convert.ToInt32(Console.ReadLine());
//
//     if (numero == 999)
//     {
//         break;
//     }
//
//     if (numero % 2 ==0)
//     {
//         Console.WriteLine($"Número {numero} é PAR");
//     }
//     else
//     {
//         Console.WriteLine($"Número {numero} é IMPAR");
//     }
// }

#endregion

#region

// int x = 0;
//
// while (x < 5)
// {
//     int y = 0;
//
//     while (y < 5)
//     {
//         Console.Write($"({x}, {y})");
//         y++;
//     }
//
//     x++;
//     Console.WriteLine();
// }

#endregion

#region
// var i = 1;
//
// do
// {
//     Console.WriteLine($"i={i}");
//     i++;
// } while (i <= 10);
#endregion

int x = 0;

do {
    int y = 0;

    do{
        Console.Write($"({x}, {y})");
        y++;
    }
    while (y < 5) ;


    x++;
    Console.WriteLine();
}
while (x < 5) ;

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();