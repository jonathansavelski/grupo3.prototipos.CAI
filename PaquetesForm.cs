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
    public partial class PaquetesForm : Form
    {
        public PaquetesForm()
        {
            InitializeComponent();
        }

        private void PaquetesForm_Load(object sender, EventArgs e)
        {
            grpPaquete.Enabled = false;
            grpMasInformacionPaquete.Enabled = false;
            btnMasInfoPaquete.Enabled = false;
        }

        private void btnMasInfoPaquete_Click(object sender, EventArgs e)
        {
            if (lvPaquetes.SelectedItems.Count == 1)
            {
                grpMasInformacionPaquete.Enabled = true;
            }
        }

        private void AplicarFiltrosPaqueteButton_Click(object sender, EventArgs e)
        {
            grpPaquete.Enabled = true;
        }
    }
}
