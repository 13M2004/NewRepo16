//Programa 11
Console.WriteLine("Ingrese el nombre del idioma de su preferencia: ");
string idioma = Console.ReadLine();

switch (idioma.ToLower())
{
    case "español":
        Console.WriteLine("¡Bienvenido!");
        break;
    case "inglés":
        Console.WriteLine("Welcome!");
        break;
    case "francés":
        Console.WriteLine("Bienvenue!");
        break;
    default:
        Console.WriteLine("Idioma no válido");
        break;
}