using NachoOperaMulti;
using NachoOperaResta;
// Contiene todas las operaciones
using NachoOperaOperaciones;

int a, b, ans;
float division;

Console.WriteLine("¿Qué números desea operar?");
Console.WriteLine("Primer número: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Segundo número: ");
b = int.Parse(Console.ReadLine());

Console.WriteLine("¿Qué operación desea realizar? 1. Suma | 2. Resta | 3. Multiplicación | 4. División");
ans = int.Parse(Console.ReadLine());

switch (ans)
{
    case 1:
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Suma: {Operaciones.Suma(a, b)}");
        Console.WriteLine("----------------------------------");
        break;
    case 2:
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Resta: {Operaciones.Resta(a, b)}");
        Console.WriteLine("----------------------------------");
        break;
    case 3:
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Multiplicación: {Operaciones.Multiplicacion(a, b)}");
        Console.WriteLine("----------------------------------");
        break;
    case 4:
        Console.WriteLine();
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"División: {Operaciones.Division(a, b)}");
        Console.WriteLine("----------------------------------");
        break;
    default:
        Console.WriteLine();
        Console.WriteLine("Opción fuera de rango. Se muestran todas las operaciones: ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Suma: {Operaciones.Suma(a, b)}");
        Console.WriteLine($"Resta: {Operaciones.Resta(a, b)}");
        Console.WriteLine($"Multiplicación: {Operaciones.Multiplicacion(a, b)}");
        Console.WriteLine($"División: {Operaciones.Division(a, b)}");
        Console.WriteLine("----------------------------------");
        break;

}
