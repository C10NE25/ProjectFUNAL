using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodFusion
{
    public partial class frmControllerUser : Form
    {
        private string database = @"D:\ProjectFUNAL\C10NE25\DATABASE\Users.txt";
        public frmControllerUser()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgvResultado.Rows.Clear();
            if (File.Exists(database))
            {
                using (StreamReader sr = new StreamReader(database))
                {
                    String linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        if (datos.Length == 5)
                        {
                            dgvResultado.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                        }
                    }
                }
            }
        }

        private void GuardarDatos()
        {
            using (StreamWriter sw = new StreamWriter(database))
            {
                foreach (DataGridViewRow row in dgvResultado.Rows)
                {
                    String nombre = row.Cells[0].Value?.ToString();
                    String username = row.Cells[1].Value?.ToString();
                    String password = row.Cells[2].Value?.ToString();
                    String email = row.Cells[3].Value?.ToString();
                    String codigo = row.Cells[4].Value?.ToString();

                    sw.WriteLine($"{nombre},{username},{password},{email},{codigo}");
                }
            }
        }

        private void Agregar()
        {
            String nombre, username, password, email, codigo;
            nombre = txtNombre.Text;
            username = txtUsuario.Text;
            password = txtPassword.Text;
            email = txtEmail.Text;
            codigo = txtCodigo.Text;


            dgvResultado.Rows.Add(nombre, username, password);
        }

        private void Actualizar()
        {
            if (dgvResultado.SelectedRows.Count > 0)
            {
                int indice = dgvResultado.SelectedRows[0].Index;
                String nombre = txtNombre.Text;
                String username = txtUsuario.Text;
                String password = txtPassword.Text;
                string email = txtEmail.Text;
                string codigo = txtCodigo.Text;
                dgvResultado.Rows[indice].SetValues(nombre, username, password, email, codigo);

            }
            else
            {
                MessageBox.Show("Selecciona una Row para actualizar");
            }
        }

        private void Eliminar()
        {
            if (dgvResultado.SelectedRows.Count > 0)
            {
                int indice = dgvResultado.SelectedRows[0].Index;
                dgvResultado.Rows.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Selecciona una Row para actualizar");
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";

        }
        private void dgvResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCodigo.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtUsuario.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPassword.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCodigo.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtUsuario.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPassword.Text = (string)dgvResultado.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            Eliminar();
            GuardarDatos();
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Actualizar();
            GuardarDatos();
            Limpiar();
        }


        private void btmAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
            GuardarDatos();
        }


    }
}
