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
    public class Pagos
    {
        ConexionDb Conexion = new ConexionDb();

        public int IdPagos { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Mes { get; set; }
        public float Monto { get; set; }
        public string Tipo_Plan { get; set; }
        public string Concepto { get; set; }
        public string Tipo_Pago { get; set; }
        public float Total { get; set; }
        public DateTime Fecha { get; set; }


        public  Pagos()
        {
            this.IdPagos = 0;
            this.Nombre_Cliente = string.Empty;
            this.Mes = string.Empty;
            this.Monto = 0;
            this.Tipo_Plan = string.Empty;
            this.Concepto = string.Empty;
            this.Tipo_Pago = string.Empty;
            this.Total = 0;
            this.Fecha = DateTime.Now;
        }

        public Boolean Insert()
        {
            this.IdPagos = 0;
            this.IdPagos = Convert.ToInt32(Conexion.EjecutarDB("Insert into Pagos(Nombre_Cliente,Mes,Monto,Tipo_Plan,Concepto,Tipo_Pago,Total,Fecha('" + this.Nombre_Cliente + "','" + this.Mes + "',"+ this.Monto+ ",'" + this.Tipo_Plan+ "','" + this.Concepto+ "','" + this.Tipo_Pago + "'," + this.Total+",'"+this.Fecha+"') Select @@Identity"));
            return this.IdPagos > 0;
        }

        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Pagos set Nombre_Cliente = '" + this.Nombre_Cliente + "',Mes ='" + this.Mes + "',Monto =" + this.Monto + ",Tipo_Plan ='" + this.Tipo_Plan + "',Concepto ='" + this.Concepto + "', Tipo_Pago='" + this.Tipo_Pago + "', Total=" + this.Total + ",Fecha='" + this.Fecha + "', where IdPagos='"+this.IdPagos+ "'");
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Pagos where IdPagos=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Pagos", "IdPagos=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdPagos = IdBuscado;
                this.Nombre_Cliente = dt.Rows[0]["Nombre_Cliente"].ToString();
                this.Mes = dt.Rows[0]["Mes"].ToString();
                this.Monto = (float)dt.Rows[0]["Monto"];
                this.Tipo_Plan = dt.Rows[0]["Tipo_Plan"].ToString();
                this.Concepto = dt.Rows[0]["Concepto"].ToString();
                this.Tipo_Pago = dt.Rows[0]["Tipo_Pago"].ToString();
                this.Total = (float)dt.Rows[0]["Total"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
              

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Pagos where " + Filtro);
        }

        public static DataTable GetPagos()
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select * from Pagos");
        }

    }
}
