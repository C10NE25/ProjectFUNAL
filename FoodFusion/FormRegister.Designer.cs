namespace FoodFusion
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PBoxRegister = new PictureBox();
            TitleRegister = new Label();
            btnRegister = new Button();
            txtBName = new TextBox();
            txtBUser = new TextBox();
            PTopBarRegister = new Panel();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            txtBPasswordRegister = new TextBox();
            txtBEmail = new TextBox();
            lblName = new Label();
            lblUserR = new Label();
            lblEmail = new Label();
            lblPasswordR = new Label();
            ((System.ComponentModel.ISupportInitialize)PBoxRegister).BeginInit();
            PTopBarRegister.SuspendLayout();
            SuspendLayout();
            // 
            // PBoxRegister
            // 
            PBoxRegister.Image = Properties.Resources.RegisterPage;
            PBoxRegister.Location = new Point(0, 0);
            PBoxRegister.Margin = new Padding(3, 4, 3, 4);
            PBoxRegister.Name = "PBoxRegister";
            PBoxRegister.Size = new Size(350, 625);
            PBoxRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            PBoxRegister.TabIndex = 0;
            PBoxRegister.TabStop = false;
            // 
            // TitleRegister
            // 
            TitleRegister.AutoSize = true;
            TitleRegister.Font = new Font("Tw Cen MT Condensed Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TitleRegister.ForeColor = Color.White;
            TitleRegister.Location = new Point(357, 81);
            TitleRegister.Name = "TitleRegister";
            TitleRegister.Size = new Size(252, 26);
            TitleRegister.TabIndex = 1;
            TitleRegister.Text = "Please enter your information";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(408, 461);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(146, 39);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtBName
            // 
            txtBName.BackColor = Color.White;
            txtBName.Location = new Point(365, 184);
            txtBName.Margin = new Padding(3, 4, 3, 4);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(236, 27);
            txtBName.TabIndex = 3;
            // 
            // txtBUser
            // 
            txtBUser.BackColor = Color.White;
            txtBUser.Location = new Point(365, 247);
            txtBUser.Margin = new Padding(3, 4, 3, 4);
            txtBUser.Name = "txtBUser";
            txtBUser.Size = new Size(236, 27);
            txtBUser.TabIndex = 4;
            // 
            // PTopBarRegister
            // 
            PTopBarRegister.BackColor = Color.Transparent;
            PTopBarRegister.Controls.Add(btnMinimizar);
            PTopBarRegister.Controls.Add(btnMaximizar);
            PTopBarRegister.Controls.Add(btnCerrar);
            PTopBarRegister.Dock = DockStyle.Top;
            PTopBarRegister.Location = new Point(0, 0);
            PTopBarRegister.Margin = new Padding(3, 4, 3, 4);
            PTopBarRegister.Name = "PTopBarRegister";
            PTopBarRegister.Size = new Size(654, 39);
            PTopBarRegister.TabIndex = 5;
            PTopBarRegister.Paint += PTopBarRegister_Paint;
            PTopBarRegister.MouseMove += PTopBarRegister_MouseMove;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizar.Location = new Point(533, 4);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 31);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.Image = Properties.Resources.Boton_Expandir;
            btnMaximizar.Location = new Point(575, 4);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 31);
            btnMaximizar.TabIndex = 1;
            btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCerrar.Image = Properties.Resources.Boton_Cerrar;
            btnCerrar.Location = new Point(617, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 31);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtBPasswordRegister
            // 
            txtBPasswordRegister.Location = new Point(365, 376);
            txtBPasswordRegister.Margin = new Padding(3, 4, 3, 4);
            txtBPasswordRegister.Name = "txtBPasswordRegister";
            txtBPasswordRegister.PasswordChar = '*';
            txtBPasswordRegister.Size = new Size(236, 27);
            txtBPasswordRegister.TabIndex = 6;
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(365, 311);
            txtBEmail.Margin = new Padding(3, 4, 3, 4);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(236, 27);
            txtBEmail.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(368, 160);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // lblUserR
            // 
            lblUserR.AutoSize = true;
            lblUserR.ForeColor = Color.White;
            lblUserR.Location = new Point(368, 223);
            lblUserR.Name = "lblUserR";
            lblUserR.Size = new Size(38, 20);
            lblUserR.TabIndex = 9;
            lblUserR.Text = "User";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(367, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            lblEmail.Click += lblCorreo_Click;
            // 
            // lblPasswordR
            // 
            lblPasswordR.AutoSize = true;
            lblPasswordR.ForeColor = Color.White;
            lblPasswordR.Location = new Point(367, 352);
            lblPasswordR.Name = "lblPasswordR";
            lblPasswordR.Size = new Size(70, 20);
            lblPasswordR.TabIndex = 11;
            lblPasswordR.Text = "Password";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(654, 625);
            Controls.Add(lblPasswordR);
            Controls.Add(lblEmail);
            Controls.Add(lblUserR);
            Controls.Add(lblName);
            Controls.Add(txtBEmail);
            Controls.Add(txtBPasswordRegister);
            Controls.Add(txtBUser);
            Controls.Add(txtBName);
            Controls.Add(btnRegister);
            Controls.Add(TitleRegister);
            Controls.Add(PBoxRegister);
            Controls.Add(PTopBarRegister);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)PBoxRegister).EndInit();
            PTopBarRegister.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBoxRegister;
        private Label TitleRegister;
        private Button btnRegister;
        private TextBox txtBName;
        private TextBox txtBUser;
        private Panel PTopBarRegister;
        private Button btnCerrar;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private TextBox txtBPasswordRegister;
        private TextBox txtBEmail;
        private Label lblName;
        private Label lblUserR;
        private Label lblEmail;
        private Label lblPasswordR;
    }
}