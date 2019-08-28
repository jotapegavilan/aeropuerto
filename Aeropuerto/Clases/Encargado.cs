using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeropuerto.Clases
{
    class Encargado
    {
        private string email;
        private string nombre;
        private string apellido;
        private DateTime fecha_nacimiento;
        private string clave;

        public Encargado(string e, string n, string a,
            DateTime f, string c)
        {
            this.Email = e;
            this.Nombre = n;
            this.Apellido = a;
            this.Fecha_nacimiento = f;
            this.Clave = c;
        }

        public string Email { get => email;
            set => email = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
