namespace RoyalFitnessUI
{
    partial class LoginUsuario
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
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_acecptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Usuario",
            "Supervisor",
            "Administrador"});
            this.comboBoxNivel.Location = new System.Drawing.Point(151, 163);
            this.comboBoxNivel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNivel.TabIndex = 31;
            this.comboBoxNivel.Text = "Usuario";
            this.comboBoxNivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxlogin_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nivel de Acceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Login de Usuario";
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contrasena.Location = new System.Drawing.Point(151, 117);
            this.textBox_contrasena.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.PasswordChar = '*';
            this.textBox_contrasena.Size = new System.Drawing.Size(175, 20);
            this.textBox_contrasena.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(151, 66);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(175, 20);
            this.textBoxUsuario.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Image = global::RoyalFitnessUI.Properties.Resources.action_27931_6402;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(225, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_acecptar
            // 
            this.button_acecptar.Image = global::RoyalFitnessUI.Properties.Resources.camera_test2;
            this.button_acecptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_acecptar.Location = new System.Drawing.Point(76, 213);
            this.button_acecptar.Margin = new System.Windows.Forms.Padding(5);
            this.button_acecptar.Name = "button_acecptar";
            this.button_acecptar.Size = new System.Drawing.Size(105, 42);
            this.button_acecptar.TabIndex = 24;
            this.button_acecptar.Text = "Aceptar";
            this.button_acecptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_acecptar.UseVisualStyleBackColor = true;
            this.button_acecptar.Click += new System.EventHandler(this.button_acecptar_Click);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_acecptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_acecptar;
    }
}