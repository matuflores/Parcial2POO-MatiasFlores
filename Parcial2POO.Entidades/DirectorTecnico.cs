using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class DirectorTecnico:Persona
    {
        public Tipo tipo { get; set; }

        public DirectorTecnico(Tipo Tipo, string nombre, string apellido):base(nombre,apellido)
        {
            this.tipo = Tipo;
        }

        public override string FichaTecnica()
        {
            if (tipo==Tipo.Tecnico)
            {
                return $"{GetNombre().ToUpper()} {GetApellido().ToUpper()}, director tecnico";
            }
            return "Error al ingresar los datos";
        }
    }
}
