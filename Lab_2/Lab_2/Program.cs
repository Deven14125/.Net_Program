using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A1
            //Write a program to create a class named Candidate with ID, Name, Age,
            //Weight and Height as data members & also create a member functions like
            //GetCandidateDetails() and DisplayCandidateDetails(). 

            //Candidate candidate = new Candidate();
            //candidate.GetCandidateDetails();
            //candidate.DisplayCandidateDetails();


            //A2
            //Write a program to create a class Staff having data members as Name,
            //Department, Designation, Experience & Salary.Accept this data for 5
            //different staffs and display only names & salary of those staff who are HOD.

            //Staff[] staff = new Staff[2];

            //for (int i = 0; i < staff.Length; i++) {
            //    staff[i] = new Staff();
            //    staff[i].GetStaffDetails();
            //    staff[i].DisplayDetail();
            //}



            //A3
            //Write a pogram to Create a class Bank_Account with Account_No, Email,
            //User_Name, Account_Type and Account_Balance as data members.Also
            //create a Member function GetAccountDetails() &DisplayAccountDetails().

            //BankAccount account = new BankAccount();
            //account.GetAccountDetails();
            //account.DisplayAccountDetails();


            //A4
            //Write a program with following specifications:
            //Class Name: Student
            //Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
            //Get Students Details using constructor and DisplayStudentDetails() using
            //member function.

            //Student student1 = new Student(23010101154, "Deven", 4, 8.92, 9.71);
            //Student student2 = new Student(23010101397, "Dhruvraj", 4, 8.25, 8.33);
            //student1.DisplayStudentDetails();
            //student2.DisplayStudentDetails();


            //A5
            //Write a program to calculate area of a Rectangle using constructor.

            //Rectangle rectangle1 = new Rectangle(45, 41);
            //Rectangle rectangle2 = new Rectangle(12, 20);

            //rectangle1.Area();
            //rectangle2.Area();


            //A6
            //Write a program for implementing single inheritance which creates one
            //class Account_Details for getting account information and another class
            //Interest for calculating and displaying total interest from the data inserted
            //from account details.

            //Account_Details account = new Account_Details();
            //account.GetAccountDetails(); this is not recommended

            //Interest interest = new Interest();
            //interest.GetAccountDetails();
            //interest.CalculateInterest();


            //B7
            //Write a program to Define a class Salary which will contain member
            //variable Basic, TA, DA, HRA. Write a program using Constructor with default
            //values for DA and HRA and calculate the salary of employee.

            //Salary empSalary = new Salary(5000,4000);
            //empSalary.CalculateTotalSalary();


            //B8
            //Write a program to Define a class Distance have data members dist1, dist2,
            //dist3.Initialize the two data members using constructor and store their
            //addition in third data member using function and display addition.

            //Distance distance = new Distance(45,25);
            //distance.Addition();


            //C9
            //Create a class Furniture with material ,price as data members. Create
            //another class Table with Height, surface_area as data members.Write a
            //program to implement single inheritance.

            //Table table = new Table();
            //table.GetFurnitureDetails();
            //table.GetTableDetails();

            //table.DisplayAllDetails();



            //C10
            //
        }
    }
}
