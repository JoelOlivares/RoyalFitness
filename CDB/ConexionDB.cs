﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace CDB
{
    public class ConexionDb
    {
        //SqlConnection Conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FinanzasPersonalesDB;Integrated Security=True");
       
        //SqlConnection Conexion = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DataBase\RoyalFitness.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Conexion = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"" + Application.StartupPath + "\\DataBase\\RoyalFitness.mdf\";Integrated Security=True;Connect Timeout=30");        
       
        /// <summary>
        /// Ejecutar comandos a la base de datos, recuerde pasar solo los comandos que no retornan algun valor
        /// </summary>
        /// <param name="ComandoSql"></param>
        /// <returns></returns>
        public bool EjecutarDB(string ComandoSql)
        {

            bool Realizado = false;
            SqlCommand Comando = new SqlCommand();

            try
            {
                Conexion.Open(); // abrimos la conexion
                MessageBox.Show(ComandoSql);
                Comando.Connection = Conexion; //asignamos la conexion
                Comando.CommandText = ComandoSql;     //asignamos el comando
                Comando.ExecuteNonQuery(); // ejecutamos el comando

                Realizado = true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("ERROR :***********************: " + ex.Message + " ******************************************************");
                  MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                Conexion.Close(); //cerramos la conexion
            }

            return Realizado;
        }



        /// <summary>
        /// Ejecutar comandos que retornan algun resultset
        /// </summary>
        /// <param name="ComandoSql"></param>
        /// <returns></returns>
        public DataTable BuscarDb(string ComandoSql)
        {
            SqlDataAdapter Adapter;
            DataTable dt = new DataTable();

            try
            {
                Conexion.Open(); // abrimos la conexion
                Adapter = new SqlDataAdapter(ComandoSql, Conexion);

                Adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Conexion.Close(); //cerramos la conexion

            }
            return dt;
        }

        
        /// <summary>
        /// Permite obtener un valor escalar de la base de datos.
        /// </summary>
        /// <param name="ComandoSql">El comando que permite extaer el valor de la base de datos</param>
        /// <returns>Un objeto con el valor encontrado</returns>
        public Object ObtenerValorDb(string ComandoSql)
        {
            SqlCommand Command;
            Object objeto;

            try
            {

                Conexion.Open();
                Command = new SqlCommand(ComandoSql, Conexion);

                objeto = Command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR  2:***********************: " + ex.Message + " ******************************************************");
                throw;
            }
            finally
            {
                Conexion.Close(); //cerramos la conexion

            }

            return objeto;
        }


    }
}