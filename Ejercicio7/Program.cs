//Programa_7
string figura;

double lado1 = 0, lado2 = 0, radio = 0;

Console.WriteLine("Ingresa el nombre de una figura (triángulo, cuadrado o círculo): ");
figura = (Console.ReadLine());

switch (figura)
{
    case "triángulo":
        Console.WriteLine("Ingrese la base del triángulo: ");
        lado1 = double.Parse(Console.ReadLine());
        radio = 0;
        Console.WriteLine("Ingrese la altura del triángulo: ");
        lado2 = double.Parse(Console.ReadLine());
        break;
    case "cuadrado":
        Console.WriteLine("Ingrese el lado del cuadrado: ");
        radio = 0;
        lado1 = double.Parse(Console.ReadLine());
        break;
    case "círculo":
        Console.WriteLine("Ingrese el radio del círculo: ");
        radio = 0;
        radio = double.Parse(Console.ReadLine());
        break;
    default:
        Console.WriteLine("Tipo de figura no válida");
        return;
}

//Area de tu Figura
double area = 0;
switch (figura)
{
    case "triángulo":
        area = (lado1 * lado2) / 2;
        break;
    case "cuadrado":
        area = lado1 * lado1;
        break;
    case "círculo":
        area = Math.PI * Math.Pow(radio, 2);
        break;
}

Console.WriteLine("El área de la figura es: " + area);