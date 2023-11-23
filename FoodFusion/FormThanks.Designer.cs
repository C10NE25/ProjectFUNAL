namespace FoodFusion
{
    partial class FormThanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanks));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.NavajoWhite;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(145, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(526, 224);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 285);
            label1.Name = "label1";
            label1.Size = new Size(286, 28);
            label1.TabIndex = 8;
            label1.Text = "¿Que tal te pareció el servicio?";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(49, 333);
            button1.Name = "button1";
            button1.Size = new Size(126, 127);
            button1.TabIndex = 9;
            button1.Text = "1\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(192, 333);
            button2.Name = "button2";
            button2.Size = new Size(126, 127);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(335, 333);
            button3.Name = "button3";
            button3.Size = new Size(126, 127);
            button3.TabIndex = 11;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(482, 333);
            button4.Name = "button4";
            button4.Size = new Size(126, 127);
            button4.TabIndex = 12;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(630, 333);
            button5.Name = "button5";
            button5.Size = new Size(126, 127);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.Moccasin;
            btnMinimizar.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizar.Location = new Point(702, 4);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 31);
            btnMinimizar.TabIndex = 14;
            btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.Moccasin;
            btnMaximizar.Image = Properties.Resources.Boton_Expandir;
            btnMaximizar.Location = new Point(736, 4);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 31);
            btnMaximizar.TabIndex = 15;
            btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.Moccasin;
            btnCerrar.Image = Properties.Resources.Boton_Cerrar;
            btnCerrar.Location = new Point(768, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 31);
            btnCerrar.TabIndex = 16;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormThanks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(801, 469);
            Controls.Add(btnCerrar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnMinimizar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormThanks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormThanks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnCerrar;
    }
}