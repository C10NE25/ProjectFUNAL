using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace FoodFusion
{
    public partial class FormSavePassword : Form
    {
        int X = 0;
        int Y = 0;
        private string database = @"D:\ProjectFUNAL\C10NE25\DATABASE\Users.txt";

        public FormSavePassword()
        {
            InitializeComponent();
        }

        private void btnCerrarSP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExpandirSP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo lamentamos esta pestaña no se puede maximizar");
        }

        private void btnMinimizarSP_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelSaveP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
            else
            {
                Left = Left + (e.X - X);
                Top = Top + (e.Y - Y);
            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string correo = txtBEmail.Text;
            VerificarExistenciaCorreo(correo);
        }

        private bool VerificarExistenciaCorreo(string correo)
        {
            //Lee todas las lineas del archivo
            string[] lineas = File.ReadAllLines(database);

            // Se busca el correo electronico
            foreach (string linea in lineas)
            {
                if (linea.Contains("Email: " + correo))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se encuentra el correo");
                }
            }
            return false;
        }
    }

}
