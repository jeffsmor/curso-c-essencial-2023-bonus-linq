using System.Globalization;

Console.WriteLine("## Conversã de Tipos ##\n");

const double varDouble = 12.345; //double: 8 bytes
var varInt = (int)varDouble; //int: 4 bytes //haverá perda de precisão

Console.WriteLine(varInt);

var num1 = 10;
var num2 = 4;

var resultado = (float)num1 / num2;
Console.WriteLine(resultado);

Console.ReadLine();

var valorInt = 123;
var valorDouble = 12.45;
var valorDecimal = 12.45678m;

var s1 = valorInt.ToString();
var s2 = valorDouble.ToString(CultureInfo.CurrentCulture);
var s3 = valorDecimal.ToString(CultureInfo.CurrentCulture);

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.ReadLine();

var valorInt2 = 10;
var valorDouble2 = 5.35;
var valorBool = true;

Console.WriteLine(Convert.ToString(valorInt2));
Console.WriteLine(Convert.ToDouble(valorInt2));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble2));

//int varInt2 = 100000;
//Console.WriteLine(Convert.ToByte(varInt2)); //OverflowException

Console.ReadLine();