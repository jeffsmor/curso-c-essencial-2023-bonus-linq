Console.WriteLine("Definindo Identificadores'");
Console.WriteLine();

//identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

// identificadores inválidos
//int 5idade;
//int $valor;
//int valor#total;
//string nome Completo;

//para nomes de variáveis: camel case

string descontoTotal;
string desconto_Total;

//constantes: maiúsculas

double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";

//para nomes de class e métodos: pascal case

class ImprimirTexto()
{
    public void ImprimeNome()
    {
        Console.WriteLine("Nome");
    }
}