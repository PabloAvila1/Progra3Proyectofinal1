﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyectofinal
{
    public class Gastos
    {
        string identificacion;
        string nombre;
        string tiporepart;

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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tiporepart
        {
            get
            {
                return tiporepart;
            }

            set
            {
                tiporepart = value;
            }
        }
    }
}