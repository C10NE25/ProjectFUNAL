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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }


        int X = 0;
        int Y = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            TextWriter RegisterUser = new StreamWriter(@"D:\ProjectFUNAL\C10NE25\ProjectFUNAL\FoodFusion\bin\Debug\" + txtBUser.Text + ".txt", true);
            RegisterUser.WriteLine($"Nombre: {txtBName.Text}, Password: {txtBPasswordRegister.Text}, Email: {txtBEmail.Text}, Username: {txtBUser.Text}");
             
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PTopBarRegister_MouseMove(object sender, MouseEventArgs e)
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

        private void PTopBarRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
