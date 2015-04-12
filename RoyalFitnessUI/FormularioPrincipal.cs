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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            LoginUsuario logUs = new LoginUsuario();
            logUs.ShowDialog();           
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsuario lu = new LoginUsuario();
            lu.Show();
        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.Show();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes rc = new RegistroClientes();
            rc.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pagos p = new Pagos();
            p.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tRoyalFitnes (Proyecto Final)\n\tProgramacion Aplicada I inc.\n\n\tJoel Olivares");
        }

        private void pagosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.cPagos p = new Consultas.cPagos();
            p.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.cUsuarios u = new Consultas.cUsuarios();
            u.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.cClientes c = new Consultas.cClientes();
            c.Show();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void medidasCorporalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMedidas m = new RegistroMedidas();
            m.Show();
        }
    }
}
