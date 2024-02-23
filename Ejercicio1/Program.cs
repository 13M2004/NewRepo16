//Programa_1
double num1, num2, num3;

Console.WriteLine("Ingrese el primer numero:");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero:");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer numero:");
num3 = double.Parse(Console.ReadLine());

double numMayor = Math.Max(num3, Math.Max(num2, num1));

Console.WriteLine("El numero mayor es: " + numMayor);