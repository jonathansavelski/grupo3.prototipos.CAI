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
    public partial class BuscaroCrearItForm : Form
    {
        public BuscaroCrearItForm()
        {
            InitializeComponent();
        }

        private void NuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            CrearItinerario crearItinerario = new CrearItinerario();
            crearItinerario.Show();

        }

        private void BuscarItinerarioBtn_Click(object sender, EventArgs e)
        {
            BusquedaItinerarioForm buscarListaItinerarios = new BusquedaItinerarioForm();
            buscarListaItinerarios.Show();
        }
    }
}
