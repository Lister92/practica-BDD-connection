using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_connection
{
    class DalEmployees
    {
        ConnectionBD connection = new ConnectionBD();
        public void InsertEmployee(Employees employees)
        {
        try
            {
                connection.Connect();
                string cadena = "insert into employees values ('" + employees.First_name + "','" + employees.Last_name + "','" + employees.Email + "','" + employees.Date + "',1,'" + employees.Salary + "')";
                SqlCommand comando = new SqlCommand(cadena, connection.conectar);
                comando.ExecuteNonQuery();
            }
            catch (Exception b)
            {
                MessageBox.Show("Algo ha petado CRACK: " + b.Message);
            }
        }
        public List<Employees> SelectEmployees()
        {

            List<Employees> emps = new List<Employees>();
            Employees emp;

            try
            {
                string sql = "SELECT * FROM employees";
                SqlCommand cmd = new SqlCommand(sql, connection.conectar);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp = new Employees();
                    emp.Employee_id = (int)dr["employee_id"];
                    emp.First_name = (string)dr["first_name"];
                    emp.Last_name = (string)dr["last_name"];
                    emp.Email = (string)dr["email"];
                    emp.PhoneNumber = (int)dr["phone_number"];
                    emp.Date = (DateTime?)GestionarNulos(dr["hire_date"]);
                    emp.Fkjob_id = (int)GestionarNulos(dr["fkjob_id"]);
                    emp.Salary = (decimal?)GestionarNulos(dr["Salario"]);
                    emp.Fkmanager_id = (int)GestionarNulos(dr["fkmanager_id"]);
                    emp.Fkdepartment_id = (int?)GestionarNulos(dr["fkdepartment_id"]);



                    emps.Add(emp);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Submit: " + ex.Message);
            }

            return emps;

        }
         public object GestionarNulos(object valOriginal)
        {
            if (valOriginal == System.DBNull.Value)
                return null;
            else 
                return valOriginal;
        }
    }
}
