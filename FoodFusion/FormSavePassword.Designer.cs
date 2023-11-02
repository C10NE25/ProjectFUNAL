namespace FoodFusion
{
    partial class FormSavePassword
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
            PanelSaveP = new Panel();
            btnCerrarSP = new Button();
            btnExpandirSP = new Button();
            btnMinimizarSP = new Button();
            lblSaveP = new Label();
            btnSavePassword = new Button();
            lblEmail = new Label();
            txtBEmail = new TextBox();
            txtBCodigo = new TextBox();
            lblCodigo = new Label();
            pbQuestionSP = new PictureBox();
            pbOndasSP = new PictureBox();
            pictureBox1 = new PictureBox();
            PanelSaveP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuestionSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOndasSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelSaveP
            // 
            PanelSaveP.BackColor = Color.WhiteSmoke;
            PanelSaveP.Controls.Add(btnCerrarSP);
            PanelSaveP.Controls.Add(btnExpandirSP);
            PanelSaveP.Controls.Add(btnMinimizarSP);
            PanelSaveP.Location = new Point(0, 0);
            PanelSaveP.Name = "PanelSaveP";
            PanelSaveP.Size = new Size(377, 31);
            PanelSaveP.TabIndex = 0;
            // 
            // btnCerrarSP
            // 
            btnCerrarSP.FlatStyle = FlatStyle.Flat;
            btnCerrarSP.ForeColor = Color.WhiteSmoke;
            btnCerrarSP.Image = Properties.Resources.Boton_Cerrar;
            btnCerrarSP.Location = new Point(349, 3);
            btnCerrarSP.Name = "btnCerrarSP";
            btnCerrarSP.Size = new Size(23, 23);
            btnCerrarSP.TabIndex = 2;
            btnCerrarSP.UseVisualStyleBackColor = true;
            btnCerrarSP.Click += btnCerrarSP_Click;
            // 
            // btnExpandirSP
            // 
            btnExpandirSP.FlatStyle = FlatStyle.Flat;
            btnExpandirSP.ForeColor = Color.WhiteSmoke;
            btnExpandirSP.Image = Properties.Resources.Boton_Expandir;
            btnExpandirSP.Location = new Point(318, 3);
            btnExpandirSP.Name = "btnExpandirSP";
            btnExpandirSP.Size = new Size(23, 23);
            btnExpandirSP.TabIndex = 1;
            btnExpandirSP.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarSP
            // 
            btnMinimizarSP.FlatStyle = FlatStyle.Flat;
            btnMinimizarSP.ForeColor = Color.WhiteSmoke;
            btnMinimizarSP.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizarSP.Location = new Point(287, 3);
            btnMinimizarSP.Name = "btnMinimizarSP";
            btnMinimizarSP.Size = new Size(23, 23);
            btnMinimizarSP.TabIndex = 0;
            btnMinimizarSP.UseVisualStyleBackColor = true;
            // 
            // lblSaveP
            // 
            lblSaveP.AutoSize = true;
            lblSaveP.Font = new Font("Tw Cen MT Condensed Extra Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaveP.Location = new Point(63, 117);
            lblSaveP.Name = "lblSaveP";
            lblSaveP.Size = new Size(253, 52);
            lblSaveP.TabIndex = 1;
            lblSaveP.Text = "¿Has olvidado tu contraseña? \r\nNo te preocupes, recuperala";
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(115, 284);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(134, 40);
            btnSavePassword.TabIndex = 2;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(74, 187);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(230, 23);
            txtBEmail.TabIndex = 4;
            // 
            // txtBCodigo
            // 
            txtBCodigo.Location = new Point(74, 236);
            txtBCodigo.Name = "txtBCodigo";
            txtBCodigo.Size = new Size(230, 23);
            txtBCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 239);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            // 
            // pbQuestionSP
            // 
            pbQuestionSP.Image = Properties.Resources.Icon_Question_Save_Password;
            pbQuestionSP.Location = new Point(149, 37);
            pbQuestionSP.Name = "pbQuestionSP";
            pbQuestionSP.Size = new Size(75, 75);
            pbQuestionSP.SizeMode = PictureBoxSizeMode.StretchImage;
            pbQuestionSP.TabIndex = 7;
            pbQuestionSP.TabStop = false;
            // 
            // pbOndasSP
            // 
            pbOndasSP.Image = Properties.Resources.Ondas_Fondo_removebg_preview;
            pbOndasSP.Location = new Point(299, 275);
            pbOndasSP.Name = "pbOndasSP";
            pbOndasSP.Size = new Size(127, 104);
            pbOndasSP.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOndasSP.TabIndex = 3;
            pbOndasSP.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Ondas_Fondo_removebg_preview;
            pictureBox1.Location = new Point(-52, -37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormSavePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(376, 340);
            Controls.Add(pictureBox1);
            Controls.Add(pbOndasSP);
            Controls.Add(pbQuestionSP);
            Controls.Add(lblCodigo);
            Controls.Add(txtBCodigo);
            Controls.Add(txtBEmail);
            Controls.Add(lblEmail);
            Controls.Add(btnSavePassword);
            Controls.Add(lblSaveP);
            Controls.Add(PanelSaveP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSavePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSavePassword";
            PanelSaveP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuestionSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOndasSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelSaveP;
        private Label lblSaveP;
        private Button btnSavePassword;
        private Label lblEmail;
        private TextBox txtBEmail;
        private TextBox txtBCodigo;
        private Label lblCodigo;
        private Button btnCerrarSP;
        private Button btnExpandirSP;
        private Button btnMinimizarSP;
        private PictureBox pbQuestionSP;
        private PictureBox pbOndasSP;
        private PictureBox pictureBox1;
    }
}