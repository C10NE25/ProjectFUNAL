namespace FoodFusion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        int X = 0;
        int Y = 0;
        private void PaneTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInicio frm = new frmInicio();
            this.Visible = false;
            frm.ShowDialog();

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
            FormRegister frm = new FormRegister();
            frm.Owner = this;
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