using System;

namespace Unit9
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Alumno alumno = new Alumno("Pepito", 18);
            alumno.MayorDeEdad();
            Console.WriteLine("Su edad es: {0}", alumno.getEdad());
            Console.WriteLine("Su nombre es: {0}", alumno.getNombre());


            Alumno alumno1 = new Alumno("Jorgito", 15);
            alumno1.MayorDeEdad();
            Console.WriteLine("Su edad es: {0}", alumno1.getEdad());
            Console.WriteLine("Su nombre es: {0}", alumno1.getNombre());
        }
    }
}
