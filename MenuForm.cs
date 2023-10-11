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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            CargaDatosViajeroForm cargaDatosViajero = new CargaDatosViajeroForm();
            cargaDatosViajero.Show();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            VuelosForm vuelosForm = new VuelosForm();
            vuelosForm.Show();
        }

        private void btnMenu5_Click(object sender, EventArgs e)
        {
            PaquetesForm paquetesForm = new PaquetesForm();
            paquetesForm.Show();
        }
    }
}
