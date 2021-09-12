using System;
using System.Data;
using System.Data.SqlClient;
using Model;


namespace Data_Access_Layer
{
    public class DAL
    {
        static string constr = "data source=DARSHAN\\SQLEXPRESS;initial catalog = EAMS;integrated security = true";
        public void DisplayEmployee()
        {
            DataTable dt = ExecuteData("select * from EMPLOYEE_TABLE");
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("===================================================================================================================================================================");
                Console.WriteLine("DataBase Records");
                Console.WriteLine("===================================================================================================================================================================");

                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine("{0,5} | {1,-20} | {2,-10} | {3,10} | {4,-20} | {5,-20} | {6,-10} | {7,-10} | {8,10}",row["Emp_Id"].ToString(),row["Emp_Name"].ToString(),row["Emp_Dept"].ToString()
                        ,row["Emp_Salary"].ToString(),row["Current_Job_Role"].ToString(),row["New_Job_Role"].ToString(),row["DOJ"].ToString(),row["Appraisal_Date"].ToString(),row["SalAftAppr"].ToString());
                }

                Console.WriteLine("====================================================================================================================================================================" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("No employee found in the database table ....");
                Console.WriteLine(Environment.NewLine);
            }
        }

        public DataTable ExecuteData(string query)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))  //This block will release the memory when object is not in use
                {
                    sqlcon.Open();

                    SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);   //Disconnected Architecture
                    da.Fill(result);
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public bool ExecuteCommand(string query)
        {
            DataTable result = new DataTable();
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(constr))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(query, sqlcon);
                    sqlcmd.ExecuteNonQuery();       //It Executes the DML Queries
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
            return true;
        }



        public void AddNewEmployee(Employee employee)
        {

            ExecuteCommand(string.Format("Insert into EMPLOYEE_TABLE(Emp_Id,Emp_Name,Emp_Dept,Emp_Salary,Current_Job_Role,DOJ)" +
                " values({0},'{1}','{2}',{3},'{4}','{5}')", employee.Emp_Id, employee.Emp_Name, employee.Emp_Dept, employee.Emp_Salary, employee.Current_Job_Role
                , employee.DOJ));

        }



        public void EditEmployee(Employee employee)
        {

            ExecuteCommand(string.Format("Update EMPLOYEE_TABLE set Emp_Name='{0}',Emp_Dept='{1}',Emp_Salary='{2}',Current_Job_Role='{3}',DOJ='{4}' where Emp_Id='{5}'",
               employee.Emp_Name, employee.Emp_Dept, employee.Emp_Salary, employee.Current_Job_Role, employee.DOJ, employee.Emp_Id));


        }


        public void AddAppraisal(Employee employee)
        {

            ExecuteCommand(string.Format("Update EMPLOYEE_TABLE set Emp_Name='{0}',Emp_Dept='{1}',Emp_Salary='{2}',Current_Job_Role='{3}',New_Job_Role='{4}',Appraisal_Date='{5}',SalAftAppr='{6}' where Emp_Id='{7}'",
              employee.Emp_Name, employee.Emp_Dept, employee.Emp_Salary, employee.Current_Job_Role
               , employee.New_Job_Role,employee.Appraisal_Date, employee.SalAftAppr, employee.Emp_Id));
        }


        public Employee CalAppraisal()
        {
            int Emp_Id;
            string Emp_Name = string.Empty;
            string Emp_Dept = string.Empty;
            decimal Emp_Salary;
            string Current_Job_Role = string.Empty;
            string New_Job_Role = string.Empty;
            string Appraisal_Date;
            decimal SalAftAppr;




            Console.WriteLine("===================================================================================================================================================================");
            Console.WriteLine("Enter the Employee ID: ");
            Emp_Id = Convert.ToInt32(Console.ReadLine());
            



            Console.WriteLine("Enter the Employee Name: ");
            Emp_Name = Console.ReadLine();
            while (string.IsNullOrEmpty(Emp_Name))
            {
                Console.WriteLine("------Employee name cannot be blank--------");
                Console.WriteLine("------Enter Employee Name Once Again-------");
                Emp_Name = Console.ReadLine();
            }



            Console.WriteLine("Enter the Employee Department: ");
            Emp_Dept = Console.ReadLine();
            while (string.IsNullOrEmpty(Emp_Dept))
            {
                Console.WriteLine("------Employee Department cannot be blank!!--------");
                Console.WriteLine("------Enter Employee Department Once Again :-------");
                Emp_Dept = Console.ReadLine();
            }

            Console.WriteLine("Enter the Employee Salary: ");
            Emp_Salary = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Enter the Current Job Role: ");
            Current_Job_Role = Console.ReadLine();
            while (string.IsNullOrEmpty(Current_Job_Role))
            {
                Console.WriteLine("------This Field cannot be blank---------------------");
                Console.WriteLine("------Enter Employee Current Job Role Once Again-----");
                Current_Job_Role = Console.ReadLine();
            }

            Console.WriteLine("Enter the New Job Role: ");
            New_Job_Role = Console.ReadLine();
            while (string.IsNullOrEmpty(New_Job_Role))
            {
                Console.WriteLine("------This Field cannot be blank------------------");
                Console.WriteLine("------Enter Employee New Job Role Once Again------");
                New_Job_Role = Console.ReadLine();
            }


            Console.WriteLine("Enter the Appraisal Date: (---Please Enter the DATE FORMAT as YYYY-MM-DD---) ");
            Appraisal_Date = Console.ReadLine();


            Console.WriteLine("Enter how much percentage appraisal you want to give :");
            decimal per = Convert.ToDecimal(Console.ReadLine());

            SalAftAppr = (Emp_Salary * per / 100) + Emp_Salary;


            Console.WriteLine("The Appraisal After Calculation is :" + SalAftAppr);


            Employee employee = new Employee()
            {
                Emp_Id = Emp_Id,
                Emp_Name = Emp_Name,
                Emp_Dept = Emp_Dept,
                Emp_Salary = Emp_Salary,
                Current_Job_Role = Current_Job_Role,
                New_Job_Role = New_Job_Role,
                Appraisal_Date = Appraisal_Date,
                SalAftAppr=SalAftAppr

            };


            return employee;


        }



        /*
        public void DeleteEmployee()
        {
            string eno = string.Empty;
            Console.WriteLine("DELETE EXISTING EMPLOYEE: ");

            Console.WriteLine("Enter Employee No:");
            eno = Console.ReadLine();

            ExecuteCommand(string.Format("delete from emp where eno='{0}'", eno));
            Console.WriteLine("Employee details delted from the Database !" + Environment.NewLine);
        }*/

        public void DeleteEmployee(Employee employee)
        {

            ExecuteCommand(string.Format("delete from EMPLOYEE_TABLE where Emp_Id='{0}'", employee.Emp_Id));
            Console.WriteLine("Employee details deleted from the Database !" + Environment.NewLine);

        }

        public Employee GetInputFromUser()
        {
            int Emp_Id;
            string Emp_Name = string.Empty;
            string Emp_Dept = string.Empty;
            decimal Emp_Salary;
            string Current_Job_Role = string.Empty;
            string New_Job_Role = string.Empty;
            string DOJ;


            Console.WriteLine("===================================================================================================================================================================");
            Console.WriteLine("Enter the Employee ID: ");
            Emp_Id = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("Enter the Employee Name: ");
                Emp_Name = Console.ReadLine();
                while(string.IsNullOrEmpty(Emp_Name))
                {
                     Console.WriteLine("------Employee name cannot be blank--------");
                     Console.WriteLine("------Enter Employee Name Once Again-------");
                     Emp_Name = Console.ReadLine();
                }
                
            

            Console.WriteLine("Enter the Employee Department: ");
            Emp_Dept = Console.ReadLine();
            while (string.IsNullOrEmpty(Emp_Dept))
            {
                Console.WriteLine("------Employee Department cannot be blank!!-------");
                Console.WriteLine("------Enter Employee Department Once Again :------");
                Emp_Dept = Console.ReadLine();
            }

            Console.WriteLine("Enter the Employee Salary: ");
            Emp_Salary = Convert.ToDecimal(Console.ReadLine());
            

            Console.WriteLine("Enter the Current Job Role: ");
            Current_Job_Role = Console.ReadLine();
            while (string.IsNullOrEmpty(Current_Job_Role))
            {
                Console.WriteLine("------This Field cannot be blank------");
                Console.WriteLine("-----Enter Employee Current Job Role Once Again-----");
                Current_Job_Role = Console.ReadLine();
            }


            Console.WriteLine("Enter the Date Of Joining: (---Please Enter the DATE FORMAT as YYYY-MM-DD---) ");
            DOJ =Console.ReadLine();


            Employee employee = new Employee()
            {
                Emp_Id = Emp_Id,
                Emp_Name = Emp_Name,
                Emp_Dept = Emp_Dept,
                Emp_Salary = Emp_Salary,
                Current_Job_Role = Current_Job_Role,
                New_Job_Role = New_Job_Role,
                DOJ = DOJ,
           
            };


            return employee;
        }

        public Employee Delete()
        {
            int Emp_Id;

            Console.WriteLine("Enter the Employee ID: ");
            Emp_Id = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee()
            {
                Emp_Id = Emp_Id,

            };
            return employee;
        }


        public void ShowDetails()
        {
            DataTable dt = ExecuteData("Select * from EMPLOYEE_TABLE where Current_Job_Role='Intern' and New_Job_Role='Manager'");
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("===================================================================================================================================================================");
                Console.WriteLine("DataBase Records");
                Console.WriteLine("===================================================================================================================================================================");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["Emp_Id"].ToString() + " " + row["Emp_Name"].ToString() + " " + row["Emp_Dept"].ToString()
                        + " " + row["Emp_Salary"].ToString() + " " + row["Current_Job_Role"].ToString() + " " + row["New_Job_Role"].ToString() + " " + row["DOJ"].ToString() + " " + row["Appraisal_Date"].ToString() + " " + row["SalAftAppr"].ToString());
                }

                Console.WriteLine("===================================================================================================================================================================" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("No employee found in the database table ....");
                Console.WriteLine(Environment.NewLine);
            }
        }

            public void ShowDetails1()
            {
                DataTable dt = ExecuteData("Select * from EMPLOYEE_TABLE where Current_Job_Role='Junior Associate' and New_Job_Role='Junior Associate'");
                if (dt.Rows.Count > 0)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("==================================================================================================================================================================");
                    Console.WriteLine("DataBase Records");
                    Console.WriteLine("=================================================================================================================================================================");

                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine(row["Emp_Id"].ToString() + " " + row["Emp_Name"].ToString() + " " + row["Emp_Dept"].ToString()
                            + " " + row["Emp_Salary"].ToString() + " " + row["Current_Job_Role"].ToString() + " " + row["New_Job_Role"].ToString() + " " + row["DOJ"].ToString() + " " + row["Appraisal_Date"].ToString() + " " + row["SalAftAppr"].ToString());
                    }

                    Console.WriteLine("==================================================================================================" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("No employee found in the database table ....");
                    Console.WriteLine(Environment.NewLine);
                }
            }

        public void ShowDetails2()
        {
            DataTable dt = ExecuteData("Select Emp_Id,Emp_Name,SalAftAppr from EMPLOYEE_TABLE where SalAftAppr=(Select max(SalAftAppr) from EMPLOYEE_TABLE where SalAftAppr IS NOT NULL)");
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("===================================================================================================================================================================");
                Console.WriteLine("DataBase Records");
                Console.WriteLine("===================================================================================================================================================================");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["Emp_Id"].ToString() + " " + row["Emp_Name"].ToString() + " " + row["SalAftAppr"].ToString());
                }

                Console.WriteLine("=====================================================================================================" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("No employee found in the database table ....");
                Console.WriteLine(Environment.NewLine);
            }
        }

        public void ShowDetails3()
        {
            DataTable dt = ExecuteData("Select * from EMPLOYEE_TABLE where SalAftAppr is NULL");
            if (dt.Rows.Count > 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("===================================================================================================================================================================");
                Console.WriteLine("DataBase Records");
                Console.WriteLine("===================================================================================================================================================================");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["Emp_Id"].ToString() + " " + row["Emp_Name"].ToString() + " " + row["Emp_Dept"].ToString()
                        + " " + row["Emp_Salary"].ToString() + " " + row["Current_Job_Role"].ToString() + " " + row["New_Job_Role"].ToString() + " " + row["DOJ"].ToString() + " " + row["Appraisal_Date"].ToString() + " " + row["SalAftAppr"].ToString());
                }

                Console.WriteLine("==================================================================================================================================================================" + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("No employee found in the database table ....");
                Console.WriteLine(Environment.NewLine);
            }
        }

    }
}
