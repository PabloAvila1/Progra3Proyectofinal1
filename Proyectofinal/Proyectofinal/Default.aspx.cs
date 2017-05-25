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

        public void archivos(bool comuni, bool gast)
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
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}