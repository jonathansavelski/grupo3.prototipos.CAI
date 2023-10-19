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
    public partial class AsignacionPasajerosVuelosForm : Form
    {
        public AsignacionPasajerosVuelosForm()
        {
            InitializeComponent();
        }

        private void AgregarPasajeroButton_Click(object sender, EventArgs e)
        {
            AgregarPasajero agregarPasajero = new AgregarPasajero();
            agregarPasajero.Show();
        }
    }
}
