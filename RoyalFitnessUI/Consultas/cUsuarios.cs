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
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void AceptarButtom_Click(object sender, EventArgs e)
        {
            
        }

        private void BuscarButtom_Click(object sender, EventArgs e)
        {
            BLL.Usuarios usrs = new BLL.Usuarios();
            string criterio = textBoxBusqueda.Text;

            string BusquedaPor = string.Empty;
            if (BuscarPorcomboBox.SelectedItem.ToString() == "Nombre")
            {
                BusquedaPor = "Nombres";
            }
            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Apellido")
            {
                BusquedaPor = "Apellidos";
            }
            else if (BuscarPorcomboBox.SelectedItem.ToString() == "Usuario")
            {
                BusquedaPor = "Usuario";
            }

            string condicion = String.Format("{0} Like '%{1}%'", BusquedaPor, criterio);

            dataGridView1.DataSource = usrs.Listar("IdUsuario,Nombres, Apellidos, Email, Usuario, Nivel_Acceso", condicion);
        }
    }
}
