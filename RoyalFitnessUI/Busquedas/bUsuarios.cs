using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoyalFitnessUI.Busquedas
{
    public partial class bUsuarios : Form
    {

        public delegate void BuscaId(string valor);
        public event BuscaId eIdEncontrado;

        public bUsuarios()
        {
            InitializeComponent();
        }

        #region Eventos
        /// <summary>
        /// Evento del boton buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BLL.Usuarios usrs = new BLL.Usuarios();
            string criterio = txBxBusqueda.Text;
            string condicion = String.Format("(Nombres Like '%{0}%') OR (Apellidos Like '{1}')",criterio,criterio);
            
            dtGrVUsuarios.DataSource = usrs.Listar("IdUsuario,Nombres, Apellidos, Email, Usuario, Nivel_Acceso", condicion);
                
            
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            eIdEncontrado(dtGrVUsuarios.SelectedCells[0].Value.ToString());
            this.Hide();
            this.Dispose();
        }

        
    }
}
