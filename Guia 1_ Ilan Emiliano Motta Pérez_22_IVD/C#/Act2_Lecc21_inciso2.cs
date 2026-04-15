internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===BUZON DE VOZ");
        Console.WriteLine("1 - Ventas");
        Console.WriteLine("2 - Recepcion");
        Console.WriteLine("3 - Direccion");
        Console.WriteLine("4 - Compras");
        Console.WriteLine("Digite una opcion: ");
        string voz = Console.ReadLine();

        if (voz == "1")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE VENTAS");
            Console.WriteLine("Nombre Responsable: Ilan Motta");
            Console.WriteLine("Correo: i.motta.5bdb@gmail.com");
        }
        else if (voz == "2")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE RECEPCION");
            Console.WriteLine("Nombre Responsable: Carlos Motta");
            Console.WriteLine("Correo: carlosemotta@gmail.com");
        }
        else if (voz == "3")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE DIRECCION");
            Console.WriteLine("Nombre Responsable: Marisol Perez");
            Console.WriteLine("Correo: marisolperezd@gmail.com");
        }
        else if (voz == "4")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE COMPRAS");
            Console.WriteLine("Nombre Responsable: Rhyo Motta");
            Console.WriteLine("Correo: r.motta.7ddb@gmail.com");
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}