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

namespace RoyalFitnessUI.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void AceptarButtom_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            BLL.Clientes usrs = new BLL.Clientes();
            string criterio = BuscarButtom.Text;

            string BusquedaPor = string.Empty;

            if (BuscarPorcomboBox.SelectedItem.ToString() == "Nombres")
            {
                BusquedaPor = "Nombres";
            }
            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Apellidos")
            {
                BusquedaPor = "Apellidos";
            }
            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Cedula")
            {
                BusquedaPor = "Cedula";
            }

            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Fecha de ingreso")
            {
                BusquedaPor = "Fecha_ingreso";
            }

            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Telefono")
            {
                BusquedaPor = "Telefono";
            }

            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Fecha de ingreso")
            {
                BusquedaPor = "Fecha_ingreso";
            }

            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Tipo_Plan")
            {
                BusquedaPor = "Tipo_Plan";
            }



            string condicion = String.Format("{0} Like '%{1}%'", BusquedaPor, criterio);

            dataGridView1.DataSource = usrs.Listar("Nombres,Apellidos,Apellidos,Cedula,Fecha_ingreso,Tipo_Plan", condicion);
        }
    }
}
