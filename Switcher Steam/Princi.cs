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
    public partial class SteamSwitcher : Form
    {
        public SteamSwitcher()
        {
            
            funciones.CargarDatos();
            InitializeComponent();
            cargarLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funciones.launcher(0);
            Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            funciones.launcher(1);
            Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funciones.launcher(2);
            Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funciones.launcher(3);
            Close();
            
        }

        private void btnOpc5_Click(object sender, EventArgs e)
        {
            funciones.launcher(4);
            Close();
            
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditBotones ventana = new EditBotones();
           
            ventana.ShowDialog();
            cargarLabels();

        }

        private void btnApp1_Click(object sender, EventArgs e)
        {
            funciones.launcher(5);
            Close();
        }

        private void btnApp2_Click(object sender, EventArgs e)
        {
            funciones.launcher(6);
            Close();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.NumPad1:                     
                case Keys.D1:
                    Console.Write(Keys.D1);
                    funciones.launcher(0);
                    Close();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    funciones.launcher(1);
                    Close();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    funciones.launcher(2);
                    Close();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    funciones.launcher(3);
                    Close();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    funciones.launcher(4);
                    Close();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    funciones.launcher(5);
                    Close();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    funciones.launcher(6);
                    Close();
                    break;
                default:
                    break;
            }
            
            return false;
            
        } 

        //public void updatelabel(int opc, string nuevonombre)
        //{
        //    if (opc == 1) { btnOpc1.Text = "1 - " + nuevonombre; }
        //    if (opc == 2) { btnOpc2.Text = "2 - " + nuevonombre; }
        //    if (opc == 3) { btnOpc3.Text = "3 - " + nuevonombre; }
        //    if (opc == 4) { btnOpc4.Text = "4 - " + nuevonombre; }
        //    else { btnOpc5.Text = "5 - " + nuevonombre; };

        //}

        private void cargarLabels()
        {
            btnOpc1.Text = "1 - " + funciones.variable2[0, 0];
            btnOpc2.Text = "2 - " + funciones.variable2[1, 0];
            btnOpc3.Text = "3 - " + funciones.variable2[2, 0];
            btnOpc4.Text = "4 - " + funciones.variable2[3, 0];
            btnOpc5.Text = "5 - " + funciones.variable2[4, 0];
            btnApp1.Text = "6 - " + funciones.variable2[5, 0];
            btnApp2.Text = "7 - " + funciones.variable2[6, 0]; 
        }

    }
}
