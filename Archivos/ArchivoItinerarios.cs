using grupo3.prototipos.CAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI.Archivos
{
    public class ArchivoItinerarios
    {
        public List<Itinerario> itinerarios;
        public string jsonFilePath = "C:\\Users\\Jonathan\\Desktop\\UBA\\Ciclo Profesional\\2023\\Construcción de Aplicaciones Informáticas\\itinerarios.json";

        public ArchivoItinerarios()
        {
            itinerarios = new List<Itinerario>();
            CargarItinerariosDesdeJSON();
        }

        public Itinerario GenerarItinerarioUnico()
        {
            Random random = new Random();
            string numeroItinerario;

            do
            {
                numeroItinerario = random.Next(00000000, 99999999).ToString(); // Generar un número aleatorio de 8 dígitos.
            } while (itinerarios.Any(i => i.NumeroItinerario == numeroItinerario));

            var nuevoItinerario = new Itinerario
            {
                NumeroItinerario = numeroItinerario,
                FechaCreacionItinerario = DateTime.Now
            };

            itinerarios.Add(nuevoItinerario);
            GuardarItinerariosEnJSON();

            return nuevoItinerario;
        }

        private void CargarItinerariosDesdeJSON()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                itinerarios = JsonSerializer.Deserialize<List<Itinerario>>(json);
            }
        }

        private void GuardarItinerariosEnJSON()
        {
            string json = JsonSerializer.Serialize(itinerarios);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}
