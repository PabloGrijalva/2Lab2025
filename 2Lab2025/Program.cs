using System;

// Preguntar Nombre
Console.WriteLine("¿Cuál es tu nombre?");
string nombre = Console.ReadLine();
Console.WriteLine($"Hola {nombre}, ¿qué edad tienes?");

// preguntar edad
int edad;
bool edadValida = int.TryParse(Console.ReadLine(), out edad) && edad >= 6 && edad <= 120;

if (edadValida)
{
    Console.WriteLine($"Tu edad es {edad}");
}
else
{
    Console.WriteLine("Ingresaste algo incorrecto. Recuerda que solo puedes ingresar números enteros o una edad posible.");
}

// Preguntar sueldo
Console.WriteLine("Ingresa tu sueldo (puedes usar decimales):");
double sueldo;
bool sueldoValido = double.TryParse(Console.ReadLine(), out sueldo);

if (sueldoValido)
{
    Console.WriteLine($"Tu sueldo es {sueldo}");
}
else
{
    Console.WriteLine("Ingresaste algo incorrecto. Recuerda que solo puedes ingresar números enteros o decimales.");
}

// Segundo ejercicio: hacer operaciones matematicas
Console.WriteLine("operaciones matemáticas.");

double numero1 = LeerNumero("Ingresar número:");
double numero2 = LeerNumero("Ingresar segundo número:");

double suma = numero1 + numero2;
double resta = numero1 - numero2;
double multiplicacion = numero1 * numero2;
double division = numero1 / numero2;

Console.WriteLine("Resultados:");
Console.WriteLine($"{numero1} + {numero2} = {suma}");
Console.WriteLine($"{numero1} - {numero2} = {resta}");
Console.WriteLine($"{numero1} * {numero2} = {multiplicacion}");
Console.WriteLine($"{numero1} / {numero2} = {division}");

// Tercer ejercicio: hacer operaciones logicas
Console.WriteLine("Ahora vamos a hacer operaciones lógicas con nuevos valores.");

double valorLogico1 = LeerNumero("Ingresa un primer valor para las operaciones lógicas:");
double valorLogico2 = LeerNumero("Ingresa un segundo valor para las operaciones lógicas:");

Console.WriteLine("Resultados de las operaciones lógicas:");
Console.WriteLine($"¿{valorLogico1} es mayor que {valorLogico2}? {valorLogico1 > valorLogico2}");
Console.WriteLine($"¿{valorLogico1} es menor que {valorLogico2}? {valorLogico1 < valorLogico2}");
Console.WriteLine($"¿{valorLogico1} es igual que {valorLogico2}? {valorLogico1 == valorLogico2}");

Console.WriteLine($"¿{valorLogico1} es mayor que 0 Y {valorLogico2} es mayor que 0? {valorLogico1 > 0 && valorLogico2 > 0}");
Console.WriteLine($"¿{valorLogico1} es mayor que 0 O {valorLogico2} es mayor que 0? {valorLogico1 > 0 || valorLogico2 > 0}");


// Método para leer un número válido desde la consola
static double LeerNumero(string mensaje)
{
    double numero;
    Console.WriteLine(mensaje);
    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Número no válido. Ingresa un número válido.");
    }
    return numero;
}
