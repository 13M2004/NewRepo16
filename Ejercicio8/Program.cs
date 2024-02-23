//Programa 8
string numLet;
int numero;

Console.WriteLine("Ingresa un número del 1 al 5 en letra:");
numLet = Console.ReadLine().ToLower();

switch (numLet)
{
    case "uno":
        numero = 1;
    break;

    case "dos":
        numero = 2;
    break;

    case "tres":
        numero = 3;
    break;

    case "cuatro":
        numero = 4;
    break;

    case "cinco":
        numero = 5;
    break;

    default:
        Console.WriteLine("Numero no valido");
        numero = 0;
    break;
}

Console.WriteLine("El numero en digito es: " + numero);