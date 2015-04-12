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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Clientes rc = new Clientes();

            rc.Nombres = textBoxNombres.Text;
            rc.Apellidos = textBoxApellidos.Text;
            rc.Cedula = maskedTextBoxCedula.Text;
            rc.Direccion = textBoxDireccion.Text;
            rc.Telefono = maskedTextBoxTelefono.Text;
            rc.Sexo = comboBoxSexo.Text;
            rc.Edad = int.Parse(textBoxEdad.Text);
            rc.Tipo_Sangre = textBoxSangre.Text;
            rc.Tipo_Plan = comboBoxTipoPlan.SelectedItem.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();

            Abrir.Filter = "Archivos JPEG(*. jpg)|*.jpg";
            Abrir.InitialDirectory = "C:/Documents";

            if(Abrir.ShowDialog()==DialogResult.OK)
            {
                String Dir = Abrir.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap Piture = new Bitmap(Dir);

                pictureBox1.Image = (Image)Piture;
            }
        }

        private void buttonGuardar_Imagen_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             textBoxNombres.Clear();
             textBoxApellidos.Clear();
             maskedTextBoxCedula.Clear();
             textBoxDireccion.Clear();
             maskedTextBoxTelefono.Clear();             
             textBoxEdad.Clear();
             textBoxSangre.Clear();
             
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
