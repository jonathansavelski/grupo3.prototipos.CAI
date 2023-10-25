using System.Collections.Generic;
using System.Diagnostics;
using grupo3.prototipos.CAI.Archivos;
using grupo3.prototipos.CAI.Entidades;

namespace grupo3.prototipos.CAI
{
    public partial class VuelosForm : Form
    {
        //VuelosModel modeloVuelos;
        ArchivoVuelos archivoVuelos;


        public VuelosForm()
        {
            InitializeComponent();
        }

        public List<Vuelo> VuelosDisponibles;

        private void Form1_Load(object sender, EventArgs e)
        {
            //modeloVuelos = new VuelosModel();
            archivoVuelos = new ArchivoVuelos();

            InformacionAdicionalVuelosGroupBox.Enabled = false;
            VuelosDisponiblesGroupBox.Enabled = false;
        }

        private void AplicarFiltrosButton_Click(object sender, EventArgs e)
        {
            string ciudadOrigenVuelo = CiudadOrigenVueloTextBox.Text;
            string ciudadDestinoVuelo = CiudadDestinoVueloTextBox.Text;
            DateTime fechaDesde = RangoDesdeVueloDateTimePicker.Value.Date;
            DateTime fechaHasta = RangoHastaVueloDateTimePicker.Value.Date;
            string tipoPasajero = TipoPasajeroVueloComboBox.Text;

            string errores = "";

            errores += ValidarVacio(ciudadOrigenVuelo, "Lugar de origen");
            errores += ValidarVacio(ciudadDestinoVuelo, "Lugar de destino");
            errores += ValidarFechaDesde(fechaDesde);
            errores += ValidarFechaHasta(fechaDesde, fechaHasta);
            errores += ValidarVacio(tipoPasajero, "Tipo de pasajero");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VuelosDisponiblesGroupBox.Enabled = true;
                VerMasInformacionVueloButton.Enabled = false;
                AñadirAlItinerarioVueloButton.Enabled = false;

                VuelosListView.Items.Clear();
                BuscarVuelos(ciudadOrigenVuelo, ciudadDestinoVuelo, fechaDesde, fechaHasta, tipoPasajero);
            }

        }

        private void InformacionVueloButton_Click(object sender, EventArgs e)
        {
            Vuelo vueloSeleccionado = (Vuelo)VuelosListView.SelectedItems[0].Tag; //El vuelo seleccionado lo guardé en el tag

            InformacionAdicionalVuelosGroupBox.Enabled = true;

            /*
            List <Vuelo> DatosVueloSeleccionado = VuelosDisponibles.FindAll(vuelo => (vuelo.CodigoVuelo == vueloSeleccionado.CodigoVuelo));

            foreach (var vuelo in DatosVueloSeleccionado)
            {
                for (int i = 0; i < vuelo.ParadasVuelo.Count; i++)
                {
                    var paradas = new ListViewItem();
                    paradas.Text = vuelo.ParadasVuelo[i].NombreAeropuertoParadaVuelo;
                    paradas.SubItems.Add(vuelo.ParadasVuelo[i].TiempoDeParadaVuelo);
                    ParadasVueloListView.Items.Add(paradas);
                }
            }
            */
            //Datos de ejemplo
            /*
            ListViewItem parada = new ListViewItem("Santiago de Chile");
            parada.SubItems.Add("2:30hs");

            ParadasVueloListView.Items.Add(parada);

            ListViewItem servicioExtra = new ListViewItem("03817");
            servicioExtra.SubItems.Add("Cena premium");
            servicioExtra.SubItems.Add("4000");
            */
            //ServiciosExtraListView.Items.Add(servicioExtra);
        }

        public void BuscarVuelos(string ciudadOrigen, string ciudadDestino, DateTime fechaDesde, DateTime fechaHasta, string tipoPasajero)
        {
            //Declaro la lista de vuelos disponibles
            VuelosDisponibles = archivoVuelos.VuelosDisponibles;
            char TipoPasajeroChar;

            if (tipoPasajero.Equals("Adulto"))
            {
                TipoPasajeroChar = 'A';
            }
            else if (tipoPasajero.Equals("Menor"))
            {
                TipoPasajeroChar = 'M';
            }
            else
            {
                TipoPasajeroChar = 'I';
            }

            //Filtro
            List<Vuelo> VuelosEncontrados = VuelosDisponibles.FindAll(vuelo => (vuelo.CiudadOrigenVuelo == ciudadOrigen
                && vuelo.CiudadDestinoVuelo == ciudadDestino
                && (vuelo.FechaSalidaVuelo > fechaDesde && vuelo.FechaSalidaVuelo < fechaHasta))); //&& vuelo.TarifaVuelo[].TipoDePasajeroVuelo.ToString() == TipoPasajeroChar.ToString()

            if (VuelosEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontraron vuelos con los filtros aplicados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (var vuelo in VuelosEncontrados)
                {
                    for (int i = 0; i < vuelo.TarifaVuelo.Count; i++)
                    {
                        if (vuelo.TarifaVuelo[i].TipoDePasajeroVuelo.ToString() == TipoPasajeroChar.ToString())
                        {
                            //Agrego cada vuelo a una lista
                            var item = new ListViewItem();
                            item.Text = vuelo.CodigoVuelo;
                            item.SubItems.Add(vuelo.CodigoOrigenVuelo); //implicitamente estoy agregando el subitem 1, no el 0.
                            item.SubItems.Add(vuelo.CodigoDestinoVuelo);
                            item.SubItems.Add(vuelo.FechaSalidaVuelo.ToString());
                            item.SubItems.Add(vuelo.FechaArriboVuelo.ToString());
                            item.SubItems.Add(vuelo.TiempoDeVueloVuelo);
                            item.SubItems.Add(vuelo.AerolineaVuelo);

                            item.SubItems.Add(vuelo.TarifaVuelo[i].ClaseVuelo.ToString());
                            item.SubItems.Add(vuelo.TarifaVuelo[i].ItinerarioVuelo);
                            item.SubItems.Add(vuelo.TarifaVuelo[i].TipoDePasajeroVuelo.ToString());
                            item.SubItems.Add(vuelo.TarifaVuelo[i].CodigoMonedaVuelo);
                            item.SubItems.Add(vuelo.TarifaVuelo[i].BaseVuelo.ToString("0.00") + " " + vuelo.TarifaVuelo[i].CodigoMonedaVuelo);
                            item.SubItems.Add(vuelo.TarifaVuelo[i].ImpuestosVuelo.ToString("0.00") + " " + vuelo.TarifaVuelo[i].CodigoMonedaVuelo);
                            item.SubItems.Add(vuelo.TarifaVuelo[i].ComisionVuelo.ToString("0.0000") + "%");
                            item.SubItems.Add(vuelo.TarifaVuelo[i].DisponibilidadVuelo.ToString());
                            item.Tag = vuelo; // Tag = etiqueta. La propiedad Tag es de tipo object. En esta propiedad puedo guardar lo que quiera. Esto sirve para que podamos meter un dato en cada fila (que no se ve) y me sirve para identificarla en el resto del sistema. 

                            VuelosListView.Items.Add(item);
                        }
                    }
                }
            }
        }


        //Validaciones
        public string ValidarVacio(string valor, string campo)
        {
            string error = "";

            if (string.IsNullOrEmpty(valor))
            {
                error = "El campo " + campo + " no puede estar vacío." + "\n";
            }
            return error;
        }


        public string ValidarFechaDesde(DateTime fecha)
        {
            string error = "";

            if (fecha < DateTime.Now.Date)
            {
                error = "La fecha no debe ser anterior a hoy." + "\n";
            }
            return error;
        }

        public string ValidarFechaHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            string error = "";

            if (fechaHasta < fechaDesde)
            {
                error = "El rango de fechas es incorrecto." + "\n";
            }
            return error;
        }

        /*
        public void CargaVuelos()
        {
            string path = "C:\\Users\\Jonathan\\Desktop\\UBA\\Ciclo Profesional\\2023\\Construcción de Aplicaciones Informáticas\\Listado de Vuelos.txt";

            FileInfo fi = new FileInfo(path);

            if (!fi.Exists)
            {
                MessageBox.Show("No se encontraron vuelos.");
            }
            else
            {
                StreamReader sr = fi.OpenText();

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');

                    Vuelo v = new Vuelo();

                    v.CodigoVuelo = vector[0];
                    v.CodigoOrigenVuelo = vector[1];
                    v.CiudadOrigenVuelo = vector[2];
                    v.CodigoDestinoVuelo = vector[3];
                    v.CiudadDestinoVuelo = vector[4];
                    v.FechaSalidaVuelo = Convert.ToDateTime(vector[5]);
                    v.FechaArriboVuelo = Convert.ToDateTime(vector[6]);
                    v.TiempoDeVueloVuelo = vector[7];
                    v.AerolineaVuelo = vector[8];
                    v.ClaseVuelo = Convert.ToChar(vector[9]);
                    v.ItinerarioVuelo = vector[10];
                    v.TipoDePasajeroVuelo = Convert.ToChar(vector[11]);
                    v.CodigoMonedaVuelo = vector[12];
                    v.BaseVuelo = Convert.ToSingle(vector[13]);
                    v.ImpuestosVuelo = Convert.ToSingle(vector[14]);
                    v.ComisionVuelo = Convert.ToSingle(vector[15]);
                    v.DisponibilidadVuelo = Convert.ToInt32(vector[16]);

                    //Agrego items al ListView
                    var item = new ListViewItem();

                    item.Text = v.CodigoVuelo;
                    item.SubItems.Add(v.CodigoOrigenVuelo);
                    item.SubItems.Add(v.CodigoDestinoVuelo);
                    item.SubItems.Add(v.FechaSalidaVuelo.ToString());
                    item.SubItems.Add(v.FechaArriboVuelo.ToString());
                    item.SubItems.Add(v.TiempoDeVueloVuelo);
                    item.SubItems.Add(v.AerolineaVuelo);
                    item.SubItems.Add(v.ClaseVuelo.ToString());
                    item.SubItems.Add(v.ItinerarioVuelo);
                    item.SubItems.Add(v.TipoDePasajeroVuelo.ToString());
                    item.SubItems.Add(v.CodigoMonedaVuelo + " " + v.BaseVuelo.ToString("0.00"));
                    item.SubItems.Add(v.CodigoMonedaVuelo + " " + v.ImpuestosVuelo.ToString("0.00"));
                    item.SubItems.Add(v.ComisionVuelo.ToString("0.0000") + "%");
                    item.SubItems.Add(v.DisponibilidadVuelo.ToString());

                    VuelosListView.Items.Add(item);
                    item.Tag = v;
                }
            }

        }
        */


        //Cuando se selecciona un item del List View
        private void VuelosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerMasInformacionVueloButton.Enabled = true;
            AñadirAlItinerarioVueloButton.Enabled = true;
        }

        private void AñadirAlItinerarioVueloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se ha añadido correctamente al itinerario.", "Itinerario añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ServiciosExtraListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AñadirServicioExtraButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El servicio extra se ha añadido correctamente al itinerario.", "Servicio extra añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}