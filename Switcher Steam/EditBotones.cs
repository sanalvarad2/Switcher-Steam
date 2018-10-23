using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switcher_Steam
{
    public partial class EditBotones : Form
    {
        public EditBotones()
        {

            InitializeComponent();
            button1.Enabled = false;
        }

        
        private void txtIdSteam_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //IForm fromInterface = this.Owner as IForm; //crea instancia de interfaz
            //inutil si uso el array

            //toma los datos ingresados en la pantalla
            int seleccion = cmbOpcModif.SelectedIndex;
            int opc = seleccion;
            string ID = txtIdSteam.Text;
            string nombre = txtNombreJuego.Text;


            funciones.modificarOpcion(opc, ID, nombre);

            //se llamaria a la interfaz, pero se modifica solamente durante la sesion, no perdura.
            //if (fromInterface != null)
            //    fromInterface.updatelabel(opc, nombre);
            Close();


        }

        private void txtIdSteam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //Al pulsar un numero
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
                {
                    e.Handled = false; //Se acepta (todo OK)
                }
                else //Para todo lo demas
                {
                    e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Executable (*.exe)|*.exe|Todos los Archivos|*.*";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                 filename = @open.FileName;
                txtIdSteam.Text = filename;
            }
        }

        private void cmbOpcModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbOpcModif.SelectedIndex >= 5)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void btn_open_path_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
        }
    }
}
