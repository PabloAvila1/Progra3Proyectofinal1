using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal
{
    public class Local: Propiedades
    {
        string nombrecomer;
        string actividad;

        public string Nombrecomer
        {
            get
            {
                return nombrecomer;
            }

            set
            {
                nombrecomer = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}