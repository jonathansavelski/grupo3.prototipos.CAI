using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI
{
    public class TarifaVuelo
    {
        public char ClaseVuelo { get; set; }
        public string ItinerarioVuelo { get; set; }
        public char TipoDePasajeroVuelo { get; set; }
        public string CodigoMonedaVuelo { get; set; }
        public float BaseVuelo { get; set; }
        public float ImpuestosVuelo { get; set; }
        public float ComisionVuelo { get; set; }
        public int DisponibilidadVuelo { get; set; }
    }
}
