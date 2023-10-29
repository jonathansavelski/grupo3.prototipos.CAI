        /*
        //Carga vuelo seleccionado
        public void CargarVueloSeleccionado(VueloEnt vuelo)
        {
            //Agrego items al ListView

            var item = new ListViewItem();

            item.Text = vuelo.CodigoVuelo;
            item.SubItems.Add(vuelo.CodigoOrigenVuelo);
            item.SubItems.Add(vuelo.CodigoDestinoVuelo);
            item.SubItems.Add(vuelo.FechaSalidaVuelo.ToString());
            item.SubItems.Add(vuelo.FechaArriboVuelo.ToString());
            item.SubItems.Add(vuelo.TiempoDeVueloVuelo);
            item.SubItems.Add(vuelo.AerolineaVuelo);
            item.SubItems.Add(vuelo.TarifaVuelo[0].ClaseVuelo.ToString());
            item.SubItems.Add(vuelo.TarifaVuelo[0].TipoDePasajeroVuelo.ToString());
            item.SubItems.Add(vuelo.TarifaVuelo[0].PrecioVuelo.ToString("N2")); //separa miles y dos decimales
            item.SubItems.Add(vuelo.TarifaVuelo[0].DisponibilidadVuelo.ToString());

            //CrearItinerario crearItinerario = new CrearItinerario();

            crearItinerario.VuelosListView.Items.Add(item);
            //CotizarButton.Enabled = true;
        }*/

/*
public void InstanciarItinerario(VueloEnt vueloSeleccionado)
{
    // Verifica si ya existe una instancia de CrearItinerario
    if (CrearItinerario.Instancia == null)
    {
        // Si no existe, crea una nueva instancia
        CrearItinerario crearItinerarioForm = new CrearItinerario();
        crearItinerarioForm.Show();
    }

    // Carga el vuelo seleccionado en la instancia existente
    crearItinerario.VuelosListView.Enabled = true;
    CargarVueloSeleccionado(vueloSeleccionado);

    MessageBox.Show($"Se ha añadido correctamente al itinerario.", "Itinerario añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
}
}
*/

using grupo3.prototipos.CAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI.Archivos
{
    public class ItinerariosModel
    {
        private static List<Itinerario> itinerarios;
        private static List<VueloEnt> vuelosSeleccionados;

        private static string jsonFilePath = "itinerarios.json";

        public ItinerariosModel()
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

        public static void GuardarItinerariosEnJSON()
        {
            string json = JsonSerializer.Serialize(itinerarios);
            File.WriteAllText(jsonFilePath, json);
        }
    }
}