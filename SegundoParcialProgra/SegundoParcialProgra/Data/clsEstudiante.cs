using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SegundoParcialProgra.Data
{
    class clsEstudiante
    {
        private clsConnect Conn = new clsConnect();
        SqlDataReader reed;
        DataTable Tabla = new DataTable();
        SqlCommand Cmd = new SqlCommand();

        public DataTable Estudiantes()
        {
            Cmd.Connection = Conn.AbrirConexion();
            Cmd.CommandText = "SELECT * FROM Estudiantes";
            Cmd.CommandType = CommandType.Text;
            reed = Cmd.ExecuteReader();
            Tabla.Load(reed);
            Conn.CerrarConexion();
            return Tabla;

        }

        //Funcion para calcular un nuevo id de usuario
        public int idStudent()
        {
            Cmd.Connection = Conn.AbrirConexion();
            Cmd.CommandText = "SELECT MAX(id) FROM Estudiantes";
            Cmd.CommandType = CommandType.Text;
            int maxID = Convert.ToInt32(Cmd.ExecuteScalar());
            Conn.CerrarConexion();
            return maxID + 1;
        }

        //Registrando Estudiantes
        public void StudentReg(int id, string nombre, string Apellido, string Carrera, string Asignatura, double Promedio1, double Promedio2, double Promedio3, double PromedioFinal)
        {
            try
            {
                Cmd.Connection = Conn.AbrirConexion();
                Cmd.CommandText = "INSERT INTO Estudiantes(id, nombre, Apellido, Carrera, Asignatura, Promedio1, Promedio2, Promedio3, PromedioFinal) " +
                    "VALUES ('" + id + "','" + nombre + "','" + Apellido + "','" + Carrera + "','" + Asignatura + "'," +
                    "'" + Promedio1 + "' ,'" + Promedio2 + "' ,'" + Promedio3 + "','" + PromedioFinal + "')";
                Cmd.ExecuteNonQuery();
                Conn.CerrarConexion();
                MessageBox.Show("REGISTRO EXITOSO", ":D");
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE HA LOGRADO INGRESAR EL REGISTRO DEBIDO AL ERROR: " + ex.Message);

            }
        }
    }
}
