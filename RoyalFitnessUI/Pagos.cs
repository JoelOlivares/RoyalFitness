using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RoyalFitnessUI
{
    public partial class Pagos : Form
    {
        private string Nombre_Cliente;
        private string Monto;
        

        public Pagos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxNombre.Clear();
            comboBox1Plan.Text ="Seleccionar Plan";
            textBoxMonto.Clear();
            comboBoxPago.Text = "Seleccionar Pago";
            richTextBoxConcepto.Clear();
            textBoxTotal.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_acecptar_Click(object sender, EventArgs e)
        {
            Pagos p = new Pagos();
            p.Nombre_Cliente = textBoxNombre.Text;
            p.Mes = comboBoxMes.Items;
            p.Monto = textBoxMonto.Text;
            
           
        }

        public ComboBox.ObjectCollection Mes { get; set; }
    }
}
