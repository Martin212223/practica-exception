using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibMedico.Entidades
{
    public class Medico
    {

        public Medico(string nombre)
        {
            Nombre = nombre;
        }

        private string _Nombre;

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                if (value.Trim().Length > 50) throw new Exception("El nombre no puede ser mayor a 50 caracteres.");
                else if (value.Trim().Length < 1) throw new Exception("El nombre no puede estar vacío.");
                _Nombre = value;
            }
        }

        
    }
}
