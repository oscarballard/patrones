using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su Nombre");
            String name = Console.ReadLine();

            Console.WriteLine("Digite su contrasena");
            String pass = Console.ReadLine();

            login lg = login.getInstancia();
            lg.set_lg(name, pass);
            lg.lg();
        }
    }
  
}
