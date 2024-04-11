Console.WriteLine("## Conversã de Tipos ##\n");

double varDouble = 12.345; //double: 8 bytes
int varInt = (int)varDouble; //int: 4 bytes //haverá perda de precisão

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2;
Console.WriteLine(resultado);

Console.ReadLine();

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.ReadLine();

int valorInt2 = 10;
double valorDouble2 = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt2));
Console.WriteLine(Convert.ToDouble(valorInt2));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble2));

//int varInt2 = 100000;
//Console.WriteLine(Convert.ToByte(varInt2)); //OverflowException

Console.ReadLine();