using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_connection
{
    class Employees
    {
        int employee_id;
        string first_name;
        string last_name;
        string email;
        string phoneNumber;
        DateTime? date;
        int fkjob_id;
        decimal? salary;
        int? fkmanager_id;
        int? fkdepartment_id;

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime? Date { get => date; set => date = value; }
        public int Fkjob_id { get => fkjob_id; set => fkjob_id = value; }
        public decimal? Salary { get => salary; set => salary = value; }
        public int? Fkmanager_id { get => fkmanager_id; set => fkmanager_id = value; }
        public int? Fkdepartment_id { get => fkdepartment_id; set => fkdepartment_id = value; }

        public Employees(string ffirst_name, string flast_name, string femail, DateTime? fhire_date, int ffkJob_Id, decimal? fsalary, int? ffkManager_Id, int? ffkDepartment_Id)
        {
            first_name = ffirst_name;
            last_name = flast_name;
            email = femail;
            date = fhire_date;
            fkjob_id = ffkJob_Id;
            salary = fsalary;
            fkmanager_id = ffkManager_Id;
            fkdepartment_id = ffkDepartment_Id;
        }

        public Employees()
        {

        }
    }
}
