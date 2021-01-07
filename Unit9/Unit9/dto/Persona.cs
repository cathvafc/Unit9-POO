using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9.dto
{
    class Persona
    {
        string name = "";
        public Persona()
        {
            
        }
       
        
        public void setNombre(string name)
        {
            this.name = name;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", name);
        }
    }
}
