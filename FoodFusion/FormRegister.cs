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

        private string database = @"D:\ProjectFUNAL\C10NE25\ProjectFUNAL\FoodFusion\bin\Debug";

        int X = 0;
        int Y = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            TextWriter RegisterUser = new StreamWriter(@"D:\ProjectFUNAL\C10NE25\ProjectFUNAL\FoodFusion\bin\Debug" + txtBName.Text + "txt", true);
            RegisterUser.WriteLine(txtBPasswordRegister.Text, txtBEmail.Text, txtBName.Text);
            RegisterUser.Close();
            MessageBox.Show("Recuerde los siguientes codigos: ABXDY");//aqui tiene que ir aleatorio
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
