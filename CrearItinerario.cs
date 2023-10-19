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
            NumeroItinerarioLabel.Text = Convert.ToString(CrearNumeroDeItinerario());
            //Estado inicial
            ValorDeLaCotizacionLabel.Text = "";
            VuelosListView.Enabled = false;
            HotelesListView.Enabled = false;
            EliminarVueloButton.Enabled = false;
            EliminarHotelButton.Enabled = false;
            CotizarButton.Enabled = false;
            //CargaPasajerosGroupBox.Enabled = false;
            ServiciosExtraVuelosListView.Enabled = false;
            ServiciosExtraHotelesListView.Enabled = false;
        }

        //Creación de número de itinerario
        public int CrearNumeroDeItinerario()
        {
            Random numeroRandom = new Random();
            int numeroDeItinerario = numeroRandom.Next();
            return numeroDeItinerario;
        }

        private void AgregarServicioExtraVueloButton_Click(object sender, EventArgs e)
        {
            ServiciosExtraVuelosForm serviciosExtraVuelosForm = new ServiciosExtraVuelosForm();
            serviciosExtraVuelosForm.Show();
        }

        private void AgregarServicioExtraHotelButton_Click(object sender, EventArgs e)
        {
            ServiciosExtraHotelesForm serviciosExtraHotelesForm = new ServiciosExtraHotelesForm();
            serviciosExtraHotelesForm.Show();
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
    }
}
