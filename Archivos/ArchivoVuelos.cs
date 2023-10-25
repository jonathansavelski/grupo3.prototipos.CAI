using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using grupo3.prototipos.CAI.Entidades;

namespace grupo3.prototipos.CAI.Archivos
{
    internal class ArchivoVuelos
    {
        public List<Vuelo> VuelosDisponibles = new List<Vuelo>();

        public ArchivoVuelos()
        {
            string path = "C:\\Users\\Jonathan\\Desktop\\UBA\\Ciclo Profesional\\2023\\Construcción de Aplicaciones Informáticas\\vuelos.json"; // Ruta del archivo

            string contenidoDelArchivo = File.ReadAllText(path);

            //esta linea convierte el texto

            VuelosDisponibles = JsonSerializer.Deserialize<List<Vuelo>>(contenidoDelArchivo);
        }

        public List<Vuelo> ObtenerTodas()
        {
            return VuelosDisponibles.ToList();
        }
    }
}
