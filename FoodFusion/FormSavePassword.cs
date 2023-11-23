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

namespace FoodFusion
{
    public partial class FormSavePassword : Form
    {
        int X = 0;
        int Y = 0;
        public string database = @"D:\ProjectFUNAL\C10NE25\DATABASE\Users.txt";

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

        }
    }

}
