using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ConexionPstgSQL
{
    public class ConexionPostgrsql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id= postgres; Password = db204112; Database = prueba");

        public void Conectar()
        {
            conn.Open();
            MessageBox.Show("Conexión realizada!");
            
        }
        public void Desconectar()
        {
            conn.Close();
            MessageBox.Show("Se ha cerrado la conexión");
        }

        public DataTable Consultar()
        {
            string query = "select * from platzi.alumnos";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar(string nombre)
        {
            string query = "select * from platzi.alumnos where nombre like '"+nombre+"%'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void Agregar(int id, string nombre, string apellido, string email, double colegiatura)
        {
            string query = "insert into platzi.alumnos values ("
                + id + ", '"+ nombre + "', '" + apellido + "', '" + email + "',"
                + colegiatura + ")";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, conn);
            conn.Open();
            npgsqlCommand.ExecuteNonQuery();

            MessageBox.Show("¡Hecho!");
            conn.Close();
        }
        public void Actualizar(string nomActualizar, int id, string nombre, string apellido, string email, double colegiatura)
        {
            string query = "update platzi.alumnos set id = "
                + id + ", nombre = '" + nombre + "', apellido = '" + apellido + "', email = '"
                + email + "', colegiatura = " + colegiatura + " where nombre = '" + nomActualizar + "'";

            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, conn);
            conn.Open();
            npgsqlCommand.ExecuteNonQuery();

            MessageBox.Show("¡Actualizado correctamente!");
            conn.Close();
        }
        public void Eliminar(string nombre)
        {
            string query = "delete from platzi.alumnos where nombre = '" + nombre + "'";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(query, conn);
            conn.Open();
            npgsqlCommand.ExecuteNonQuery();

            MessageBox.Show("Se ha eliminado correctamente");
            conn.Close();

        }
    }
}
