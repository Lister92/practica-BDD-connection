using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_connection
{
    class ConnectionBD
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public SqlConnection conectar;

        public ConnectionBD()
        {
            builder.DataSource= "46.183.116.173,54321";
            builder.InitialCatalog= "KevinEmpleados";
            builder.UserID = "sa";
            builder.Password = "123456789";
            conectar = new SqlConnection(builder.ConnectionString);
        }
        public void Connect()
        {
            conectar.Open();
        }   
        public void Disconnect()
        {
            conectar.Close();            
        }        
    }
}
