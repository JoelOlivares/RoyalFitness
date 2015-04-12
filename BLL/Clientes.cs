using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDB;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Clientes
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdClientes { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Foto { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Fecha_ingreso { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Tipo_Sangre { get; set; }
        public string Email { get; set; }
        public string Tipo_Plan { get; set; }


        public Clientes()
        {
            this.IdClientes = 0;
            this.Nombres = string.Empty;
            this.Apellidos = string.Empty;
            this.Cedula = string.Empty;
            this.Foto = string.Empty;
            this.Direccion = string.Empty;
            this.Edad = 0;
            this.Fecha_ingreso = string.Empty;
            this.Telefono = string.Empty;
            this.Sexo = string.Empty;
            this.Tipo_Sangre = string.Empty;
            this.Email = string.Empty;
            this.Tipo_Plan = string.Empty;
        }

        public Boolean Insert()
        {
            this.IdClientes = 0;
            this.IdClientes = Convert.ToInt32(Conexion.EjecutarDB("Insert into Clientes(Nombres,Apellidos,Cedula,Foto,Direccion,Edad,Fecha_ingreso,Telefono,Sexo,Tipo_Sangre,Email,Tipo_Plan) values('"+this.Nombres+"','"+this.Apellidos+"','"+this.Cedula+"','"+this.Foto+"','"+this.Direccion+"',"+this.Edad+",'"+this.Fecha_ingreso+"','"+this.Telefono+"','"+this.Sexo+"','"+this.Tipo_Sangre+"','"+this.Email+"','"+this.Tipo_Plan+"') Select @@Identity"));
           return this.IdClientes > 0;
        }

        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Clientes set Nombres = '"+this.Nombres+"',Apellidos ='"+this.Apellidos+"',Cedula ='"+this.Cedula+"',Foto ='"+this.Foto+"',Direccion ='"+this.Direccion+"', Edad="+this.Edad+", Fecha_ingreso='"+this.Fecha_ingreso+"',Telefono='"+this.Telefono+"', Sexo ='"+this.Sexo+"', Tipo_Sangre='"+this.Tipo_Sangre+"',Email='"+this.Email+"', Tipo_Plan='"+this.Tipo_Plan+"', where Id='"+this.IdClientes+"'");
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Clientes where IdClientes=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Clientes", "IdClientes=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdClientes = IdBuscado;
                this.Nombres = dt.Rows[0]["Nombres"].ToString();
                this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                this.Cedula = dt.Rows[0]["Cedula"].ToString();
                this.Foto = dt.Rows[0]["Foto"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Edad = (int)dt.Rows[0]["Edad"];
                this.Fecha_ingreso = dt.Rows[0]["Fecha_ingreso"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.Sexo = dt.Rows[0]["Sexo"].ToString();
                this.Tipo_Sangre = dt.Rows[0]["Tipo_Sangre"].ToString();
                this.Email = dt.Rows[0]["Email"].ToString();
                this.Tipo_Plan = dt.Rows[0]["Tipo_Plan"].ToString();
               
            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Clientes where " + Filtro);
        }

        public static DataTable GetClientes()
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select * from Clientes");
        }


    }
}