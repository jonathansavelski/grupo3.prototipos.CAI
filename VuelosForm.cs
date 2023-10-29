using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text.Unicode;
using grupo3.prototipos.CAI.Archivos;
using grupo3.prototipos.CAI.Entidades;
using grupo3.prototipos.CAI.Models;

namespace grupo3.prototipos.CAI
{
    public partial class VuelosForm : Form
    {
        VuelosModel modeloVuelos;
        ItinerariosModel modeloItinerarios;

        public VuelosForm()
        {
            InitializeComponent();
        }

        private void VuelosForm_Load(object sender, EventArgs e)
        {

            modeloVuelos = new VuelosModel();
            VuelosDisponiblesGroupBox.Enabled = false;
        }

        private void AplicarFiltrosButton_Click(object sender, EventArgs e)
        {
            string ciudadOrigenVuelo = CiudadOrigenVueloTextBox.Text;
            string ciudadDestinoVuelo = CiudadDestinoVueloTextBox.Text;
            DateTime fechaDesde = RangoDesdeVueloDateTimePicker.Value.Date;
            DateTime fechaHasta = RangoHastaVueloDateTimePicker.Value.Date;
            string tipoPasajero = TipoPasajeroVueloComboBox.Text;

            string errores = "";

            errores += modeloVuelos.ValidarVacio(ciudadOrigenVuelo, "Lugar de origen");
            errores += modeloVuelos.ValidarVacio(ciudadDestinoVuelo, "Lugar de destino");
            errores += modeloVuelos.ValidarFechaDesde(fechaDesde);
            errores += modeloVuelos.ValidarFechaHasta(fechaDesde, fechaHasta);
            errores += modeloVuelos.ValidarVacio(tipoPasajero, "Tipo de pasajero");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VuelosDisponiblesGroupBox.Enabled = true;
                AñadirAlItinerarioVueloButton.Enabled = false;

                VuelosListView.Items.Clear();
                modeloVuelos.BuscarVuelos(ciudadOrigenVuelo, ciudadDestinoVuelo, fechaDesde, fechaHasta, tipoPasajero, VuelosListView);
            }

        }

        private void VuelosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cuando se selecciona un item del List View
            AñadirAlItinerarioVueloButton.Enabled = true;
        }

        private void AñadirAlItinerarioVueloButton_Click(object sender, EventArgs e)
        {
            if (VuelosListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = VuelosListView.SelectedItems[0];

                // Recuperar los datos del vuelo del ListView
                string codigoVuelo = selectedItem.SubItems[0].Text;
                string origen = selectedItem.SubItems[1].Text;
                string destino = selectedItem.SubItems[2].Text;
                DateTime fechaSalida = DateTime.ParseExact(selectedItem.SubItems[3].Text, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime fechaArribo = DateTime.ParseExact(selectedItem.SubItems[4].Text, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
                string tiempo = selectedItem.SubItems[5].Text;
                string aerolinea = selectedItem.SubItems[6].Text;
                char clase = char.Parse(selectedItem.SubItems[7].Text);
                char tipoDePasajero = char.Parse(selectedItem.SubItems[8].Text);
                float precio = Convert.ToSingle(selectedItem.SubItems[9].Text);
                int disponibilidad = Convert.ToInt32(selectedItem.SubItems[10].Text);

                // Crear el objeto Vuelo
                VueloEnt vueloSeleccionado = new VueloEnt
                {
                    CodigoVuelo = codigoVuelo,
                    CodigoOrigenVuelo = origen,
                    CodigoDestinoVuelo = destino,
                    FechaSalidaVuelo = fechaSalida,
                    FechaArriboVuelo = fechaArribo,
                    TiempoDeVueloVuelo = tiempo,
                    AerolineaVuelo = aerolinea,
                    TarifaVuelo = new List<TarifaVuelo>
                    {
                        new TarifaVuelo
                        {
                            ClaseVuelo = clase,
                            TipoDePasajeroVuelo = tipoDePasajero,
                            PrecioVuelo = precio,
                            DisponibilidadVuelo = disponibilidad
                        }
                    }
                };
                
                // Verifica si ya existe una instancia de CrearItinerario
                if (CrearItinerario.Instancia == null)
                {
                    // Si no existe, crea una nueva instancia
                    CrearItinerario crearItinerarioForm = new CrearItinerario();
                    crearItinerarioForm.Show();
                }

                // Carga el vuelo seleccionado en la instancia existente
                CrearItinerario.Instancia.VueloSeleccionado = vueloSeleccionado;
                CrearItinerario.Instancia.VuelosListView.Enabled = true;
                CrearItinerario.Instancia.CargarVueloSeleccionado(vueloSeleccionado);

                MessageBox.Show($"Se ha añadido correctamente al itinerario.", "Itinerario añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }
    }
}