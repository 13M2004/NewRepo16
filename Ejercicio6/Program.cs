//Programa_6
double monto;
int edad;
bool correcto = false;

Console.WriteLine("Ingrese el monto del prestamo: ");
monto = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine();
if (monto <= 5000 || edad >= 60)
{
    correcto = true;
}
if (correcto)
{
    Console.WriteLine("¡Prestamo Aprobado!");
}
else
{
    Console.WriteLine("¡Rechazo de Prestamo!");
}
