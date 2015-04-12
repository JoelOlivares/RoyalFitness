using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;




namespace RoyalFitnessUI
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Close();
            Application.Exit();
        }

        private void button_acecptar_Click(object sender, EventArgs e)
        {


            Usuarios usrs = new Usuarios();

            usrs.Usuario = textBoxUsuario.Text;
            usrs.Contrasena = textBox_contrasena.Text;
            usrs.Nivel_Acceso = comboBoxNivel.SelectedItem.ToString();
            if (usrs.GetLogin())
            {
                this.Dispose();
            }
            else {
                MessageBox.Show(this, "Credenciasles Incorrectas", "Entrar al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }
      
          
   

        private void comboBoxlogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
