namespace Herencia
{
    class Client : People
    {
        public int IdCliente { get; set; }
    }
    // Constructor
    public Client(string name, string lastname, int id, int idcliente) : base(name, lastname, id) 
    {
        IdCliente = idcliente;
    }
    //Polimorfismo
    // public override void saludo()
    // {
    //     System.Console.WriteLine("Welcome");
    // }
}