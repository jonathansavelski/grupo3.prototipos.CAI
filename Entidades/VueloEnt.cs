using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI.Entidades
{
    public class VueloEnt
    {
        public string CodigoVuelo { get; set; }
        public string CodigoOrigenVuelo { get; set; }
        public string CiudadOrigenVuelo { get; set; }
        public string CodigoDestinoVuelo { get; set; }
        public string CiudadDestinoVuelo { get; set; }
        public DateTime FechaSalidaVuelo { get; set; }
        public DateTime FechaArriboVuelo { get; set; }
        public string TiempoDeVueloVuelo { get; set; }
        public string AerolineaVuelo { get; set; }
        public List<TarifaVuelo> TarifaVuelo { get; set; }
    }
}















/*
        public char ClaseVuelo { get; set; }
        public string ItinerarioVuelo { get; set; }
        public char TipoDePasajeroVuelo { get; set; }
        public string CodigoMonedaVuelo { get; set; }
        public float BaseVuelo { get; set; }
        public float ImpuestosVuelo { get; set; }
        public float ComisionVuelo { get; set; }
        public int DisponibilidadVuelo { get; set; }
        */