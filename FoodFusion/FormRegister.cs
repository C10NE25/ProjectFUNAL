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
using System.Text.RegularExpressions;

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
            //Reasignamos las variables
            String nombre = txtBName.Text;
            String email = txtBEmail.Text;
            String password = txtBPasswordRegister.Text;
            String user = txtBUser.Text;
            //Validamos cada campo
            if (user.Length == 0 || nombre.Length == 0 || email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Debe rellenar todos los campos");
                return;
            }
            else if (user.Length < 5)
            {
                MessageBox.Show("El usuario debe tener más de 5 caracteres");
                return;
            }
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Solo se admiten letras");
                return;
            }
            if (user.Length == 0 || nombre.Length == 0 || email.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Debe rellenar todos los campos");
                return;
            }
            //Utilizamos funciones para los registros
            string codigo = GeneracionAleatoriaCodigo();
            using (TextWriter RegisterUser = new StreamWriter(database, true))
            {
                RegisterUser.WriteLine($"Nombre: {nombre}, Password: {password}, Email: {email}, Username: {user}, Codigo: {codigo}");
                MessageBox.Show($"Se ha registrado correctamente\nApunte el siguiente codigo: {codigo}");
                this.Visible = false; 
            }
        }

        private string GeneracionAleatoriaCodigo()
        {
            Random random = new Random();
            int codigo = random.Next(1000, 10000);

            return codigo.ToString();
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }
    }
}
