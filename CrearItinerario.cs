using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3.prototipos.CAI
{
    public partial class CrearItinerario : Form
    {
        public CrearItinerario()
        {
            InitializeComponent();
        }

        private void CargaDatosBtn_Click(object sender, EventArgs e)
        {
            CargaDatosViajeroForm cargaDatosViajero = new CargaDatosViajeroForm();
            cargaDatosViajero.Show();
        }

        private void ConsultaDisponibilidadVuelosBtn_Click(object sender, EventArgs e)
        {
            VuelosForm vuelosForm = new VuelosForm();
            vuelosForm.Show();
        }

        private void ConsultaDisponibilidadPaquetesBtn_Click(object sender, EventArgs e)
        {
            PaquetesForm paquetesForm = new PaquetesForm();
            paquetesForm.Show();
        }

        private void ConsultaDisponibilidadHotelesBtn_Click(object sender, EventArgs e)
        {
            HotelesForm hotelesForm = new HotelesForm();
            hotelesForm.Show();
        }

        private void AgregarPersonaBtn_Click(object sender, EventArgs e)
        {
            AgregarPersona agregarpersonaForm = new AgregarPersona();
            agregarpersonaForm.Show();
        }

        //Carga del form
        public void CrearItinerario_Load(object sender, EventArgs e)
        {
            NumeroItinerarioLabel.Text = Convert.ToString(CrearNumeroDeItinerario());
            //Estado inicial
            ValorDeLaCotizacionLabel.Text = "";
            VuelosListView.Enabled = false;
            HotelesListView.Enabled = false;
            PaquetesListView.Enabled = false;
            EliminarVueloButton.Enabled = false;
            EliminarHotelButton.Enabled = false;
            EliminarPaqueteButton.Enabled = false;
            CotizarButton.Enabled = false;
            GuardarItinerarioButton.Enabled = false;
            RealizarPrereservaButton.Enabled = false;
            RealizarReservaButton.Enabled = false;
            CargaPasajerosGroupBox.Enabled = false;
            ServiciosExtraVuelosListView.Enabled = false;
            ServiciosExtraHotelesListView.Enabled = false;
            AdicionalesPaqueteListView.Enabled = false;
        }

        //Creación de número de itinerario
        public int CrearNumeroDeItinerario()
        {
            Random numeroRandom = new Random();
            int numeroDeItinerario = numeroRandom.Next();
            return numeroDeItinerario;
        }

        //Permitir solo la entrada de números en los textbox de cantidad de pasajeros
        private void CantidadAdultosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CantidadInfantesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CantidadMenoresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RealizarReservaButton_Click(object sender, EventArgs e)
        {
            //aquí irán las validaciones de que todo esté completo
            MessageBox.Show($"Se ha realizado la reserva correctamente para el itinerario N° {NumeroItinerarioLabel.Text}.", "Reserva Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RealizarPrereservaButton_Click(object sender, EventArgs e)
        {
            //aquí irán las validaciones de que todo esté completo
            MessageBox.Show($"Se ha realizado la prereserva correctamentepara el itinerario N° {NumeroItinerarioLabel.Text}.", "Reserva Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GuardarItinerarioButton_Click(object sender, EventArgs e)
        {
            //aquí irán las validaciones de que todo esté completo
            MessageBox.Show($"Se ha guardado correctamentepara el itinerario N° {NumeroItinerarioLabel.Text}.", "Itinerario Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
