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
    public partial class CrearItinerario : Form
    {
        public CrearItinerario(BuscaroCrearItForm.Datos info)
        {
            InitializeComponent();
            txtNumeroItinerario.Text = Convert.ToString(info.numero);
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
    }
}
