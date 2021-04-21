using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //atributos
        private string tipo;
        private string instrumento;
        private int aforo;


        //Propiedades
        public string Tipo
        {
            get { return tipo; } // lectura del atributo
            set { tipo = value; } //escritura del atributo

        }

        public string Instrumento
        {
            get { return instrumento; } // lectura del atributo
            set { instrumento = value; } //escritura del atributo

        }

        public int Aforo
        {
            get { return aforo; } // lectura del atributo
            set { aforo = value; } //escritura del atributo

        }

        // métodos u operaciones
        public string Investigar()
        {
            return "No se ha implementado el método Investigar";
        }
        public string Experimentar()
        {
            return "No se ha implementado el método Experimentar";
        }

        public string Analizar()
        {
            return "No se ha implementado el método Analizar";
        }
    }
}
