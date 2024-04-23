Console.WriteLine("## Nullable Types ##\n");

//int valor = null; isso é um erro!
int valor = 100;
Console.WriteLine(valor);

Nullable<int> @int = null;
Nullable<double> @double = null;
Nullable<bool> @bool = null;

int? i2 = null;
double? d2 = null;
bool? b2 = null;

// coalescência nula ??

int? a = null;

int b = a ?? 0;

// expressão

int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine(z);

//Nullable Types possui as propriedades HasValue e Value

int? e = 100;

if (e.HasValue)
{
    Console.WriteLine($"e = {e.Value}");
}
else
{
    Console.WriteLine("e não possui valor. (null)");
}

Console.ReadLine();