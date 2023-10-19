using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace grupo3.prototipos.CAI
{
    public partial class VuelosForm : Form
    {
        VuelosModel modeloVuelos;

        public VuelosForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modeloVuelos = new VuelosModel();

            InformacionAdicionalVuelosGroupBox.Enabled = false;
            VuelosDisponiblesGroupBox.Enabled = false;
        }

        private void InformacionVueloButton_Click(object sender, EventArgs e)
        {
            Vuelo vueloSeleccionado = (Vuelo)VuelosListView.SelectedItems[0].Tag; //El vuelo seleccionado lo guardé en el tag

            InformacionAdicionalVuelosGroupBox.Enabled = true;

            //Datos de ejemplo
            ListViewItem parada = new ListViewItem("Santiago de Chile");
            parada.SubItems.Add("2:30hs");

            ParadasVueloListView.Items.Add(parada);

            ListViewItem servicioExtra = new ListViewItem("03817");
            servicioExtra.SubItems.Add("Cena premium");
            servicioExtra.SubItems.Add("4000");

            //ServiciosExtraListView.Items.Add(servicioExtra);
        }

        private void AplicarFiltrosButton_Click(object sender, EventArgs e)
        {
            VuelosDisponiblesGroupBox.Enabled = true;
            VerMasInformacionVueloButton.Enabled = false;
            AñadirAlItinerarioVueloButton.Enabled = false;

            foreach (var vuelo in modeloVuelos.Vuelos)
            {
                //Agregamos cada vuelo a una lista
                var item = new ListViewItem();
                item.Text = vuelo.CodigoVuelo; // = item.Subitems[0].Text Implicitamente agrega el subitem 0 // item.Text es lo que va en la primer columna. En nuestro caso, es el codigo de vuelo.
                item.SubItems.Add(vuelo.CodigoOrigenVuelo); //implicitamente estoy agregando el subitem 1, no el 0.
                item.SubItems.Add(vuelo.CodigoDestinoVuelo);
                item.SubItems.Add(vuelo.FechaSalidaVuelo.ToString());
                item.SubItems.Add(vuelo.FechaArriboVuelo.ToString());
                item.SubItems.Add(vuelo.TiempoDeVueloVuelo);
                item.SubItems.Add(vuelo.AerolineaVuelo);
                item.SubItems.Add(vuelo.ClaseVuelo.ToString());
                item.SubItems.Add(vuelo.ItinerarioVuelo);
                item.SubItems.Add(vuelo.TipoDePasajeroVuelo.ToString());
                item.SubItems.Add(vuelo.BaseVuelo.ToString());
                item.SubItems.Add(vuelo.ImpuestosVuelo.ToString());
                item.SubItems.Add(vuelo.ComisionVuelo.ToString());
                item.SubItems.Add(vuelo.DisponibilidadVuelo.ToString());
                item.Tag = vuelo; // Tag = etiqueta. La propiedad Tag es de tipo object. En esta propiedad puedo guardar lo que quiera. Esto sirve para que podamos meter un dato en cada fila (que no se ve) y me sirve para identificarla en el resto del sistema. 

                VuelosListView.Items.Add(item); //Llenamos la grilla
            }
        }

        //Cuando se selecciona un item del List View
        private void VuelosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerMasInformacionVueloButton.Enabled = true;
            AñadirAlItinerarioVueloButton.Enabled = true;
        }

        private void AñadirAlItinerarioVueloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se ha añadido correctamente al itinerario.", "Itinerario añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ServiciosExtraListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AñadirServicioExtraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El servicio extra se ha añadido correctamente al itinerario.", "Servicio extra añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}