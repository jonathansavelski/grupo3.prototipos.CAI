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
    public partial class ListaPrereservas : Form
    {
        public ListaPrereservas()
        {
            InitializeComponent();
        }

        private void ListaPrereservas_Load(object sender, EventArgs e)
        {
            grpDetallesPrereserva.Enabled = false;
        }

        private void VerDetallesPreReservaBtn_Click(object sender, EventArgs e)
        {
            grpDetallesPrereserva.Enabled = true;
        }
    }
}
