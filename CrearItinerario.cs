using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using grupo3.prototipos.CAI.Archivos;
using grupo3.prototipos.CAI.Entidades;

namespace grupo3.prototipos.CAI
{
    public partial class CrearItinerario : Form
    {
        private ArchivoItinerarios archivoItinerarios;
        public VueloEnt VueloSeleccionado { get; set; }
        public static CrearItinerario Instancia { get; private set; }

        public CrearItinerario()
        {
            InitializeComponent();

            archivoItinerarios = new ArchivoItinerarios();

            Instancia = this; // Creo la instancia
        }

        private void ConsultaDisponibilidadVuelosBtn_Click(object sender, EventArgs e)
        {
            VuelosForm vuelosForm = new VuelosForm();
            vuelosForm.Show();
        }

        private void ConsultaDisponibilidadHotelesBtn_Click(object sender, EventArgs e)
        {
            HotelesForm hotelesForm = new HotelesForm();
            hotelesForm.Show();
        }



        //Carga del form
        public void CrearItinerario_Load(object sender, EventArgs e)
        {
            Itinerario nuevoItinerario = archivoItinerarios.GenerarItinerarioUnico();

            NumeroItinerarioLabel.Text = Convert.ToString(nuevoItinerario.NumeroItinerario);

            ValorDeLaCotizacionLabel.Text = "";
            VuelosListView.Enabled = false;
            HotelesListView.Enabled = false;
            EliminarVueloButton.Enabled = false;
            EliminarHotelButton.Enabled = false;
            CotizarButton.Enabled = false;
            //CargaPasajerosGroupBox.Enabled = false;

            //int numeroDeItinerario = CrearNumeroDeItinerario();
        }

        //Carga vuelo seleccionado
        public void CargarVueloSeleccionado(VueloEnt vuelo)
        {
            //Agrego items al ListView
            //vuelo = VueloSeleccionado;

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

            VuelosListView.Items.Add(item);
            CotizarButton.Enabled = true;
        }

        private void MenuPrincipalButton_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void CargarPasajeroVueloButton_Click(object sender, EventArgs e)
        {
            AsignacionPasajerosVuelosForm asignacionPasajerosVuelosForm = new AsignacionPasajerosVuelosForm();
            asignacionPasajerosVuelosForm.Show();
        }

        private void CargarPasajeroHotelButton_Click(object sender, EventArgs e)
        {
            AsignacionPasajerosHotelesForm asignacionPasajerosHotelesForm = new AsignacionPasajerosHotelesForm();
            asignacionPasajerosHotelesForm.Show();
        }

        private void VuelosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarVueloButton.Enabled = true;
        }

        private void CopiarNumeroItinerario_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NumeroItinerarioLabel.Text);
            MessageBox.Show("Número de itinerario copiado", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EliminarVueloButton_Click(object sender, EventArgs e)
        {
            VuelosListView.Items.Remove(VuelosListView.SelectedItems[0]);
            MessageBox.Show("Se ha eliminado el vuelo seleccionado.", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EliminarVueloButton.Enabled = false;
            EsconderCotizarButton();
        }

        private void EsconderCotizarButton()
        {
            if (VuelosListView.Items.Count == 0 && HotelesListView.Items.Count == 0)
            {
                CotizarButton.Enabled = false;
            }
        }

        private void CotizarButton_Click(object sender, EventArgs e)
        {
            double suma = 0;

            // Itera a través de los elementos del ListView y suma los precios
            foreach (ListViewItem item in VuelosListView.Items)
            {
                // Convierte el valor del subítem a double y suma
                if (double.TryParse(item.SubItems[9].Text, out double valor))
                {
                    suma += valor;
                }
            }

            ValorDeLaCotizacionLabel.Text = "El valor de la cotización es de $" + suma.ToString("N2");
        }
    }
}
