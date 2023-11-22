using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodFusion.frmInicio;

namespace FoodFusion
{
    public partial class FormCarrito : Form
    {

        public FormCarrito(List<Producto> productosSeleccionados)
        {
            InitializeComponent();
            // Agrega las columnas al DataGridView
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Precio", "Precio");

            // Agrega los datos al DataGridView
            foreach (var producto in productosSeleccionados)
            {
                dataGridView1.Rows.Add(producto.Nombre, producto.Precio);
            }

            decimal sumaPrecios = productosSeleccionados.Sum(producto => producto.Precio);
            lblPrecioTotal.Text = $"Total: ${sumaPrecios}";
        }



        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormThanks form = new FormThanks();
            this.Visible = false;
            form.ShowDialog();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
