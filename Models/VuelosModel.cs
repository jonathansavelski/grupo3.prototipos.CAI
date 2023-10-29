using grupo3.prototipos.CAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI.Models
{
    internal class VuelosModel
    {
        public List<VueloEnt> VuelosDisponibles = new List<VueloEnt>();
        VuelosForm formularioVuelos;

        public VuelosModel()
        {
            string path = "vuelos.json"; // Ruta del archivo

            string contenidoDelArchivo = File.ReadAllText(path);

            //esta linea convierte el texto

            VuelosDisponibles = JsonSerializer.Deserialize<List<VueloEnt>>(contenidoDelArchivo);
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
                            item.SubItems.Add(vuelo.TarifaVuelo[i].PrecioVuelo.ToString());
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














/*public List<Vuelo> Vuelos = new List<Vuelo>()
    {
        new Vuelo { CodigoVuelo = "AAA123456789123", CodigoOrigenVuelo="Buenos Aires, Argentina", CodigoDestinoVuelo = "Rio de Janeiro, Brasil", FechaSalidaVuelo=new DateTime(2023,11,15,17,00,00), FechaArriboVuelo=new DateTime(2023, 11, 15,22,30,00), TiempoDeVueloVuelo="5:30hs", AerolineaVuelo="Aerolíneas Argentinas", ClaseVuelo='E', ItinerarioVuelo="OW",TipoDePasajeroVuelo='A',BaseVuelo=2000, ImpuestosVuelo=1000, ComisionVuelo=95.0000f, DisponibilidadVuelo=8},
        new Vuelo { CodigoVuelo = "BBB547896321456", CodigoOrigenVuelo="Mendoza, Argentina", CodigoDestinoVuelo = "París, Francia", FechaSalidaVuelo=new DateTime(2023, 12, 25,18,00,00), FechaArriboVuelo=new DateTime(2023, 12, 26,3,00,00), TiempoDeVueloVuelo="8hs", AerolineaVuelo="FlyBondi" },
        new Vuelo { CodigoVuelo = "CCC154789652365", CodigoOrigenVuelo="San Juan, Argentina", CodigoDestinoVuelo = "San Andrés, Colombia", FechaSalidaVuelo=new DateTime(2024, 01,10,19,00,00), FechaArriboVuelo=new DateTime(2024, 01, 11,2,30,00), TiempoDeVueloVuelo="6:30hs", AerolineaVuelo="Jet Smart" },
        new Vuelo { CodigoVuelo = "DDD154789652365", CodigoOrigenVuelo="Catamarca, Argentina", CodigoDestinoVuelo = "California, Estados Unidos", FechaSalidaVuelo=new DateTime(2024, 06, 15,20,00,00), FechaArriboVuelo=new DateTime(2024, 06, 16,6,30,00), TiempoDeVueloVuelo="10:30hs", AerolineaVuelo="Air Europa" },
        new Vuelo { CodigoVuelo = "EEE145365488963", CodigoOrigenVuelo="Chubut, Argentina", CodigoDestinoVuelo = "Montevideo, Uruguay", FechaSalidaVuelo=new DateTime(2025,01, 01,21,00,00), FechaArriboVuelo=new DateTime(2025, 01, 01,23,30,00), TiempoDeVueloVuelo="2:30hs", AerolineaVuelo="Air Canada" }
    };  
    */