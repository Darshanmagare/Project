using System;
using Data_Access_Layer;
using Model;



namespace AMS
{
    class Appraisal
    {
        static void Main(string[] args)
        {

            DAL obj = new DAL();

            obj.DisplayEmployee();
            char choice = '\0';
            do
            {
            condition:


                Console.WriteLine("Do you Want to Insert Details of New Employee (A/a) :");
                Console.WriteLine("Do you Want to Edit Details of Employee (E/e) :");
                Console.WriteLine("Do you Want to Delete Details of Employee (D/d) :");
                Console.WriteLine("Do you Want to Give Appraisal to Employee (F/f) :");
                Console.WriteLine("DO YOU WANT TO SEE EMPLOYEES HAVING CURRENT ROLE AS INTERN AND NEW ROLE AS MANAGER (M/m)");
                Console.WriteLine("DO YOU WANT TO SEE EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL (U/u):");
                Console.WriteLine("DO YOU WANT TO SEE EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL(S/s):");
                Console.WriteLine("DO YOU WANT TO SEE EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL(N/n):");


                Console.Write("Give Input :");

                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'A' || ch == 'a')
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("INSERT NEW EMPLOYEE :");
                    Console.WriteLine("------------------------------------------------------------");
                    Employee emp = obj.GetInputFromUser();
                    obj.AddNewEmployee(emp);
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("------------Employee Details Inserted Successfully----------");

                    obj.DisplayEmployee();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                else if (ch == 'E' || ch == 'e')
                {

                    Console.WriteLine("EDIT EXISTING EMPLOYEE :");
                    Console.WriteLine("--------------------------------------------------------");
                    Employee editemp = obj.GetInputFromUser();
                    obj.EditEmployee(editemp);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("----------Employee Details Edited Successfully----------");

                    obj.DisplayEmployee();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());

                }
                else if (ch == 'D' || ch == 'd')
                {


                    Console.WriteLine("DELETE EMPLOYEE RECORD :");
                    Console.WriteLine("----------------------------------------------------");
                    Employee delemp1 = obj.Delete();
                    obj.DeleteEmployee(delemp1);
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("------Employee Details Deleted Successfully--------");

                    obj.DisplayEmployee();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());
                }

                else if (ch == 'F' || ch == 'f')
                {




                    Console.WriteLine("-----------------------EMPLOYEE APPRAISAL CALCULATION --------------------------:");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Employee appr = obj.CalAppraisal();
                    obj.AddAppraisal(appr);

                    Console.WriteLine("---------------------------------------------------------------------------------");

                    obj.DisplayEmployee();

                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());
                }

                else if (ch == 'M' || ch == 'm')
                {
                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                    Console.WriteLine("--------------------------");
                    obj.ShowDetails();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());
                }

                else if (ch == 'U' || ch == 'u')
                {
                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                    Console.WriteLine("--------------------------");
                    obj.ShowDetails1();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());

                }
                else if (ch == 'S' || ch == 's')
                {
                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                    Console.WriteLine("--------------------------");
                    obj.ShowDetails2();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());

                }
                else if (ch == 'N' || ch == 'n')
                {
                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                    Console.WriteLine("--------------------------");
                    obj.ShowDetails3();
                    Console.Write("Do you want to  continue(Y/y) :");
                    choice = Convert.ToChar(Console.ReadLine());


                }

                else
                {
                    Console.WriteLine("Please Select Correct Options :");
                    goto condition;

                }
            } while (choice == 'Y' || choice == 'y');
        }
    }
}
