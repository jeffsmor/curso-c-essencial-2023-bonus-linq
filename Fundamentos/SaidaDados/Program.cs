Console.WriteLine("Saída de dados: Formatação");
Console.WriteLine();

string nome = "Maria";
int idade = 25;
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();
Console.WriteLine("-------------concatenação------------");

//Escreve na mesma linha 'Maria tem 25 anos'

Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos ");

//Usar a concatenação: usando o operador +

Console.WriteLine();
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();
Console.WriteLine("-------------interpoloção------------");

//Usar a interpolação de string: $ -> a interpolção de {}

Console.WriteLine($"{nome} tem {idade} anos");

Console.WriteLine("-------------place holders------------");
//usar place holders: usa {} com numeração com inicio em zero

Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();