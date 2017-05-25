using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal
{
    public class Gastostotales
    {
        string identificaciongasto;
        string descripcion;
        int importe;
        string zonareparto;

        public string Identificaciongasto
        {
            get
            {
                return identificaciongasto;
            }

            set
            {
                identificaciongasto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Zonareparto
        {
            get
            {
                return zonareparto;
            }

            set
            {
                zonareparto = value;
            }
        }
    }
}