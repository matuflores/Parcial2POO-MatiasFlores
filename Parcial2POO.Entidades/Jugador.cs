using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Jugador:Persona
    {
        public int numeroCamiseta { get; set; }
        public bool esCapitan { get; set; }

        public Tipo Tipo { get; set; }

        public Jugador(string Nombre, string apellido, Tipo tipo):base(Nombre, apellido)
        {
            Tipo = tipo;
        }

        public Jugador(int Numero, bool EsCapitan, string Nombre, string apellido, Tipo tipo) : base(Nombre, apellido)
        {
            numeroCamiseta = Numero;
            esCapitan = EsCapitan;
        }

        public override string FichaTecnica()
        {
            if (esCapitan==true)
            {
                return $"{GetApellido().ToUpper()} {GetNombre()}, capitan del equipo, camiseta numero{numeroCamiseta}";
            }
            else
            {
                return $"{GetApellido().ToUpper()} {GetNombre()},  camiseta numero{numeroCamiseta}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Persona)) 
            {
                return false;
            }
            return this.GetNombre() == ((Persona)obj).GetNombre() &&
                    this.GetApellido() == ((Persona)obj).GetApellido() &&
                    this.numeroCamiseta == numeroCamiseta;
        }

        public bool JugardorIgual()
        {
            if (this.GetNombre()==GetNombre() && this.GetApellido()==GetApellido() && this.numeroCamiseta==numeroCamiseta)
            {
                return false;
            }
            return true;

        }

        public int ConversionNumeroJugardo()
        {
            int numeroJugador;
            numeroJugador = this.numeroCamiseta;
            return numeroJugador;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static implicit operator List<object>(Jugador v)
        {
            throw new NotImplementedException();
        }
    }
}
