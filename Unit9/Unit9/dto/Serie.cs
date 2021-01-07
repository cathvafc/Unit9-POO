using System;
using System.Collections.Generic;
using System.Text;

namespace Unit9.dto
{
    class Serie
    {
        //Atributos
        private string titulo = "";
        private int numTemporadas = 3;
        private bool entregado = false;
        private string genero = "";
        private string creador = "";

        public Serie()
        {

        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, string creador, int numTemporadas, string genero)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.numTemporadas = numTemporadas;
            this.genero = genero;
        }

    }
}
