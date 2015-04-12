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
    //Prueba
{
    public partial class RegistroUsuario : Form
    {

        private int idEncontrado = 0;
        private bool nuevoUsuario = true;
       

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (nuevoUsuario)
            {
                guardaNuevoUsuario();
            }
            else {
                actualizaUsuario();
            }
        }

        private void guardaNuevoUsuario()
        {
            Usuarios u = new Usuarios();
            u.Nombre = textBoxNombres.Text;
            u.Apellido = textBoxApellidos.Text;
            u.Usuario = textBoxUsuario.Text;
            u.Email = textBoxEmail.Text;
            u.Contrasena = textBoxContrasena.Text;
            u.Nivel_Acceso = comboBoxNivel.SelectedItem.ToString();

            if (textBoxContrasena.Text == textBoxConfirmarContrasena.Text)
            {
                u.Insert();
            }
            else
            {
                MessageBox.Show("Las Contraseñas No Coinsiden:");
            }

            if (textBoxNombres.Text == "" || textBoxApellidos.Text == "" || textBoxUsuario.Text == "" || textBoxEmail.Text == "" || textBoxContrasena.Text == "" || textBoxConfirmarContrasena.Text == "" || comboBoxNivel.Text == "")
            {
                MessageBox.Show("Debe de Completar Todos los Datos");
            }

            u.Nombre = textBoxNombres.Text = "";
            u.Apellido = textBoxApellidos.Text = "";
            u.Usuario = textBoxUsuario.Text = "";
            u.Email = textBoxEmail.Text = "";
            u.Contrasena = textBoxContrasena.Text = "";
            textBoxConfirmarContrasena.Text = "";
            u.Nivel_Acceso = comboBoxNivel.Text = "Seleccionar Nivel";
        }

        private void actualizaUsuario()
        {
            Usuarios u = new Usuarios();
            u.IdUsuario = idEncontrado;
            u.Nombre = textBoxNombres.Text;
            u.Apellido = textBoxApellidos.Text;
            u.Usuario = textBoxUsuario.Text;
            u.Email = textBoxEmail.Text;
            u.Contrasena = textBoxContrasena.Text;
            u.Nivel_Acceso = comboBoxNivel.SelectedItem.ToString();

            if (textBoxContrasena.Text == textBoxConfirmarContrasena.Text)
            {
                u.Modificar();
            }
            else
            {
                MessageBox.Show("Las Contraseñas No Coinsiden:");
            }

            if (textBoxNombres.Text == "" || textBoxApellidos.Text == "" || textBoxUsuario.Text == "" || textBoxEmail.Text == "" || textBoxContrasena.Text == "" || textBoxConfirmarContrasena.Text == "" || comboBoxNivel.Text == "")
            {
                MessageBox.Show("Debe de Completar Todos los Datos");
            }

            u.Nombre = textBoxNombres.Text = "";
            u.Apellido = textBoxApellidos.Text = "";
            u.Usuario = textBoxUsuario.Text = "";
            u.Email = textBoxEmail.Text = "";
            u.Contrasena = textBoxContrasena.Text = "";
            textBoxConfirmarContrasena.Text = "";
            u.Nivel_Acceso = comboBoxNivel.Text = "Seleccionar Nivel";
        }

      
             private void RegistroUsuario_Load(object sender, EventArgs e)
             {

             }

             private void buttonCancelar_Click(object sender, EventArgs e)
             {
                 Close();       
             }

             private void button1_Click(object sender, EventArgs e)
             {
                 textBoxNombres.Clear();
                 textBoxApellidos.Clear();
                 textBoxUsuario.Clear();
                 textBoxEmail.Clear();
                 textBoxContrasena.Clear();
                 textBoxConfirmarContrasena.Clear();
                 comboBoxNivel.Text = "Seleccionar Nivel";
                 nuevoUsuario = true;                 
             }

             private void button2_Click(object sender, EventArgs e)
             {
                 
                 Busquedas.bUsuarios busUs = new Busquedas.bUsuarios();
                 busUs.eIdEncontrado += idEnc;                 
                 
                 busUs.ShowDialog();
             }


             private void idEnc(string valor) {
                 if (valor.Length > 0 && valor != string.Empty)
                 {
                     idEncontrado = Convert.ToInt32(valor);
                     Usuarios us = new Usuarios();
                     if (us.Buscar(idEncontrado)) {
                         textBoxNombres.Text = us.Nombre;
                         textBoxApellidos.Text = us.Apellido;
                         textBoxUsuario.Text = us.Usuario;
                         textBoxEmail.Text = us.Email;
                         textBoxContrasena.Text = us.Contrasena;
                         textBoxConfirmarContrasena.Text =us.Contrasena;
                         comboBoxNivel.Text = us.Nivel_Acceso;
                         nuevoUsuario = false;
                     }

                 }
                 
             }


            
           
        
    }
}
