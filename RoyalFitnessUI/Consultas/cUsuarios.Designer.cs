namespace RoyalFitnessUI.Consultas
{
    partial class cUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cUsuarios));
            this.CancelarButtom = new System.Windows.Forms.Button();
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.BuscarPorcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarButtom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButtom
            // 
            this.CancelarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButtom.Image = global::RoyalFitnessUI.Properties.Resources.action_27931_6402;
            this.CancelarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButtom.Location = new System.Drawing.Point(288, 443);
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Size = new System.Drawing.Size(94, 44);
            this.CancelarButtom.TabIndex = 60;
            this.CancelarButtom.Text = "Cancelar";
            this.CancelarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButtom.UseVisualStyleBackColor = true;
            // 
            // AceptarButtom
            // 
            this.AceptarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AceptarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AceptarButtom.Image = global::RoyalFitnessUI.Properties.Resources.camera_test2;
            this.AceptarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AceptarButtom.Location = new System.Drawing.Point(29, 443);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(87, 44);
            this.AceptarButtom.TabIndex = 59;
            this.AceptarButtom.Text = "Aceptar";
            this.AceptarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButtom.UseVisualStyleBackColor = true;
            this.AceptarButtom.Click += new System.EventHandler(this.AceptarButtom_Click);
            // 
            // BuscarPorcomboBox
            // 
            this.BuscarPorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorcomboBox.FormattingEnabled = true;
            this.BuscarPorcomboBox.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "Usuario"});
            this.BuscarPorcomboBox.Location = new System.Drawing.Point(112, 11);
            this.BuscarPorcomboBox.Name = "BuscarPorcomboBox";
            this.BuscarPorcomboBox.Size = new System.Drawing.Size(101, 21);
            this.BuscarPorcomboBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Buscar Por:";
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(219, 8);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(76, 24);
            this.BuscarButtom.TabIndex = 50;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 387);
            this.dataGridView1.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::RoyalFitnessUI.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(156, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 44);
            this.button1.TabIndex = 61;
            this.button1.Text = "Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(302, 11);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(350, 20);
            this.textBoxBusqueda.TabIndex = 62;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 510);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.BuscarPorcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarButtom;
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.ComboBox BuscarPorcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBusqueda;
    }
}