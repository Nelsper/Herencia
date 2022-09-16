using System;
namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            People person = new People();
            person.Name = "Nelson";
            person.LastName = "Perez";
            person.Id = 80879413;

            Client cliente = new Client();
            cliente.IdCliente = 001;
            
            
            System.Console.WriteLine($"N°Cliente: {cliente.IdCliente}");
            System.Console.WriteLine($"Bienvenido {person.Name} {person.LastName} ");
            System.Console.WriteLine($"C.c {person.Id}");
        }
    }
}
