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

        int X = 0;
        int Y = 0;
        private string database = @"D:\ProjectFUNAL\C10NE25\DATABASE\Users.txt";

        public FormRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void DataSave()
        {
            String nombre = txtBName.Text;
            String email = txtBEmail.Text;
            String password = txtBPasswordRegister.Text;
            String user = txtBUser.Text;

            TextWriter RegisterUser = new StreamWriter(database, true);
            RegisterUser.WriteLine($"Nombre: {nombre}, Password: {password}, Email: {email}, Username: {user}");
            RegisterUser.Close();
            this.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataSave();
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
