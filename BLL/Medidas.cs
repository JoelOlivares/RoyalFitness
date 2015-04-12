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
    public class Medidas
    {

        ConexionDb Conexion = new ConexionDb();

        public int IdMedidas { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float Bicesp { get; set; }
        public float Triceps { get; set; }
        public float Pectorales { get; set; }
        public float Abdomen { get; set; }
        public float Piernas { get; set; }
        public float Pantorrillas { get; set; }
        public DateTime Fecha { get; set; }


        public  Medidas()
        {
            this.IdMedidas = 0;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Bicesp = 0;
            this.Triceps = 0;
            this.Abdomen = 0;
            this.Piernas = 0;
            this.Pantorrillas = 0;        
            this.Fecha = DateTime.Now;
        }

        public Boolean Insert()
        {
            this.IdMedidas = 0;
            this.IdMedidas = Convert.ToInt32(Conexion.EjecutarDB("Insert into Medidas(Nombre,Apellido,Bicesp,Triceps,Pectorales,Abdomen,Piernas,Pantorrillas,Fecha('"+this.Nombre+"','"+this.Apellido+"'," + this.Bicesp + "," + this.Triceps + "," + this.Pectorales + "," + this.Abdomen + "," + this.Piernas + "," + this.Pantorrillas + ",'" + this.Fecha + "') Select @@Identity"));
            return this.IdMedidas > 0;
        }

        public Boolean Modificar()
        {
            return Conexion.EjecutarDB("Update Medidas set Nombre='" + this.Nombre + "',Apellido='"+this.Apellido+"', Bicesp = " + this.Bicesp + ",Triceps =" + this.Triceps + ",Pectorales=" + this.Pectorales + "Abdomen =" + this.Abdomen + ",Piernas =" + this.Piernas + ",Pantorrillas =" + this.Pantorrillas + ",Fecha='" + this.Fecha + "'");
        }

        public Boolean Eliminar(Int32 IdBuscado)
        {
            return Conexion.EjecutarDB("Delete from Medidas where IdMedidas=" + IdBuscado);
        }

        public Boolean Buscar(Int32 IdBuscado)
        {
            bool Encontro = false;
            DataTable dt = new DataTable();

            dt = this.Listar("Medidas", "IdMedidas=" + IdBuscado);

            if (dt.Rows.Count > 0)
            {
                Encontro = true;

                this.IdMedidas = IdBuscado;
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellido = dt.Rows[0]["Apellido"].ToString();
                this.Bicesp = (float)dt.Rows[0]["Bicesp"];
                this.Triceps = (float)dt.Rows[0]["Triceps"];
                this.Pectorales = (float)dt.Rows[0]["Pectorales"];
                this.Abdomen = (float)dt.Rows[0]["Abdomen"];
                this.Piernas = (float)dt.Rows[0]["Piernas"];
                this.Pantorrillas = (float)dt.Rows[0]["Pantorrillas"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
              

            }

            return Encontro;
        }

        public DataTable Listar(string campos = "*", string Filtro = "1=1")
        {
            return Conexion.BuscarDb("Select " + campos + " from Medidas where " + Filtro);
        }

        public static DataTable GetPagos()
        {
            ConexionDb Conexion = new ConexionDb();
            return Conexion.BuscarDb("Select * from Medidas");
        }
    }
}
