using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;

namespace Proyectofinal
{
    public partial class _Default : Page
    {
        List<Comunidad> listacomunidad = new List<Comunidad>();
        List<Propietarios> listapropietarios = new List<Propietarios>();
        List<Propiedades> listapropiedades = new List<Propiedades>();
        List<Gastos> listagastos = new List<Gastos>();
        List<Gastostotales> listagastostot = new List<Gastostotales>();
        List<Pisos> listapisos = new List<Pisos>();
        List<Local> listalocales = new List<Local>();
        List<Garages> listagarages = new List<Garages>();

        public void archivos(bool comuni, bool gast, bool propietario, bool gastostot, bool propiedadess)
        {
            if(comuni == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyectofinal.Comunidad.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyectofinal.Comunidad.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    Comunidad comunitemp = new Comunidad();
                    comunitemp.Identificacion = _textStreamReader.ReadLine();
                    comunitemp.Nombre = _textStreamReader.ReadLine();
                    comunitemp.Poblacion = _textStreamReader.ReadLine();
                    listacomunidad.Add(comunitemp);
                }
                _textStreamReader.Close();
            }
            if (gast == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyectofinal.Gastos.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyectofinal.Gastos.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    Gastos gasttemp = new Gastos();
                    gasttemp.Identificacion = _textStreamReader.ReadLine();
                    gasttemp.Nombre = _textStreamReader.ReadLine();
                    gasttemp.Tiporepart = _textStreamReader.ReadLine();
                    listagastos.Add(gasttemp);
                }
                _textStreamReader.Close();
            }
            if (propietario == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyectofinal.Propietarios.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyectofinal.Propietarios.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    Propietarios propitemp = new Propietarios();
                    propitemp.Nombre = _textStreamReader.ReadLine();
                    propitemp.Identificacion = _textStreamReader.ReadLine();
                    propitemp.Email = _textStreamReader.ReadLine();
                    listapropietarios.Add(propitemp);
                }
                _textStreamReader.Close();
            }
            if (gastostot == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyectofinal.GastosTotales.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyectofinal.GastosTotales.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    Gastostotales gastostottemp = new Gastostotales();
                    gastostottemp.Identificaciongasto = _textStreamReader.ReadLine();
                    gastostottemp.Descripcion = _textStreamReader.ReadLine();
                    gastostottemp.Importe = Convert.ToInt32(_textStreamReader.ReadLine());
                    gastostottemp.Zonareparto = _textStreamReader.ReadLine();
                    listagastostot.Add(gastostottemp);
                }
                _textStreamReader.Close();
            }
            if (propiedadess == true)
            {
                Assembly _assembly; Stream _imageStream;
                StreamReader _textStreamReader;
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("Proyectofinal.Propiedades.bmp");
                _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Proyectofinal.Propiedades.txt"));

                while (_textStreamReader.Peek() > -1)
                {
                    if(_textStreamReader.ReadLine()=="L")
                    {
                        Local localtemp = new Local();
                        localtemp.Tipoprop = _textStreamReader.ReadLine();
                        localtemp.Codigoprop = _textStreamReader.ReadLine();
                        localtemp.Mts2 = Convert.ToInt32(_textStreamReader.ReadLine());
                        localtemp.Identificacion = _textStreamReader.ReadLine();
                        localtemp.Listaporcent = _textStreamReader.ReadLine();
                        localtemp.Nombrecomer = _textStreamReader.ReadLine();
                        localtemp.Actividad = _textStreamReader.ReadLine();
                    }
                    if (_textStreamReader.ReadLine() == "G")
                    {
                        Garages garagetemp = new Garages();
                        garagetemp.Tipoprop = _textStreamReader.ReadLine();
                        garagetemp.Codigoprop = _textStreamReader.ReadLine();
                        garagetemp.Mts2 = Convert.ToInt32(_textStreamReader.ReadLine());
                        garagetemp.Identificacion = _textStreamReader.ReadLine();
                        garagetemp.Listaporcent = _textStreamReader.ReadLine();
                        garagetemp.Abierta = _textStreamReader.ReadLine();
                        garagetemp.Bodega = _textStreamReader.ReadLine();

                    }
                    if (_textStreamReader.ReadLine() == "P")
                    {
                        Pisos pisostemp = new Pisos();
                        pisostemp.Tipoprop = _textStreamReader.ReadLine();
                        pisostemp.Codigoprop = _textStreamReader.ReadLine();
                        pisostemp.Mts2 = Convert.ToInt32(_textStreamReader.ReadLine());
                        pisostemp.Identificacion = _textStreamReader.ReadLine();
                        pisostemp.Listaporcent = _textStreamReader.ReadLine();
                        pisostemp.Vhvn = _textStreamReader.ReadLine();
                        pisostemp.Habitaciones = _textStreamReader.ReadLine();

                    }


                    //          gastostottemp.Identificaciongasto = _textStreamReader.ReadLine();
                    //          gastostottemp.Descripcion = _textStreamReader.ReadLine();
                    //          gastostottemp.Importe = Convert.ToInt32(_textStreamReader.ReadLine());
                    //          gastostottemp.Zonareparto = _textStreamReader.ReadLine();
                    //          listagastostot.Add(gastostottemp);
                }
                _textStreamReader.Close();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}