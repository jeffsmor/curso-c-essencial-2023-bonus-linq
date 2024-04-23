// //Exercicio 01
//
// string nome = "Paulo";
// int idade = 17;
// double nota = 7.5;
//
// Console.WriteLine($"Aluno {nome} tem {idade} e nota {nota}");
//
// //Exercicio 02
// Console.WriteLine($"\n{nome}\n{idade}\n{nota}");
//
// //Exercicio 03
// float number = 7.5f;
// double result;
//
// result = number * 2;
//
// Console.WriteLine(result);
//
// //Exercicio 04
//
// //Exercicio 05
// Console.WriteLine("Digite a primeira letra");
// string? letra1 = Convert.ToString(Console.ReadLine());
//
// Console.WriteLine("Digite a segunda letra");
// string? letra2 = Convert.ToString(Console.ReadLine());
//
// Console.WriteLine("Digite a terceira letra");
// string? letra3 = Convert.ToString(Console.ReadLine());
//
// Console.WriteLine($"\nTerceira letra:{letra3}\nSegunda letra:{letra2}\nPrimeira letra:{letra1}");
//
// //Exercicio 07
// Console.WriteLine("Digite o primeiro valor");
// int? valor1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Digite o segundo valor");
// int? valor2 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine(valor1 + valor2);
// Console.WriteLine(valor1 - valor2);
// Console.WriteLine(valor1 * valor2);
// Console.WriteLine(Math.Pow((int)valor1, (int)valor2));
// Console.WriteLine(valor1 / valor2);
// Console.WriteLine(valor1 % valor2);

//Exercicio 09

// Console.WriteLine("Digite o nome");
// string? nome1 = Console.ReadLine();
//
// Console.WriteLine("Digite a senha");
// int? senha1 = Convert.ToInt32(Console.ReadLine());
//
// string mensagem = (nome1 == "admin" || nome1 == "maria") && senha1 == 123
//     ? "Login feito com sucesso"
//     : "Login inválido";
//
// Console.WriteLine(mensagem);

//Exercicio 11

// Console.WriteLine("Digite o primeiro número");
// int? numero1 = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Digite o segundo número");
// int? numero2 = Convert.ToInt32(Console.ReadLine());
//
// string mensagem1 = (numero1 % 2) == 0 ? "par" : "ímpar";
// string mensagem2 = (numero2 % 2) == 0 ? "par" : "ímpar";
//
// Console.WriteLine($"Primeiro número é:{mensagem1}");
// Console.WriteLine($"Segundo número é:{mensagem2}");

//Exercicio 12

// Console.WriteLine("Digite o valor de x");
// double? x = Convert.ToDouble(Console.ReadLine());
//
// Console.WriteLine($"-6 + {x} * 5 = {(-6 + x * 5)}");
// Console.WriteLine($"(13-2) * {x} = {(13 - 2) * x}");
// Console.WriteLine($"({x} + -2) * (20 / {x}) = {(x + -2) * (20 / x)}");
// Console.WriteLine($"(12 + {x}) / ({x} - 4) = {(12 + x) / (x - 4)}");
// Console.WriteLine($"3 {x}^2 + x + 10 = {3 * Math.Pow((int)x, 2) + x + 10}");
// Console.WriteLine($"pi * {x}^2 = {Math.PI * Math.Pow((int)x, 2)}");

//Exercicio 14

// Console.WriteLine("Digite a temperatura(Celsius)");
//
// double c = Convert.ToDouble(Console.ReadLine());
//
// Console.WriteLine($"A temperatura em Kelvin é: {c + 273}");
// Console.WriteLine($"A temperatura em Farhenheit é: {(c * 9) / 5 + 32}");


//Exercicio 15

// var numero = 5;
// Console.WriteLine(numero++);
// numero = 1;
// Console.WriteLine(++numero);
// numero = 2;
// Console.WriteLine(numero--);
// numero = 3;
// Console.WriteLine(--numero);