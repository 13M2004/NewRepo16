//Programa 9

string[] semana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
int numeroSem;

Console.WriteLine("Ingresar un numero del 1 al 7");
numeroSem = int.Parse(Console.ReadLine());

switch (numeroSem)
{
    case 1:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[0]);
        break;

    case 2:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[1]);
        break;

    case 3:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[2]);
        break;

    case 4:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[3]);
        break;

    case 5:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[4]);
        break;

    case 6:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[5]);
        break;

    case 7:
        Console.WriteLine("El numero " + numeroSem + " pertenece al dia de la semana que es: " + semana[6]);
        break;

    default:
        Console.WriteLine("Numero no valido");
        break;
}