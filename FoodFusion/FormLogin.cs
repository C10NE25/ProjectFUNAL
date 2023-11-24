using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace FoodFusion
{
    public partial class FormLogin : Form
    {
        int X = 0;
        int Y = 0;
        private string database = @"D:\ProjectFUNAL\C10NE25\DATABASE\Users.txt";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void PaneTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo lamentamos, esta pestaña no se puede agrandar");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Asignamos las variable un valor.
            string nombre = txtBUser.Text;
            string password = txtBPassword.Text;

            if (nombre == "admin" && password == "12345")
            {
                frmControllerUser frm1 = new frmControllerUser();
                this.Visible = false;
                frm1.StartPosition = FormStartPosition.CenterParent;
                frm1.ShowDialog();
            }
            else if (nombre == "" && password == "")
            {
                MessageBox.Show("Registrese, o revise sus credenciales");
            }
            else if (File.Exists(database))
            {
                if (ValidarInicioSesion(nombre, password))
                {
                    frmInicio frm3 = new frmInicio();
                    frm3.ShowDialog();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Contraseña o usuario incorrecto");
                    return;
                }
            }
        }

        private bool ValidarInicioSesion(string nombre, string password)
        {
            using (StreamReader sr = new StreamReader(database))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    // Dividir la línea en partes utilizando la coma como separador
                    string[] partes = linea.Split(',');

                    // Validar que haya al menos 4 partes
                    if (partes.Length >= 4)
                    {
                        // Obtener el nombre de usuario y la contraseña de las partes
                        string usuario = partes[3].Split(':')[1].Trim();
                        string pass = partes[1].Split(':')[1].Trim();

                        // Validar el nombre de usuario y la contraseña
                        if (nombre == usuario && password == pass)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;   
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void PanelBarLogin_MouseMove(object sender, MouseEventArgs e)
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

        private void PbxLogin_Click(object sender, EventArgs e)
        {

        }

        private void lklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Lleva hacia el nuevo formulario
            FormRegister frm = new FormRegister();
            frm.Owner = this;
            //Inicia la posición en el centro y bloquea el formulario principal
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void lklSavePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSavePassword Save = new FormSavePassword();
            Save.Owner = this;
            Save.ShowDialog();

        }

 
    }
}