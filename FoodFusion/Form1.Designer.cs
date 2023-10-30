namespace FoodFusion
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PbxLogin = new PictureBox();
            PanelBarLogin = new Panel();
            btnCerrar = new Button();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            txtBUser = new TextBox();
            txtBPassword = new TextBox();
            btnLogin = new Button();
            lblUser = new Label();
            lblPassword = new Label();
            lblCopyright = new Label();
            lklRegister = new LinkLabel();
            lklSavePassword = new LinkLabel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)PbxLogin).BeginInit();
            PanelBarLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PbxLogin
            // 
            PbxLogin.Image = Properties.Resources.PAPA_SCREEN;
            PbxLogin.Location = new Point(0, -1);
            PbxLogin.Margin = new Padding(3, 4, 3, 4);
            PbxLogin.Name = "PbxLogin";
            PbxLogin.Size = new Size(350, 628);
            PbxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxLogin.TabIndex = 0;
            PbxLogin.TabStop = false;
            PbxLogin.Click += PbxLogin_Click;
            // 
            // PanelBarLogin
            // 
            PanelBarLogin.Controls.Add(btnCerrar);
            PanelBarLogin.Controls.Add(btnMaximizar);
            PanelBarLogin.Controls.Add(btnMinimizar);
            PanelBarLogin.Location = new Point(0, -1);
            PanelBarLogin.Margin = new Padding(3, 4, 3, 4);
            PanelBarLogin.Name = "PanelBarLogin";
            PanelBarLogin.Size = new Size(655, 44);
            PanelBarLogin.TabIndex = 1;
            PanelBarLogin.Paint += PaneTopBar_Paint;
            PanelBarLogin.MouseMove += PanelBarLogin_MouseMove;
            // 
            // btnCerrar
            // 
            btnCerrar.AccessibleRole = AccessibleRole.SplitButton;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Image = Properties.Resources.Boton_Cerrar;
            btnCerrar.Location = new Point(622, 5);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 31);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.AccessibleRole = AccessibleRole.SplitButton;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.White;
            btnMaximizar.Image = Properties.Resources.Boton_Expandir;
            btnMaximizar.Location = new Point(584, 5);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 31);
            btnMaximizar.TabIndex = 4;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.AccessibleRole = AccessibleRole.SplitButton;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizar.Location = new Point(546, 5);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 31);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // txtBUser
            // 
            txtBUser.Location = new Point(378, 225);
            txtBUser.Margin = new Padding(3, 4, 3, 4);
            txtBUser.Name = "txtBUser";
            txtBUser.Size = new Size(243, 27);
            txtBUser.TabIndex = 2;
            // 
            // txtBPassword
            // 
            txtBPassword.Location = new Point(378, 323);
            txtBPassword.Margin = new Padding(3, 4, 3, 4);
            txtBPassword.Name = "txtBPassword";
            txtBPassword.PasswordChar = '*';
            txtBPassword.Size = new Size(241, 27);
            txtBPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(415, 407);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(158, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Location = new Point(382, 201);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 5;
            lblUser.Text = "User";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Location = new Point(382, 299);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.ForeColor = Color.Gray;
            lblCopyright.Location = new Point(418, 593);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(169, 20);
            lblCopyright.TabIndex = 7;
            lblCopyright.Text = "Produced by final group";
            // 
            // lklRegister
            // 
            lklRegister.AutoSize = true;
            lklRegister.Location = new Point(383, 463);
            lklRegister.Name = "lklRegister";
            lklRegister.Size = new Size(63, 20);
            lklRegister.TabIndex = 8;
            lklRegister.TabStop = true;
            lklRegister.Text = "Register";
            // 
            // lklSavePassword
            // 
            lklSavePassword.AutoSize = true;
            lklSavePassword.Location = new Point(526, 463);
            lklSavePassword.Name = "lklSavePassword";
            lklSavePassword.Size = new Size(125, 20);
            lklSavePassword.TabIndex = 9;
            lklSavePassword.TabStop = true;
            lklSavePassword.Text = "Forgot Password?";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tw Cen MT Condensed Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(362, 103);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(290, 26);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Create your account or register :D!";
            // 
            // FormLogin
            // 
            AccessibleRole = AccessibleRole.SplitButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(654, 625);
            Controls.Add(lblTitle);
            Controls.Add(lklSavePassword);
            Controls.Add(lklRegister);
            Controls.Add(lblCopyright);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(btnLogin);
            Controls.Add(txtBPassword);
            Controls.Add(txtBUser);
            Controls.Add(PbxLogin);
            Controls.Add(PanelBarLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PbxLogin).EndInit();
            PanelBarLogin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox PbxLogin;
        private Panel PanelBarLogin;
        private Button btnMinimizar;
        private Button btnCerrar;
        private Button btnMaximizar;
        private TextBox txtBUser;
        private TextBox txtBPassword;
        private Button btnLogin;
        private Label lblUser;
        private Label lblPassword;
        private Label lblCopyright;
        private LinkLabel lklRegister;
        private LinkLabel lklSavePassword;
        private Label lblTitle;
    }
}