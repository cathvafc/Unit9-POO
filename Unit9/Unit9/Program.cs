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

            Empleado empleado = new Empleado("Pepito", 3500);
            empleado.PagarImpuestos();
            Console.WriteLine("Su sueldo es: {0}", empleado.getSueldo());
            Console.WriteLine("Su nombre es: {0}", empleado.getNombre());

            Empleado empleado1 = new Empleado("Jorgito", 1500);
            empleado1.PagarImpuestos();
            Console.WriteLine("Su sueldo es: {0}", empleado1.getSueldo());
            Console.WriteLine("Su nombre es: {0}", empleado1.getNombre());
        }
    }
}
