using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3.prototipos.CAI
{
    public partial class BusquedaItinerarioForm : Form
    {
        public BusquedaItinerarioForm()
        {
            InitializeComponent();
        }

        private void ListaPrereservas_Load(object sender, EventArgs e)
        {
        }

        private void VerDetallesPreReservaBtn_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarItinerario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AgregarPersonaButton_Click(object sender, EventArgs e)
        {
            AgregarPasajero agregarpersonaForm = new AgregarPasajero();
            agregarpersonaForm.Show();
        }

        private void RealizarPrereservaButton_Click(object sender, EventArgs e)
        {
            AsignacionPasajerosForm asignacionPasajerosForm = new AsignacionPasajerosForm();
            asignacionPasajerosForm.Show();
        }
    }
}
