//Programa_5
double numero;
bool esPar;

Console.WriteLine("Ingresa un número:");
numero = double.Parse(Console.ReadLine());

esPar = (numero % 2) == 0;

if (esPar)
{
    Console.WriteLine("El número es Par: " + numero);
}
else
{
    Console.WriteLine("El número es Impar: " + numero);
}