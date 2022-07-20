using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Datos_Personales
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            
            string apellido = textApellido.Text;
                        
            string nombre = textNombre.Text;
            
            string edad = textEdad.Text;
            
            string direccion = textDireccion.Text;

            textResultado.Text = apellido.ToUpper() + " " + nombre.ToUpper() + "\r\n" + edad.ToUpper() + "\r\n" + direccion.ToUpper();



            //Para que pinte el fondo de rojo cuando no completa el texto:

            if (textApellido.Text == "")
                textApellido.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;

            if (textNombre.Text == "")
                textNombre.BackColor = Color.Red;
            else
                textNombre.BackColor = System.Drawing.SystemColors.Control;

            if (textEdad.Text == "")
                textEdad.BackColor = Color.Red;
            else
                textEdad.BackColor = System.Drawing.SystemColors.Control;

            if (textDireccion.Text == "")
                textDireccion.BackColor = Color.Red;
            else
                textDireccion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Para que solo deje escribir números:
        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        
    }
}
