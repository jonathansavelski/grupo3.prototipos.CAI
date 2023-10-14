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
    public partial class HotelesForm : Form
    {
        public HotelesForm()
        {
            InitializeComponent();
        }

        private void HotelesForm_Load(object sender, EventArgs e)
        {
            grpHotel.Enabled = false;
            MasInformacionHotelesGrp.Enabled = false;

        }

        private void InformacionHotelesButton_Click(object sender, EventArgs e)
        {
            if (listViewHoteles.SelectedItems.Count == 1)
            {

            }
        }

        private void AplicarFiltrosHotelButton_Click(object sender, EventArgs e)
        {
            grpHotel.Enabled = true;
        }
    }
}
