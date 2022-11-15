using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Equipo
    {
        public Deportes deporte { get; set; }
        public List<Jugador> listaJugadores;
        public string dt { get; set; }

        public string NombreEquipo { get; set; }

        public Equipo()
        {
            deporte = Deportes.Futbol;
            listaJugadores = new List<Jugador>();
        }

        public Equipo(string nombreDeEquipo, string nombreDt )
        {
            this.NombreEquipo = nombreDeEquipo;
            this.dt = nombreDt;
        }

        public Equipo(string NombreE, string nombreDt, Deportes deportes)
        {
            this.NombreEquipo = NombreE;
            this.dt = nombreDt;
            this.deporte= deportes;
        }

        public string GetDeporte()
        {
            return $"{deporte.ToString()}";
        }


        public string DatosEquipo()
        {
            return $"**{this.NombreEquipo}**"+ "Nomina jugadores" + 
                $"{listaJugadores}";
        }


    }
}
