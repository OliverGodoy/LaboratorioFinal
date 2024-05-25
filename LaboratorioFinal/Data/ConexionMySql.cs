using LaboratorioFinal.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioFinal.Data
{
    internal class ConexionMySql
    {
        //Cadena de conexión 
        string connectionString = "server=localhost;Database=db_universidad;Uid=root;Pwd=Lg_(098765)";
        private MySqlConnection connection;


        //constructor
        public ConexionMySql()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Insertar(model usr)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre de consola", usr.nombre_consola);
                cmd.Parameters.AddWithValue("@Compañia ", usr.compania );
                cmd.Parameters.AddWithValue("@Año de Lanzamiento", usr.anio_lanzamiento );
                cmd.Parameters.AddWithValue("@Generación", usr.generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<model> ObtenerTodosLosUsuarios()
        {
            List<model> usuarios = new List<model>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select * from catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        model usuario = new model
                        (
                            id: reader.GetInt32("ID"),
                            Nombre_consola: reader.GetString("Nombre de consola"),
                            Compania: reader.GetString("Compañia"),
                            Anio_lanzamiento: reader.GetDateTime("Año de Lanzamiento"),
                            Generacion: reader.GetInt32 ("Generacion")
                        );

                        usuarios.Add(usuario);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return usuarios;
        }
    }
}
