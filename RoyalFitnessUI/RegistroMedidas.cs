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
    public partial class RegistroMedidas : Form
    {
        public RegistroMedidas()
        {
            InitializeComponent();
        }

        private void AceptarButtom_Click(object sender, EventArgs e)
        {
            Medidas m = new Medidas();

            m.Bicesp = float.Parse(textBoxBiceps.Text);
            m.Triceps = float.Parse(textBoxTriceps.Text);
            m.Pectorales = float.Parse(textBoxPectorales.Text);
            m.Abdomen = float.Parse(textBoxAbdomen.Text);
            m.Piernas = float.Parse(textBoxPiernas.Text);
            m.Pantorrillas = float.Parse(textBoxPantorrillas.Text);

            if (textBoxBiceps.Text == "" || textBoxTriceps.Text == "" || textBoxPectorales.Text == "" || textBoxAbdomen.Text == "" || textBoxPiernas.Text == "" || textBoxPantorrillas.Text == "")
            {
                MessageBox.Show("Debe de Completar Todos los Datos");
            }

        }
    }
}
