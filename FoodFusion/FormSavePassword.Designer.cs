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
            lblSaveP = new Label();
            btnSavePassword = new Button();
            lblEmail = new Label();
            txtBEmail = new TextBox();
            txtBCodigo = new TextBox();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // PanelSaveP
            // 
            PanelSaveP.BackColor = Color.LightSkyBlue;
            PanelSaveP.Location = new Point(0, 0);
            PanelSaveP.Name = "PanelSaveP";
            PanelSaveP.Size = new Size(366, 28);
            PanelSaveP.TabIndex = 0;
            // 
            // lblSaveP
            // 
            lblSaveP.AutoSize = true;
            lblSaveP.Font = new Font("Tw Cen MT Condensed Extra Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaveP.Location = new Point(51, 47);
            lblSaveP.Name = "lblSaveP";
            lblSaveP.Size = new Size(253, 52);
            lblSaveP.TabIndex = 1;
            lblSaveP.Text = "¿Has olvidado tu contraseña? \r\nNo te preocupes, recuperala";
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(98, 201);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(134, 40);
            btnSavePassword.TabIndex = 2;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtBEmail
            // 
            txtBEmail.Location = new Point(74, 119);
            txtBEmail.Name = "txtBEmail";
            txtBEmail.Size = new Size(230, 23);
            txtBEmail.TabIndex = 4;
            // 
            // txtBCodigo
            // 
            txtBCodigo.Location = new Point(74, 157);
            txtBCodigo.Name = "txtBCodigo";
            txtBCodigo.Size = new Size(230, 23);
            txtBCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 160);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            // 
            // FormSavePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 264);
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
    }
}