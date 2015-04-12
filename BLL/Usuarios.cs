using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CDB;
using System.Data;

namespace BLL
{
    public class Usuarios
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdUsuario { get; set; }
        public string Nombre {get;set; }
        public string Apellido { get; set; }
        public string Email {get;set;}
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nivel_Acceso { get; set; }




        public Usuarios()
        {
            this.IdUsuario = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Email = string.Empty;      
            this.Usuario = string.Empty;
            this.Contrasena = string.Empty;
            this.Nivel_Acceso = string.Empty;
        }


        public Boolean Insert()
        {
            this.IdUsuario = 0;
            this.IdUsuario = Convert.ToInt32(Conexion.EjecutarDB("Insert Into Usuarios (Nombres,Apellidos,Email,Usuario,Contrasena,Nivel_Acceso)  Values('"+ this.Nombre+"','"+this.Apellido+"','"+this.Email+"','"+this.Usuario+"','"+this.Contrasena+"','"+this.Nivel_Acceso+"') Select @@Identity"));
            return this.IdUsuario > 0;
            
        }

        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Usuarios set Nombres = '"+this.Nombre+"', Apellidos ='" +this.Apellido+"',Email= '"+this.Email+"', Usuario = '"+this.Usuario+"', Contrasena='"+this.Contrasena+"', Nivel_Acceso='"+this.Nivel_Acceso+"' where IdUsuario=" + this.IdUsuario+"");

        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Usuario where IdUsuario=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("*", "IdUsuario=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;
               
                this.IdUsuario = IdBuscado;
                this.Nombre = dt.Rows[0]["Nombres"].ToString();
                this.Apellido = dt.Rows[0]["Apellidos"].ToString();
                this.Email = dt.Rows[0]["Email"].ToString();
                this.Usuario = dt.Rows[0]["Usuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                this.Nivel_Acceso = dt.Rows[0]["Nivel_Acceso"].ToString();
            }

            return Encontro;
        }

        

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("SELECT " + campos + " FROM Usuarios WHERE " + Filtro);
        }

        public static DataTable GetUsuario()
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select * from Usuario");
        }

        public bool GetLogin()
        {
            bool logeado = false;
            DataTable dt = Conexion.BuscarDb("SELECT * FROM Usuarios WHERE (Usuario = '" + this.Usuario + "') AND (Contrasena = '" + this.Contrasena + "') AND (Nivel_acceso = '" + this.Nivel_Acceso + "')");

            if (dt.Rows.Count > 0)
            {
                this.IdUsuario = Convert.ToInt32(dt.Rows[0]["IdUsuario"]);
                this.Nombre = dt.Rows[0]["Nombres"] as String;
                this.Apellido = dt.Rows[0]["Apellidos"] as String;
                this.Email = dt.Rows[0]["Email"] as String;
                logeado = true;
            }
            else
            {
                logeado = false;
            }
            return logeado;
        }


    }
}
