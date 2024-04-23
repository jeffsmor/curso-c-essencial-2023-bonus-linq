Console.WriteLine("## Inferência Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

Console.ReadKey();

//var limitações
//var salario2 = null;
//var titulo;
//var salario, imposto, total;

//não posso mudar tipo após inicializar
//var num = 10;
//num = num + 20;
//num = "teste";

var test = new Teste();
test.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}