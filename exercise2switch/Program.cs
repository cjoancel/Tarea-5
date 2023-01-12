// See https://aka.ms/new-console-template for more information
string[] lenguajes = new string[] { "C", "C#" , "C++" , "Java" , "Pyton" , "Rubi" };

int i=1;
foreach(string s in lenguajes)
{
    Console.WriteLine(i + ": " +s);
    i++;
}

Console.WriteLine("Ingrese el numero del lenguaje deseado: ");
int opc = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
        Console.WriteLine("Ud eligio: "+ lenguajes[opc-1]);
        break;
    case 2:
        Console.WriteLine("Ud eligio: " + lenguajes[opc - 1]);
        Console.WriteLine("¡Hola Mundo!");
        break;
    case 3:
        Console.WriteLine("Ud eligio: " + lenguajes[opc - 1]);
        break;
    case 4:
        Console.WriteLine("Ud eligio: " + lenguajes[opc - 1]);
        break;
    case 5:
        Console.WriteLine("Ud eligio: " + lenguajes[opc - 1]);
        break;
    case 6:
        Console.WriteLine("Ud eligio: " + lenguajes[opc - 1]);
        break;
    default:
        Console.WriteLine("Ud eligio: " + lenguajes[opc - 1]);
        break;
}