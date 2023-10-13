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

        //public struct Datos
        //{
        //    public int numero;
        //}

        private void NuevoItinerarioBtn_Click(object sender, EventArgs e)
        {
            //Datos info;

            //Random numeroRandom = new Random();
            //int numeroAleatorio = numeroRandom.Next();

            //info.numero = numeroAleatorio;

            //CrearItinerario crearItinerario = new CrearItinerario(info);
            //crearItinerario.Show();

            CrearItinerario crearItinerario = new CrearItinerario();
            crearItinerario.Show();

        }

        private void BuscarItinerarioBtn_Click(object sender, EventArgs e)
        {
            ListaPrereservas buscarListaItinerarios = new ListaPrereservas();
            buscarListaItinerarios.Show();
        }
    }
}
