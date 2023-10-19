using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI
{
    internal class Vuelo
    {
        public string CodigoVuelo { get; set; }
        public string CodigoOrigenVuelo { get; set; }
        public string CodigoDestinoVuelo { get; set; }
        public DateTime FechaSalidaVuelo { get; set; }
        public DateTime FechaArriboVuelo { get; set; }
        public string TiempoDeVueloVuelo { get; set; }
        public string AerolineaVuelo { get; set; }
        public char ClaseVuelo { get; set; }
        public string ItinerarioVuelo { get; set; }
        public char TipoDePasajeroVuelo { get; set; }
        public float BaseVuelo { get; set; }
        public float ImpuestosVuelo { get; set; }
        public float ComisionVuelo { get; set; }
        public int DisponibilidadVuelo { get; set; }
        public string[] ParadasVuelo { get; set; }
    }
}
