using System;

namespace EF0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {

                var std = new Persona()
                {
                    Nombre = "Karina",
                    Edad = 40
                };

                context.Personas.Add(std);
                context.SaveChanges();
            }
        }
    }
}
