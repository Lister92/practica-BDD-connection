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
            string cadena = "INSERT INTO employees values ('" + employees.First_name + "','" + employees.Last_name + "','" + employees.Email + "','" + employees.PhoneNumber + "','" + employees.Date + "','" + employees.Fkjob_id + "','" + employees.Salary + "','" + employees.Fkmanager_id + "','" + employees.Fkdepartment_id + "')";
            try
            {
                connection.Connect();
                SqlCommand comando = new SqlCommand(cadena, connection.conectar);
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario creado");
            }
            catch (Exception b)
            {
                MessageBox.Show("Algo ha petado CRACK: " + b.Message);
            }
            finally
            {               
                connection.Disconnect();
            }
        }
        public List<Employees> SelectEmployees()
        {

            List<Employees> emps = new List<Employees>();
            Employees emp;

            try
            {
                connection.Connect();
                
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

                    emp.PhoneNumber = (string)GestionarNulos(dr["phone_number"]);

                    emp.Date = (DateTime?)GestionarNulos(dr["hire_date"]);
                    emp.Fkjob_id = (int)GestionarNulos(dr["fkjob_id"]);
                    emp.Salary = (decimal?)GestionarNulos(dr["salary"]);

                    emp.Fkmanager_id = (int?)GestionarNulos(dr["fkmanager_id"]);

                    emp.Fkdepartment_id = (int?)GestionarNulos(dr["fkdepartment_id"]);
                    emps.Add(emp);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Submit: " + ex.Message);
            }
            finally
            {
                connection.Disconnect();            
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

        public void BorrarEmpleado(int id)
        {
            try
            {
                connection.Connect();

                string sql = "DELETE FROM employees WHERE employee_id =" + id;
                SqlCommand cmd = new SqlCommand(sql, connection.conectar);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha borrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Submit: " + ex.Message);
            }
            finally
            {
                connection.Disconnect();
            }
        }
    }
}
