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
    class clsConnect
    {
        private SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-9HF2V7B;" + "Initial Catalog=RegistroNotas; Integrated Security=SSPI");
        public SqlConnection AbrirConexion()
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();

            }
            return sqlConn;
        }
        public SqlConnection CerrarConexion()
        {
            if (sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }
            return sqlConn;
        }
    }
}
