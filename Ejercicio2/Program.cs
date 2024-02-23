//Programa_2
int edadClub;

Console.WriteLine("Ingresa tu edad: ");
edadClub = int.Parse(Console.ReadLine());

if (edadClub >= 18)
{
    Console.WriteLine("Bienvenido al Club");
}
else
{
    Console.WriteLine("No cuentas con la edad requerida para entrar al Club");
}