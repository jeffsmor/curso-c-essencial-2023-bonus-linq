Console.WriteLine("## break continue ##\n");

#region
// for (int i = 0; i <= 10; i++)
// {
//     if (i == 4)
//     {
//         continue;
//     }
//     
//     Console.WriteLine(i);
// }
#endregion

#region
// int n = 1;
//
// while (n <= 10)
// {
//     if (n == 5)
//     {
//         n++;
//         continue;
//     }
//
//     Console.WriteLine($"n={n}");
//     n++;
// }
#endregion

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        continue;
    }

    if (i == 8)
    {
        break;
    }

    Console.WriteLine(i);
}

Console.WriteLine("\nFim do preocessamento...");
Console.ReadKey();