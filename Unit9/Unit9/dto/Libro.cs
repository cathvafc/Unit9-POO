using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9.dto
{

    class Libro
    {
        private string autor = "";
        private string titulo = "";
        private string ubicacion = "";

        //static void Main(string[] args)       
        //{
        //    Libro libro1 = new Libro();

        //    libro1.setAutor("Yo");
        //    libro1.setTitulo("Tu");
        //    libro1.setUibicacion("Aquí");

        //    Console.WriteLine("El autor del libro es: {0}", libro1.getAutor());
        //    Console.WriteLine("El titulo del libro es: {0}", libro1.getTitulo());
        //    Console.WriteLine("La ubicación del libro es: {0}", libro1.getUbicacion());
        //}

        public string getAutor()
        {
            return autor;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public string getUbicacion()
        {
            return ubicacion;
        }

        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void setUibicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
    }
}
