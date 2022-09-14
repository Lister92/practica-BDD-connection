using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDD_connection
{
    public partial class Form1 : Form
    {
        DalEmployees DalEmployees = new DalEmployees();
        public Form1()
        {
            InitializeComponent();
        }          
        
        private void butSubmit_Click(object sender, EventArgs e)
        {
            string name = this.textBoxName.Text;
            string surname = this.textBoxSname.Text;
            string email = this.textBoxEmail.Text;
            string telf = (string)this.telfBox.Text;
            DateTime fContrato = this.DatePicker.Value;
            int fkJob_id = (int)this.jobIdBox.Value;
            decimal salary = (decimal)this.SalaryBox.Value;
            int fkManager_id = (int)this.managerID.Value;
            int fkDepartment_id = (int)this.deptId.Value;

            Employees employees = new Employees(name, surname, email, fContrato, fkJob_id, salary, fkManager_id, fkDepartment_id);
            DalEmployees dalEmployee = new DalEmployees();
            dalEmployee.InsertEmployee(employees);
            ConnectionBD connection = new ConnectionBD();
            connection.Disconnect();            
        }

        private void MostrarTabla_Click(object sender, EventArgs e)
        {
            ListaEmpleados.Items.Clear();
            ListaEmpleados.Columns.Clear();
            List<Employees> empleados = DalEmployees.SelectEmployees();            
            ListaEmpleados.Columns.Add("IdEmp", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("Name", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("Surname", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("email", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("phone", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("HireDate", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("IdJob", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("Salary", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("ManagerId", 100, HorizontalAlignment.Center);
            ListaEmpleados.Columns.Add("DeptId", 100, HorizontalAlignment.Center);
            int i = 0;
            foreach (var item in empleados)
            {
                i++;
                ListViewItem lista = new ListViewItem(item.Employee_id.ToString());

                lista.SubItems.Add(item.First_name.ToString());
                lista.SubItems.Add(item.Last_name.ToString());
                lista.SubItems.Add(item.Email.ToString());

                if (item.PhoneNumber != null)
                {
                    lista.SubItems.Add(item.PhoneNumber.ToString());
                }

                else 
                {
                    item.PhoneNumber = "";
                    lista.SubItems.Add(item.PhoneNumber.ToString());
                }

                if (item.Date != null)
                { 
                    lista.SubItems.Add(item.Date.ToString());
                }

                lista.SubItems.Add(item.Fkjob_id.ToString());
                lista.SubItems.Add(item.Salary.ToString());
                lista.SubItems.Add(item.Fkmanager_id.ToString());
                lista.SubItems.Add(item.Fkdepartment_id.ToString());

                this.ListaEmpleados.Items.Add(lista);
            }
        }
        
        private void butBorrar_Click(object sender, EventArgs e)
        {
            DalEmployees.BorrarEmpleado(int.Parse(ListaEmpleados.SelectedItems[0].SubItems[0].Text));            
        }
    }
}
