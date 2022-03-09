using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadoraEcuaciones.Estructura
{
    class Nodo
    {
        private String cadena;
        private Nodo izquierdo;
        private Nodo derecho;

        public Nodo(String cadena)
        {
            this.cadena = cadena;
        }

        public String getCadena()
        {
            return cadena;
        }

        public void setCadena(String cadena)
        {
            this.cadena = cadena;
        }

        public Nodo getIzquierdo()
        {
            return izquierdo;
        }

        public void setIzquierdo(Nodo izquierdo)
        {
            this.izquierdo = izquierdo;
        }

        public Nodo getDerecho()
        {
            return derecho;
        }

        public void setDerecho(Nodo derecho)
        {
            this.derecho = derecho;
        }

    }
}
