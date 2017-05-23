using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal
{
    public class Propiedades
    {
        string tipoprop;
        string codigoprop;
        int mts2;
        string identificacion;
        string Listgastos;

        public string Tipoprop
        {
            get
            {
                return tipoprop;
            }

            set
            {
                tipoprop = value;
            }
        }

        public string Codigoprop
        {
            get
            {
                return codigoprop;
            }

            set
            {
                codigoprop = value;
            }
        }

        public int Mts2
        {
            get
            {
                return mts2;
            }

            set
            {
                mts2 = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Listgastos1
        {
            get
            {
                return Listgastos;
            }

            set
            {
                Listgastos = value;
            }
        }
    }
}