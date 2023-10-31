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
            lblCorreo = new Label();
            lblPasswordR = new Label();
            ((System.ComponentModel.ISupportInitialize)PBoxRegister).BeginInit();
            PTopBarRegister.SuspendLayout();
            SuspendLayout();
            // 
            // PBoxRegister
            // 
            PBoxRegister.Image = Properties.Resources.RegisterPage;
            PBoxRegister.Location = new Point(0, 0);
            PBoxRegister.Name = "PBoxRegister";
            PBoxRegister.Size = new Size(306, 469);
            PBoxRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            PBoxRegister.TabIndex = 0;
            PBoxRegister.TabStop = false;
            // 
            // TitleRegister
            // 
            TitleRegister.AutoSize = true;
            TitleRegister.Font = new Font("Tw Cen MT Condensed Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TitleRegister.ForeColor = Color.White;
            TitleRegister.Location = new Point(310, 60);
            TitleRegister.Name = "TitleRegister";
            TitleRegister.Size = new Size(216, 21);
            TitleRegister.TabIndex = 1;
            TitleRegister.Text = "Please enter your information";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(357, 346);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(128, 29);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtBName
            // 
            txtBName.BackColor = Color.White;
            txtBName.Location = new Point(319, 138);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(207, 23);
            txtBName.TabIndex = 3;
            // 
            // txtBUser
            // 
            txtBUser.BackColor = Color.White;
            txtBUser.Location = new Point(319, 185);
            txtBUser.Name = "txtBUser";
            txtBUser.Size = new Size(207, 23);
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
            PTopBarRegister.Name = "PTopBarRegister";
            PTopBarRegister.Size = new Size(572, 29);
            PTopBarRegister.TabIndex = 5;
            PTopBarRegister.MouseMove += PTopBarRegister_MouseMove;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizar.Location = new Point(466, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(23, 23);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.Image = Properties.Resources.Boton_Expandir;
            btnMaximizar.Location = new Point(503, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(23, 23);
            btnMaximizar.TabIndex = 1;
            btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCerrar.Image = Properties.Resources.Boton_Cerrar;
            btnCerrar.Location = new Point(540, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(23, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtBPasswordRegister
            // 
            txtBPasswordRegister.Location = new Point(319, 282);
            txtBPasswordRegister.Name = "txtBPasswordRegister";
            txtBPasswordRegister.Size = new Size(207, 23);
            txtBPasswordRegister.TabIndex = 6;
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(319, 233);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(207, 23);
            txtBEmail.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(322, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // lblUserR
            // 
            lblUserR.AutoSize = true;
            lblUserR.ForeColor = Color.White;
            lblUserR.Location = new Point(322, 167);
            lblUserR.Name = "lblUserR";
            lblUserR.Size = new Size(30, 15);
            lblUserR.TabIndex = 9;
            lblUserR.Text = "User";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(321, 216);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 10;
            lblCorreo.Text = "Correo";
            // 
            // lblPasswordR
            // 
            lblPasswordR.AutoSize = true;
            lblPasswordR.ForeColor = Color.White;
            lblPasswordR.Location = new Point(321, 264);
            lblPasswordR.Name = "lblPasswordR";
            lblPasswordR.Size = new Size(57, 15);
            lblPasswordR.TabIndex = 11;
            lblPasswordR.Text = "Password";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(572, 469);
            Controls.Add(lblPasswordR);
            Controls.Add(lblCorreo);
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
        private Label lblCorreo;
        private Label lblPasswordR;
    }
}