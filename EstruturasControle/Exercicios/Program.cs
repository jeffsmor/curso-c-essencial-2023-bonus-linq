Console.WriteLine("## Exercicios ##\n");

#region
//int numero1, numero2, numero3;
//int maiorNumero;

//Console.WriteLine("Digite o primeiro número");
//numero1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o segundo número");
//numero2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Digite o terceiro número");
//numero3 = Convert.ToInt32(Console.ReadLine());

//if (numero1 >= numero2 && numero1 >= numero3)
//{
//    maiorNumero = numero1;
//}
//else if (numero2 >= numero1 && numero2 >= numero3)
//{
//    maiorNumero = numero2;
//}
//else
//{
//    maiorNumero = numero3;
//}

//Console.WriteLine($"O maior número digitado foi {maiorNumero}");
#endregion

#region
//int soma = 0;

//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"{i} ");
//    soma += i;
//}

//int soma = 0;
//int i = 1;

//while (i <= 10)
//{
//    Console.Write($"{i} ");
//    soma += i;
//    i++;
//}

//int soma = 0;
//int i = 1;

//do
//{
//    Console.Write($"{i} ");
//    soma += i;
//    i++;
//} while (i <= 10);

//Console.WriteLine($"\nO resultado é: {soma}");
#endregion

#region
//int numero;

//while (true)
//{
//    Console.WriteLine("Digite um número maior que 0 ou digite 999 para sair");
//    numero = Convert.ToInt32(Console.ReadLine());

//    if (numero <= 0)
//    {
//        Console.WriteLine("Número menor ou igual a 0");
//    }
//    else if (numero == 999)
//    {
//        break;
//    }
//    else
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            Console.WriteLine($"{numero} x {i} = {numero * i}");
//        }
//    }
//}
#endregion

#region
//bool sair = false;
//string? resposta;

//while (!sair)
//{
//    Console.WriteLine("Qual a instrução para sair de um loop? (Tecle x para sair)");
//    Console.WriteLine("a.quit\nb.continue\nc.break\nd.exit");
//    resposta = Console.ReadLine();

//    if (resposta == "x")
//    {
//        sair = true;
//    }
//    else if (resposta == "c")
//    {
//        Console.WriteLine("Resposta correta");
//        sair = true;
//    }
//    else
//    {
//        Console.WriteLine("Resposta incorreta");
//        Console.WriteLine("Deseja tentar novamente ou sair?");
//        Console.WriteLine("a.tentar novamente\nx.sair");
//        resposta = Console.ReadLine();

//        if (resposta == "x")
//        {
//            sair = true;
//        }
//    }
//}
#endregion

#region
//int i = 10;

//while (!sair)
//{
//    if (i == 16)
//    {
//        i++;
//        continue;
//    }

//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//    if (i > 20)
//    {
//        break;
//    }

//    i++;
//}

//while (true)
//{
//    if (i == 16)
//    {
//        i += 2;
//        continue;
//    }

//    if (i > 20)
//    {
//        break;
//    }

//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }

//    i += 2;
//}
#endregion

#region
//for (int i = 1; i <= 4; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine();
//}
#endregion

#region
//int x = 2;

//do
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine($"{x} x {i} = {x * i}");
//    }

//    x++;
//    Console.WriteLine("\n");
//} while (x <= 6);
#endregion

#region
//while (true)
//{
//    Console.WriteLine("Digite a nota do aluno de 0 a 10 ou digite 999 para sair");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 999)
//    {
//        break;
//    }
//    else if (numero < 0 || numero > 10)
//    {
//        Console.WriteLine("A nota deve estar entre 0 e 10");
//    }
//    else
//    {
//        switch (numero)
//        {
//            case 10:
//                Console.WriteLine("A avaliação do aluno foi A+");
//                break;

//            case 9:
//                Console.WriteLine("A avaliação do aluno foi A");
//                break;

//            case 8:
//            case 7:
//                Console.WriteLine("A avaliação do aluno foi B");
//                break;

//            case 6:
//                Console.WriteLine("A avaliação do aluno foi C");
//                break;

//            case 5:
//                Console.WriteLine("A avaliação do aluno foi E");
//                break;

//            default:
//                Console.WriteLine("A avaliação do aluno foi F");
//                break;
//        }
//    }
//}
#endregion

Console.WriteLine("Informe o primeiro número");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o operando (+,-,/,*)");
var operando = Console.ReadLine();

Console.WriteLine("Informe o segundo número");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero2 == 0 && operando == "/")
{
    Console.WriteLine("Não existe divisão por 0");
}
else
{
    switch (operando)
    {
        case "+":
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            break;

        case "-":
            Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            break;

        case "/":
            Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            break;

        case "*":
            Console.WriteLine($"{numero1} * {numero2} = {numero1 * numero2}");
            break;

        default:
            Console.WriteLine("Operando inválido");
            break;
    }
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();