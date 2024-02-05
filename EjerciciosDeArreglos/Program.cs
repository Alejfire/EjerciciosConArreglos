// 1.Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.

/*
Console.WriteLine("Escriba 10 numeros, presione [ENTER] para cada uno:");

int[] array = new int[10];
int mayorNumero = 0;
int posicionDelMayorNumero = 0;

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > mayorNumero)
    {
        mayorNumero = array[i];
        posicionDelMayorNumero = i+1;
    }
}

Console.WriteLine($"El numero mayor en su lista es {mayorNumero} y este esta en la posicion numero {posicionDelMayorNumero}");
*/

//2.Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.

/*
Console.WriteLine("Escriba 10 numeros, presione [ENTER] para cada uno:");

int[] array = new int[10];
int mayorNumero = 0;
int posicionDelMayorNumero = 0;

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > mayorNumero && array[i] % 2 == 0)
    {
        mayorNumero = array[i];
        posicionDelMayorNumero = i + 1;
    }
}

if (mayorNumero == 0)
{
    Console.WriteLine("Ninguno de los numeros es par.");
}
else
{
    Console.WriteLine($"El numero par mayor en su lista es {mayorNumero} y este esta en la posicion numero {posicionDelMayorNumero}");
}
*/

//3.       Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.

/*using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Escriba 10 numeros, presione [ENTER] para cada uno:");

int[] array = new int[10];
int mayorNumero = 0;
int posicionDelMayorNumero = 0;

static bool EsPrimo(int num)
{
    if (num < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;
}

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > mayorNumero && EsPrimo(array[i]))
    {
        mayorNumero = array[i];
        posicionDelMayorNumero = i + 1;
    }
}

if (mayorNumero == 0)
{
    Console.WriteLine("Ninguno de los numeros es primo.");
}
else
{
    Console.WriteLine($"El numero primo mayor en su lista es {mayorNumero} y este esta en la posicion numero {posicionDelMayorNumero}");
}
*/

//4.       Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo

/*
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Escriba 10 numeros, presione [ENTER] para cada uno:");

int[] array = new int[10];
int posicionDelMayorNumero = 0;
int cantidadDeNumsPrimos = 0;

static bool DigitoEsPrimo(int num)
{
    int primerDigito = Math.Abs(num).ToString()[0] - '0';
    return primerDigito == 2 || primerDigito == 3 || primerDigito == 5 || primerDigito == 7;
}

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (DigitoEsPrimo(array[i]))
    {
        cantidadDeNumsPrimos++;
    }
}

if (cantidadDeNumsPrimos == 0)
{
    Console.WriteLine("Ninguno de los numeros es primo.");
}
else
{
    Console.WriteLine($"{cantidadDeNumsPrimos} de los numeros empiezan con un digito primo.");
}
*/

//6.       Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos

/*
Console.WriteLine("Escriba 10 numeros, presione [ENTER] para cada uno:");

int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Los numeros con mas de 3 digitos estan en las posiciones: ");

for (int i = 0;i < array.Length; i++)
{
    if (Math.Abs(array[i]).ToString().Length > 3)
    {
        Console.WriteLine(i+1);
    }
}
*/