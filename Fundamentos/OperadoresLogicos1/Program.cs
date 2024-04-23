Console.WriteLine("## Operadores Lógicos ##\n");

bool c1 = 5 >= 7; //False
bool c2 = 9 != 8; //True
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}");

//operador AND -> &&
resultado = c1 && c2;
Console.WriteLine($"Operador AND(&&): {resultado}");

//operador OR -> ||
resultado = c1 || c2;
Console.WriteLine($"Operador OR(||) {resultado}");

//operador NOT -> !
resultado = !c2;
Console.WriteLine($"Operador NOT(!) {resultado}");

Console.ReadKey();