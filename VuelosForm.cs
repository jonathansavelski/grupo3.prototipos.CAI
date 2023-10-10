using System.Reflection;

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

            MasInformacionGrp.Enabled = false;
            foreach (var vuelo in modeloVuelos.Vuelos)
            {
                //Agregamos cada vuelo a una lista
                var item = new ListViewItem();
                item.Text = vuelo.CodigoVuelo; // = item.Subitems[0].Text Implicitamente agrega el subitem 0 // item.Text es lo que va en la primer columna. En nuestro caso, es el codigo de vuelo.
                item.SubItems.Add(vuelo.OrigenVuelo); //implicitamente estoy agregando el subitem 1, no el 0.
                item.SubItems.Add(vuelo.DestinoVuelo);
                item.SubItems.Add(vuelo.FechaSalidaVuelo.ToString());
                item.SubItems.Add(vuelo.FechaArriboVuelo.ToString());
                item.SubItems.Add(vuelo.TiempoDeVueloVuelo);
                item.SubItems.Add(vuelo.AerolineaVuelo);
                item.Tag = vuelo; // Tag = etiqueta. La propiedad Tag es de tipo object. En esta propiedad puedo guardar lo que quiera. Esto sirve para que podamos meter un dato en cada fila (que no se ve) y me sirve para identificarla en el resto del sistema. 

                VuelosListView.Items.Add(item); //Llenamos la grilla
            }

        }

        private void InformacionVueloButton_Click(object sender, EventArgs e)
        {
            if (VuelosListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un vuelo de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Vuelo vueloSeleccionado = (Vuelo)VuelosListView.SelectedItems[0].Tag; //El vuelo seleccionado lo guardé en el tag

            MasInformacionGrp.Enabled = true;
        }

        private void AplicarFiltrosButton_Click(object sender, EventArgs e)
        {

        }


    }
}