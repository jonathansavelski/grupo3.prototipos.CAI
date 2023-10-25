using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3.prototipos.CAI.Entidades
{
    public class Itinerario
    {
        public string NumeroItinerario { get; set; }
        public DateTime FechaCreacionItinerario;




        public Itinerario(string Numero)
        {
            this.NumeroItinerario = Numero;

            FechaCreacionItinerario = DateTime.Now;

        }

        public Itinerario() { }
    }

    
}
 