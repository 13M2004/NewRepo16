//Programa_4
string nombreUsuario, contra;
bool correcto = false;

Console.WriteLine("Ingrese su Usuario: ");
nombreUsuario = (Console.ReadLine());

Console.WriteLine("Ingrese su Contraseña: ");
contra = (Console.ReadLine());

if (nombreUsuario == "AlexanderM" && contra == "manu_gt")
{
    correcto = true;
}
if (correcto)
{
    Console.WriteLine("Alexander Bienvenido");
}
else
{
    Console.WriteLine("Verifique Usuario o Contraseña Incorrecta");
}