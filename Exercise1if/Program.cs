// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa tu nombre: ");
string Nombre = Console.ReadLine();

Console.WriteLine("Ingresa tu email: ");
string email = Console.ReadLine();

Console.WriteLine("Posee cupon? (s/n): ");
string posee = Console.ReadLine();

int descuento = 0;
int precio = 25000;


if (posee =="S" || posee == "s")
{
    Console.WriteLine("Ingresa el codigo del cupon: ");
    string cupon = Console.ReadLine();

    Console.WriteLine("Ingresa el % de descuento del cupon: ");
    int porc = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Precio del producto: " + precio);
    descuento = precio * porc / 100;
  

    Console.WriteLine("Precio con descuento: " + (precio-descuento));
}
else
{
    Console.WriteLine();
    Console.WriteLine("Precio del producto: " + precio);
}


