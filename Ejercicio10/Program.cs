//Programa 10
string[] servicios = { "Lavado de auto", "Cambio de aceite", "Revisión mecanica", };
int[] imp = { 85, 250, 175 };

Console.WriteLine("Ingrese el tipo de servicio (Lavado de auto, Cambio de aceite, Revisión mecánica):");
string servicioElegido = Console.ReadLine();

int indiceServicio = Array.IndexOf(servicios, servicioElegido);

switch (indiceServicio)
{
    case 0:
        Console.WriteLine("El importe del servicio es: " + imp[0]);
        break;
    case 1:
        Console.WriteLine("El importe del servicio es: " + imp[1]);
        break;
    case 2:
        Console.WriteLine("El importe del servicio es: " + imp[2]);
        break;
    default:
        Console.WriteLine("El servicio elegido no Existente.");
        break;
}