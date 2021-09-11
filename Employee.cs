using System;
using System.Data;
using System.Data.SqlClient;


namespace Model
{
    public class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Dept { get; set; }
        public decimal Emp_Salary { get; set; }
        public string Current_Job_Role { get; set; }
        public string New_Job_Role { get; set; }
        public string DOJ { get; set; }
        public string Appraisal_Date { get; set; }
        public decimal SalAftAppr { get; set; }
    }
}
