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
    public partial class AgregarPersona : Form
    {
        public AgregarPersona()
        {
            InitializeComponent();
        }

        private void CancelarAgregarPersonaButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarPersonaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombrePersonaTextBox.Text))
            {
                MessageBox.Show("El nombre del pasajero es obligatorio");
            }

            if (string.IsNullOrEmpty(ApellidoPersonaTextBox.Text))
            {
                MessageBox.Show("El apellido del pasajero es obligatorio");
            }

            if (string.IsNullOrEmpty(DNIPersonaTextBox.Text))
            {
                MessageBox.Show("El dni del pasajero es obligatorio");
            }
        }
    }
}
