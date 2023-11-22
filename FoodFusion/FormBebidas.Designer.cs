namespace FoodFusion
{
    partial class FormBebidas
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
            lblBebidas = new Label();
            lblGaseosa1 = new Label();
            lblGaseosa3 = new Label();
            label1 = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            btnComprar = new Button();
            SuspendLayout();
            // 
            // lblBebidas
            // 
            lblBebidas.AutoSize = true;
            lblBebidas.BackColor = Color.Transparent;
            lblBebidas.Font = new Font("MV Boli", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBebidas.ForeColor = SystemColors.ButtonHighlight;
            lblBebidas.Location = new Point(157, 27);
            lblBebidas.Name = "lblBebidas";
            lblBebidas.Size = new Size(226, 62);
            lblBebidas.TabIndex = 24;
            lblBebidas.Text = "BEBIDAS";
            lblBebidas.Click += lblBebidas_Click;
            // 
            // lblGaseosa1
            // 
            lblGaseosa1.AutoSize = true;
            lblGaseosa1.BackColor = Color.Transparent;
            lblGaseosa1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGaseosa1.ForeColor = SystemColors.ButtonHighlight;
            lblGaseosa1.Location = new Point(12, 138);
            lblGaseosa1.Name = "lblGaseosa1";
            lblGaseosa1.Size = new Size(217, 40);
            lblGaseosa1.TabIndex = 25;
            lblGaseosa1.Text = "Inka Cola 1L.............. S/7.00\r\n\r\n";
            // 
            // lblGaseosa3
            // 
            lblGaseosa3.AutoSize = true;
            lblGaseosa3.BackColor = Color.Transparent;
            lblGaseosa3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGaseosa3.ForeColor = SystemColors.ButtonHighlight;
            lblGaseosa3.Location = new Point(10, 196);
            lblGaseosa3.Name = "lblGaseosa3";
            lblGaseosa3.Size = new Size(219, 40);
            lblGaseosa3.TabIndex = 26;
            lblGaseosa3.Text = "Coca Cola 1L.............. S/7.00\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(10, 259);
            label1.Name = "label1";
            label1.Size = new Size(328, 40);
            label1.TabIndex = 27;
            label1.Text = "Jarra de Chicha morada 1L.............. S/10.00\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 327);
            label2.Name = "label2";
            label2.Size = new Size(340, 40);
            label2.TabIndex = 28;
            label2.Text = "Jarra de Limonada Frozen 1l.............. S/12.00\r\n\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(446, 138);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(14, 13);
            checkBox1.TabIndex = 29;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Location = new Point(446, 196);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(14, 13);
            checkBox2.TabIndex = 30;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(446, 259);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(14, 13);
            checkBox3.TabIndex = 31;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(446, 327);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(14, 13);
            checkBox4.TabIndex = 32;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = SystemColors.ButtonHighlight;
            btnComprar.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.Black;
            btnComprar.Location = new Point(375, 360);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(123, 37);
            btnComprar.TabIndex = 33;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // FormBebidas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoMENU3;
            ClientSize = new Size(510, 409);
            Controls.Add(btnComprar);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGaseosa3);
            Controls.Add(lblGaseosa1);
            Controls.Add(lblBebidas);
            Name = "FormBebidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBebidas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBebidas;
        private Label lblGaseosa1;
        private Label lblGaseosa3;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button btnComprar;
    }
}