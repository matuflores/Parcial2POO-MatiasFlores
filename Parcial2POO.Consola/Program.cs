using Parcial2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var dTecnico1 = new DirectorTecnico(Tipo.Tecnico, "Hugo", "Ibarra");
            var equipo1 = new Equipo("Boca Juniors", dTecnico1.NombreCompleto(),Deportes.Futbol);
            var jugador1 = new Jugador(4, false, "Frank", "Fabra", Tipo.Jugador);
            var jugador2 = new Jugador(1,false,"Agustin","Rossi",Tipo.Jugador);
            var jugador3 = new Jugador(9, true, "Dario", "Benedetto", Tipo.Jugador);
            var jugador4 = new Jugador(7, true, "Exequiel", "Zeballos", Tipo.Jugador);
            equipo1.listaJugadores.Add(jugador1);
            equipo1.listaJugadores.Add(jugador2);
            equipo1.listaJugadores.Add(jugador3);
            equipo1.listaJugadores.Add(jugador4);

            Console.WriteLine($"{equipo1.DatosEquipo()}");
        }
    }
}
