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

        private void ConsultaDisponibilidadCrucerosBtn_Click(object sender, EventArgs e)
        {
            CrucerosForm crucerosForm = new CrucerosForm();
            crucerosForm.Show();
        }

        private void ItinerarioBtn_Click(object sender, EventArgs e)
        {
            ArmadoItinerarioForm armadoItinerarioForm = new ArmadoItinerarioForm();
            armadoItinerarioForm.Show();
        }
    }
}
