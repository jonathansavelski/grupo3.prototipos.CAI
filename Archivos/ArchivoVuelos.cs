using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using grupo3.prototipos.CAI.Entidades;

namespace grupo3.prototipos.CAI.Archivos
{
    internal class ArchivoVuelos
    {
        public List<VueloEnt> VuelosDisponibles = new List<VueloEnt>();
        VuelosForm formularioVuelos;

        public ArchivoVuelos()
        {
            string path = "C:\\Users\\Jonathan\\Desktop\\UBA\\Ciclo Profesional\\2023\\Construcción de Aplicaciones Informáticas\\vuelos.json"; // Ruta del archivo

            string contenidoDelArchivo = File.ReadAllText(path);

            //esta linea convierte el texto

            VuelosDisponibles = JsonSerializer.Deserialize<List<VueloEnt>>(contenidoDelArchivo);
        }

        public List<VueloEnt> ObtenerTodas()
        {
            return VuelosDisponibles.ToList();
        }

        
        public void BuscarVuelos(string ciudadOrigen, string ciudadDestino, DateTime fechaDesde, DateTime fechaHasta, string tipoPasajero, ListView vuelosListView)
        {
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
            List<VueloEnt> VuelosEncontrados = VuelosDisponibles.FindAll(vuelo => (vuelo.CiudadOrigenVuelo == ciudadOrigen
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
                            item.SubItems.Add(vuelo.FechaSalidaVuelo.ToString("yyyy/MM/dd HH:mm:ss"));
                            item.SubItems.Add(vuelo.FechaArriboVuelo.ToString("yyyy/MM/dd HH:mm:ss"));
                            item.SubItems.Add(vuelo.TiempoDeVueloVuelo);
                            item.SubItems.Add(vuelo.AerolineaVuelo);

                            item.SubItems.Add(vuelo.TarifaVuelo[i].ClaseVuelo.ToString());
                            item.SubItems.Add(vuelo.TarifaVuelo[i].TipoDePasajeroVuelo.ToString());
                            item.SubItems.Add(vuelo.TarifaVuelo[i].PrecioVuelo.ToString("0.00"));
                            item.SubItems.Add(vuelo.TarifaVuelo[i].DisponibilidadVuelo.ToString());
                            item.Tag = vuelo; // Tag = etiqueta. La propiedad Tag es de tipo object. En esta propiedad puedo guardar lo que quiera. Esto sirve para que podamos meter un dato en cada fila (que no se ve) y me sirve para identificarla en el resto del sistema. 

                            vuelosListView.Items.Add(item);
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
    }
}
