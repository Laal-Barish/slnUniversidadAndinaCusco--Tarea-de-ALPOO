using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //atributos
        private string nombre;
        private string aula;
        private int horas;

        // propiedades
        public string Nombre
        {
            get { return nombre; } // lectura del atributo
            set { nombre = value; } //escritura del atributo

        }

        public string Aula
        {
            get { return aula; } // lectura del atributo
            set { aula = value; } //escritura del atributo

        }

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        // métodos u operaciones
        public string Exponer()
        {
            return "No se ha implementado el método Exponer";
        }
        public string Debatir()
        {
            return "No se ha implementado el método Debatir";
        }

        public string Investigar()
        {
            return "No se ha implementado el método Investigar";
        }

        public string Estudiar()
        {
            return "No se ha implementado el método Estudiar";
        }
    }
}
