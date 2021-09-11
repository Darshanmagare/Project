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

            Console.WriteLine("Do you Want to Insert Details of New Employee (Y/N) :");
            char ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("INSERT NEW EMPLOYEE :");
                Console.WriteLine("------------------------------------------------------------");
                Employee emp = obj.GetInputFromUser();
                obj.AddNewEmployee(emp);
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("------------Employee Details Inserted Successfully----------");

                obj.DisplayEmployee();

                Console.WriteLine("Do you Want to Edit Details of the Employee (Y/N) :");
                ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'Y' || ch == 'y')
                {
                    Console.WriteLine("EDIT EXISTING EMPLOYEE :");
                    Console.WriteLine("--------------------------------------------------------");
                    Employee editemp = obj.GetInputFromUser();
                    obj.EditEmployee(editemp);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("----------Employee Details Edited Successfully----------");

                    obj.DisplayEmployee();

                    Console.WriteLine("Do you Want to Delete Employee Record : (Y/N) :");
                    ch = Convert.ToChar(Console.ReadLine());

                    if (ch == 'Y' || ch == 'y')
                    {
                        Console.WriteLine("DELETE EMPLOYEE RECORD :");
                        Console.WriteLine("----------------------------------------------------");
                        Employee delemp1 = obj.Delete();
                        obj.DeleteEmployee(delemp1);
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("------Employee Details Deleted Successfully--------");

                        obj.DisplayEmployee();



                        Console.WriteLine("Do you Want to Give Appraisal to Employee: (Y/N) :");
                        ch = Convert.ToChar(Console.ReadLine());

                        if (ch == 'Y' || ch == 'y')
                        {


                            Console.WriteLine("-----------------------EMPLOYEE APPRAISAL CALCULATION --------------------------:");
                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Employee appr = obj.CalAppraisal();
                            obj.AddAppraisal(appr);

                            Console.WriteLine("---------------------------------------------------------------------------------");

                            obj.DisplayEmployee();


                            Console.WriteLine("---------------------------------------------------------------------------------");
                            Console.WriteLine("---------------------------------------------------------------------------------");

                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                            Console.WriteLine("--------------------------");
                            obj.ShowDetails();


                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                            Console.WriteLine("--------------------------");
                            obj.ShowDetails1();

                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                            Console.WriteLine("--------------------------");
                            obj.ShowDetails2();

                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                            Console.WriteLine("--------------------------");
                            obj.ShowDetails3();

                        }

                    }
                    else
                    {
                        if (ch == 'N' || ch == 'n')
                        {
                            Console.WriteLine("Do you Want to Give Appraisal to Employee: (Y/N) :");
                            ch = Convert.ToChar(Console.ReadLine());

                            if (ch == 'Y' || ch == 'y')
                            {
                                Console.WriteLine("-----------------------EMPLOYEE APPRAISAL CALCULATION --------------------------:");
                                Console.WriteLine("---------------------------------------------------------------------------------");
                                Employee appr = obj.CalAppraisal();
                                obj.AddAppraisal(appr);

                                Console.WriteLine("---------------------------------------------------------------------------------");

                                obj.DisplayEmployee();


                                Console.WriteLine("---------------------------------------------------------------------------------");
                                Console.WriteLine("---------------------------------------------------------------------------------");

                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                                Console.WriteLine("--------------------------");
                                obj.ShowDetails();


                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                                Console.WriteLine("--------------------------");
                                obj.ShowDetails1();

                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                                Console.WriteLine("--------------------------");
                                obj.ShowDetails2();

                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                                Console.WriteLine("--------------------------");
                                obj.ShowDetails3();


                            }



                        }
                    
                    
                    }






                }
                else
                {
                    if (ch == 'N' || ch == 'n')
                    {
                        Console.WriteLine("Do you Want to Delete Employee Record : (Y/N) :");
                        ch = Convert.ToChar(Console.ReadLine());

                        if (ch == 'Y' || ch == 'y')
                        {
                            Console.WriteLine("DELETE EMPLOYEE RECORD :");
                            Console.WriteLine("------------------------------------------------------------------------------------------");
                            Employee delemp1 = obj.Delete();
                            obj.DeleteEmployee(delemp1);
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("----------Employee Details Deleted Successfully-------");

                            obj.DisplayEmployee();

                            Console.WriteLine("Do you Want to Give Appraisal to Employee: (Y/N) :");
                            ch = Convert.ToChar(Console.ReadLine());


                            if (ch == 'Y' || ch == 'y')
                            {

                                Console.WriteLine("-----------------------EMPLOYEE APPRAISAL CALCULATION ------------------------------:");
                                Console.WriteLine("------------------------------------------------------------------------------------");
                                Employee appr = obj.CalAppraisal();
                                obj.AddAppraisal(appr);

                                Console.WriteLine("------------------------------------------------------------------------------------");

                                obj.DisplayEmployee();


                                Console.WriteLine("--------------------------------------------------------------------------------------");
                                Console.WriteLine("-------------------------------------------------------------------" +
                                    "-------------------");

                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER :");
                                Console.WriteLine("--------------------------------------------------------------------------------------");
                                obj.ShowDetails();


                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                obj.ShowDetails1();

                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                obj.ShowDetails2();

                                Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                                Console.WriteLine("-------------------------------------------------------------------------------------");
                                obj.ShowDetails3();

                            }

                            Console.WriteLine("--------------------------------------------------------------------------------------------");
                            Console.WriteLine("--------------------------------------------------------------------------------------------");

                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                            Console.WriteLine("--------------------------------------------------------------------------------------------");
                            obj.ShowDetails();


                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                            Console.WriteLine("--------------------------------------------------------------------------------------------");
                            obj.ShowDetails1();

                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                            Console.WriteLine("--------------------------------------------------------------------------------------------");
                            obj.ShowDetails2();

                            Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                            Console.WriteLine("--------------------------------------------------------------------------------------------");
                            obj.ShowDetails3();



                        }
                        else
                        {
                            if (ch == 'N' || ch == 'n')
                            {

                                Console.WriteLine("Do you Want to Give Appraisal to Employee: (Y/N) :");
                                ch = Convert.ToChar(Console.ReadLine());

                                if (ch == 'Y' || ch == 'y')
                                {

                                    Console.WriteLine("-----------------------EMPLOYEE APPRAISAL CALCULATION ------------------------------:");
                                    Console.WriteLine("------------------------------------------------------------------------------------");
                                    Employee appr = obj.CalAppraisal();
                                    obj.AddAppraisal(appr);

                                    Console.WriteLine("------------------------------------------------------------------------------------");

                                    obj.DisplayEmployee();


                                    Console.WriteLine("--------------------------------------------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------------------------------------------");

                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER :");
                                    Console.WriteLine("--------------------------------------------------------------------------------------");
                                    obj.ShowDetails();


                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    obj.ShowDetails1();

                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    obj.ShowDetails2();

                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                                    Console.WriteLine("-------------------------------------------------------------------------------------");
                                    obj.ShowDetails3();

                                }
                                else
                                {
                                    if (ch == 'N' || ch == 'n')
                                    {
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                        obj.ShowDetails();


                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                                        Console.WriteLine("------------------------------------------------------------------------------------------");
                                        obj.ShowDetails1();

                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                                        Console.WriteLine("------------------------------------------------------------------------------------------");
                                        obj.ShowDetails2();

                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                                        obj.ShowDetails3();


                                    }
                                }
                            }

                        }
                        



                    }
                    
                }
            }
            else if (ch == 'N' || ch=='n')
            {
                Console.WriteLine("Do you Want to Edit Details of the Employee (Y/N) :");
                ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'Y' || ch == 'y')
                {
                    Console.WriteLine("EDIT EXISTING EMPLOYEE :");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Employee editemp = obj.GetInputFromUser();
                    obj.EditEmployee(editemp);
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                    Console.WriteLine("-------------------Employee Details Edited Successfully-------------------------------");
                }

                else
                {
                    if (ch == 'N' || ch == 'n')
                    {
                        Console.WriteLine("Do you Want to Delete Employee Record : (Y/N) :");
                        ch = Convert.ToChar(Console.ReadLine());

                        if (ch == 'Y' || ch == 'y')
                        {
                            Console.WriteLine("DELETE EMPLOYEE RECORD :");
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Employee delemp1 = obj.Delete();
                            obj.DeleteEmployee(delemp1);
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Console.WriteLine("---------------------Employee Details Deleted Successfully--------------------");

                            obj.DisplayEmployee();
                        }
                        else
                        {

                            if (ch == 'N' || ch == 'n')
                            {
                                Console.WriteLine("Do you Want to Give Appraisal to Employee: (Y/N) :");
                                ch = Convert.ToChar(Console.ReadLine());

                                if (ch == 'Y' || ch == 'y')
                                {

                                    Console.WriteLine("-----------------------EMPLOYEE APPRAISAL CALCULATION --------------------------:");
                                    Console.WriteLine("--------------------------------------------------------------------------------");
                                    Employee appr = obj.CalAppraisal();
                                    obj.AddAppraisal(appr);

                                    Console.WriteLine("--------------------------");

                                    obj.DisplayEmployee();


                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");

                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    obj.ShowDetails();


                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    obj.ShowDetails1();

                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    obj.ShowDetails2();

                                    Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                                    obj.ShowDetails3();

                                }
                                else
                                {
                                    if (ch == 'N' || ch == 'n')
                                    {
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                        Console.WriteLine("--------------------------------------------------------------------------------------------");
                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE IS INTERN AND NEW JOB ROLE IS MANAGER  :");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                                        obj.ShowDetails();


                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE CURRENT JOB ROLE AND NEW JOB ROLE IS NOT CHANGED AFTER GETTING APPRAISAL  :");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                                        obj.ShowDetails1();

                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE IS HAVING MAXIMUM APPRAISAL :");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                                        obj.ShowDetails2();

                                        Console.WriteLine("SHOWING EMPLOYEE RECORD WHOSE DID NOT HAVE APPRAISAL :");
                                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                                        obj.ShowDetails3();

                                    }




                                }




                            }
                        

                            


                        }



                    }


                }

            }

        }
    }
}
