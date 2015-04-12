using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDB;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Login
    {
        ConexionDb Conexion = new ConexionDb();    

        public int IdLogin { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nivel_Acceso { get; set; }




        public Login()
        {
            this.IdLogin = 0;
            this.Usuario = string.Empty;
            this.Contrasena = string.Empty;
            this.Nivel_Acceso = string.Empty;
        }

        public Boolean Insert()
        {
            this.IdLogin = 0;
            this.IdLogin = Convert.ToInt32(Conexion.EjecutarDB("Insert Into Login (Usuario,Contrasena,Nivel_Acceso)  Values('" + this.Usuario + "','" + this.Contrasena + "','" + this.Nivel_Acceso +"') Select @@Identity"));
            return this.IdLogin > 0; 
        }

        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Login set Usuario = '" + this.Usuario + "', Contrasena='" + this.Contrasena + "', Nivel_Acceso='" + this.Nivel_Acceso + "' where IdLogin='" + this.IdLogin + "'");

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Login where IdLogin=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Usuario", "IdUsuario=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdLogin = IdBuscado;             
                this.Usuario = dt.Rows[0]["Usuario"].ToString();
               // this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                //this.Nivel_Acceso = dt.Rows[0]["Nivel_Acceso"].ToString();
            }

            return Encontro;
        }

     

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Login where " + Filtro);
        }

        public DataTable GetLogin()
        {
            return Conexion.BuscarDb("SELECT * FROM Usuarios WHERE (Usuario = '" + this.Usuario + "') AND (Contrasena = '" + this.Contrasena + "') AND (Nivel_acceso = '" + this.Nivel_Acceso + "')");                        
        }

    }
}
    