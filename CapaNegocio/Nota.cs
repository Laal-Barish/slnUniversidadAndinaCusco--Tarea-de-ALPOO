using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Nota
    {

        //atributos
        private string nivel;
        private int calificación;
        private string instrumento;
        // propiedades
        public string Nivel
        {
            get { return nivel; } // lectura del atributo
            set { nivel = value; } //escritura del atributo

        }

        public int Calificación
        {
            get { return calificación; } // lectura del atributo
            set { calificación = value; } //escritura del atributo
        }

        public string Instrumento
        {
            get { return instrumento; } // lectura del atributo
            set { instrumento = value; } //escritura del atributo
        }

        // métodos u operaciones
        public string Aprobar()
        {
            return "No se ha implementado el método Aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el método Desaprobar";
        }

    }
}
