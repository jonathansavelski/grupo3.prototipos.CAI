using grupo3.prototipos.CAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI
{
    public class ModuloItinerario
    {
        public List<Itinerario> Itinerarios;
        public Itinerario ItinerarioActual;

        ModuloItinerario() 
        {
            ItinerarioActual = new Itinerario();
        }

        public int CrearNumeroDeItinerario()
        {
            Random numeroRandom = new Random();
            int numeroDeItinerario = numeroRandom.Next();

            return numeroDeItinerario;
        }

        public Itinerario ArmarItinerario()
        {
            var itinerario = new List<Itinerario>();
            Itinerario nuevoItinerario = new Itinerario(CrearNumeroDeItinerario().ToString());
            return nuevoItinerario;
        }
        /*
        public void GuardarItinerarioEnTxT()
        {
            var contenido = JsonSerializer.Serialize<List<Itinerario>>(ItinerarioActual);
            File.AppendAllText("Presupuestos.txt", contenido);

        }
        */



    }
}
