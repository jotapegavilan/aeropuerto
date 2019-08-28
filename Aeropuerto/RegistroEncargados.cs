using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeropuerto.Clases;

namespace Aeropuerto
{
    public partial class RegistroEncargados : Form
    {
        public RegistroEncargados()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string clave1 = txtClave1.Text.Trim();
            string clave2 = txtClave2.Text.Trim();
            DateTime fecha = dtFecha.Value;

            if (email.Length < 13)
            {
                MessageBox.Show("Ingrese un mail de 13 caracteres o más", "ERROR");
            }
            else if (nombre.Length < 3)
            {
                MessageBox.Show("Ingrese un nombre de 3 caracteres o más", "ERROR");
            }
            else if (apellido.Length < 3)
            {
                MessageBox.Show("Ingrese un apellido de 3 caracteres o más", "ERROR");
            }
            else if (clave1.Length < 6)
            {
                MessageBox.Show("Ingrese una clave de 6 caracteres o más", "ERROR");
            }else if (! clave1.Equals(clave2))
            {
                MessageBox.Show("Las claves no coinciden","ERROR");
            }
            else
            {
                //TODO OK
                Encargado nuevo = new Encargado(email, nombre
                    , apellido, fecha, clave1);
                MessageBox.Show(nuevo.Fecha_nacimiento.ToString());
            }
        }
    }
}
