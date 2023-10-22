using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI
{
    internal class ArchivoVuelos
    {
        public List<Vuelo> VuelosDisponibles = new List<Vuelo>();

        public ArchivoVuelos()
        {
            string path = "C:\\Users\\Jonathan\\Desktop\\UBA\\Ciclo Profesional\\2023\\Construcción de Aplicaciones Informáticas\\Listado de Vuelos.txt"; // Ruta del archivo CSV
            FileInfo fi = new FileInfo(path);


            try
            {
                StreamReader sr = fi.OpenText();
                    
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');
                    
                    Vuelo v = new Vuelo();

                    v.CodigoVuelo = vector[0];
                    v.CodigoOrigenVuelo = vector[1];
                    v.CiudadOrigenVuelo = vector[2];
                    v.CodigoDestinoVuelo = vector[3];
                    v.CiudadDestinoVuelo = vector[4];
                    v.FechaSalidaVuelo = Convert.ToDateTime(vector[5]);
                    v.FechaArriboVuelo = Convert.ToDateTime(vector[6]);
                    v.TiempoDeVueloVuelo = vector[7];
                    v.AerolineaVuelo = vector[8];
                    v.ClaseVuelo = Convert.ToChar(vector[9]);
                    v.ItinerarioVuelo = vector[10];
                    v.TipoDePasajeroVuelo = Convert.ToChar(vector[11]);
                    v.CodigoMonedaVuelo = vector[12];
                    v.BaseVuelo = Convert.ToSingle(vector[13]);
                    v.ImpuestosVuelo = Convert.ToSingle(vector[14]);
                    v.ComisionVuelo = Convert.ToSingle(vector[15]);
                    v.DisponibilidadVuelo = Convert.ToInt32(vector[16]);

                    VuelosDisponibles.Add(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }
    }
}
