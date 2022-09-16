namespace Herencia 
{
    class People
    {
        public string Name { get; set;}
        public string LastName { get; set;}
        public int Id { get; set;}
        
    }
    // Constructor
    public People(string name, string lastname, int id)
    {
        Name = name;
        LastName = lastname;
        Id = id;
    }
    // Polimorfismo
    // public virtual void saludo()
    // {
    //     System.Console.WriteLine("Hello");
    // }
}