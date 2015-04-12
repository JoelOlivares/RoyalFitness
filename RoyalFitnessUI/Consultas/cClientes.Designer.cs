namespace RoyalFitnessUI.Consultas
{
    partial class cClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cClientes));
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.BuscarPorcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelarButtom = new System.Windows.Forms.Button();
            this.AceptarButtom = new System.Windows.Forms.Button();
            this.BuscarButtom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrotextBox.Location = new System.Drawing.Point(237, 10);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(178, 20);
            this.FiltrotextBox.TabIndex = 54;
            // 
            // BuscarPorcomboBox
            // 
            this.BuscarPorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarPorcomboBox.FormattingEnabled = true;
            this.BuscarPorcomboBox.Items.AddRange(new object[] {
            "",
            " Nombres",
            "Apellidos ",
            "Cedula ",
            "Fecha ingreso",
            "Telefono",
            "Tipo de Plan"});
            this.BuscarPorcomboBox.Location = new System.Drawing.Point(110, 10);
            this.BuscarPorcomboBox.Name = "BuscarPorcomboBox";
            this.BuscarPorcomboBox.Size = new System.Drawing.Size(101, 21);
            this.BuscarPorcomboBox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Buscar Por:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 352);
            this.dataGridView1.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = global::RoyalFitnessUI.Properties.Resources._1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(270, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 62;
            this.button1.Text = "Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CancelarButtom
            // 
            this.CancelarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelarButtom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButtom.Image = global::RoyalFitnessUI.Properties.Resources.action_27931_6402;
            this.CancelarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButtom.Location = new System.Drawing.Point(379, 407);
            this.CancelarButtom.Name = "CancelarButtom";
            this.CancelarButtom.Size = new System.Drawing.Size(94, 36);
            this.CancelarButtom.TabIndex = 61;
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
            this.AceptarButtom.Location = new System.Drawing.Point(156, 408);
            this.AceptarButtom.Name = "AceptarButtom";
            this.AceptarButtom.Size = new System.Drawing.Size(87, 36);
            this.AceptarButtom.TabIndex = 60;
            this.AceptarButtom.Text = "Aceptar";
            this.AceptarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AceptarButtom.UseVisualStyleBackColor = true;
            this.AceptarButtom.Click += new System.EventHandler(this.AceptarButtom_Click);
            // 
            // BuscarButtom
            // 
            this.BuscarButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButtom.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButtom.Image")));
            this.BuscarButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButtom.Location = new System.Drawing.Point(421, 8);
            this.BuscarButtom.Name = "BuscarButtom";
            this.BuscarButtom.Size = new System.Drawing.Size(76, 24);
            this.BuscarButtom.TabIndex = 51;
            this.BuscarButtom.Text = "Buscar";
            this.BuscarButtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButtom.UseVisualStyleBackColor = true;
            this.BuscarButtom.Click += new System.EventHandler(this.BuscarButtom_Click);
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelarButtom);
            this.Controls.Add(this.AceptarButtom);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.BuscarPorcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButtom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelarButtom;
        private System.Windows.Forms.Button AceptarButtom;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.ComboBox BuscarPorcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButtom;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}