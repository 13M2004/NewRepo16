//Programa_3
double valorproduc;

Console.WriteLine("Ingresa el valor del producto: ");
valorproduc = double.Parse(Console.ReadLine());

double descuento = (valorproduc * 10) / 100;
double precioTotal = valorproduc - descuento;

if (valorproduc > 100)
{
    Console.WriteLine("Precio Total del producto es: " + precioTotal);
}
else
{
    Console.WriteLine("Precio total del producto es: " + valorproduc);
}