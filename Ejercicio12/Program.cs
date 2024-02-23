//Programa 12
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("¡Bienvenido!");
Console.ReadLine();
Console.ResetColor();

Thread.Sleep(2000);
Console.WriteLine();

Console.Write("Ingrese la calificación del examen: ");
int calificacion = Convert.ToInt32(Console.ReadLine());

switch (calificacion)
{
    case int n when (n >= 95 && n <= 100):
        Console.WriteLine("Cerebrito mi hermano");
        break;
    case int n when (n >= 80 && n <= 89):
        Console.WriteLine("Notable");
        break;
    case int n when (n >= 70 && n <= 79):
        Console.WriteLine("Aprobatoria");
        break;
    case int n when (n >= 60 && n <= 69):
        Console.WriteLine("No aprobatoria");
        break;
    case int n when (n >= 45 && n <= 68):
        Console.WriteLine("REPITE EL CURSO");
        break;
    default:
        Console.WriteLine("Calificación no válida");
        break;
}