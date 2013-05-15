using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FrbaBus
{
    public class Usuario
    {
        public Int16 Id { get; set; }
        public String NombreUsr { get; set; }
        public String Rol { get; set; }
        public ArrayList Permisos { get; set; }

        public Usuario()
        {
            Permisos = new ArrayList();
        }

        public void AgregarPermiso(String formulario)
        {
            Permisos.Add(formulario);
        }

        public bool TienePermiso(String formulario)
        {
            return Permisos.Contains(formulario);
        } 
    }
}
