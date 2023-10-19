using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI
{
    internal class VuelosModel
    {
        public List<Vuelo> Vuelos = new List<Vuelo>()
    {
        new Vuelo { CodigoVuelo = "AAA123456789123", CodigoOrigenVuelo="Buenos Aires, Argentina", CodigoDestinoVuelo = "Rio de Janeiro, Brasil", FechaSalidaVuelo=new DateTime(2023,11,15,17,00,00), FechaArriboVuelo=new DateTime(2023, 11, 15,22,30,00), TiempoDeVueloVuelo="5:30hs", AerolineaVuelo="Aerolíneas Argentinas", ClaseVuelo='E', ItinerarioVuelo="OW",TipoDePasajeroVuelo='A',BaseVuelo=2000, ImpuestosVuelo=1000, ComisionVuelo=95.0000f, DisponibilidadVuelo=8, ParadasVuelo= new string[] { "San Pablo", "Rio" } },
        new Vuelo { CodigoVuelo = "BBB547896321456", CodigoOrigenVuelo="Mendoza, Argentina", CodigoDestinoVuelo = "París, Francia", FechaSalidaVuelo=new DateTime(2023, 12, 25,18,00,00), FechaArriboVuelo=new DateTime(2023, 12, 26,3,00,00), TiempoDeVueloVuelo="8hs", AerolineaVuelo="FlyBondi" },
        new Vuelo { CodigoVuelo = "CCC154789652365", CodigoOrigenVuelo="San Juan, Argentina", CodigoDestinoVuelo = "San Andrés, Colombia", FechaSalidaVuelo=new DateTime(2024, 01,10,19,00,00), FechaArriboVuelo=new DateTime(2024, 01, 11,2,30,00), TiempoDeVueloVuelo="6:30hs", AerolineaVuelo="Jet Smart" },
        new Vuelo { CodigoVuelo = "DDD154789652365", CodigoOrigenVuelo="Catamarca, Argentina", CodigoDestinoVuelo = "California, Estados Unidos", FechaSalidaVuelo=new DateTime(2024, 06, 15,20,00,00), FechaArriboVuelo=new DateTime(2024, 06, 16,6,30,00), TiempoDeVueloVuelo="10:30hs", AerolineaVuelo="Air Europa" },
        new Vuelo { CodigoVuelo = "EEE145365488963", CodigoOrigenVuelo="Chubut, Argentina", CodigoDestinoVuelo = "Montevideo, Uruguay", FechaSalidaVuelo=new DateTime(2025,01, 01,21,00,00), FechaArriboVuelo=new DateTime(2025, 01, 01,23,30,00), TiempoDeVueloVuelo="2:30hs", AerolineaVuelo="Air Canada" }
    };  

    }
}
