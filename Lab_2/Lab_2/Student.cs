using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        public long Enrollment_No { get; set; }
        public string Student_Name { get; set; }
        public int Semester { get; set; }
        public double CPI { get; set; }
        public double SPI { get; set; }

        public Student(long Enrollment_No,string Student_Name,int Semester,double CPI,double SPI) 
        { 
            this.Enrollment_No = Enrollment_No;
            this.Student_Name = Student_Name;  
            this.Semester = Semester;
            this.CPI = CPI;
            this.SPI =SPI;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Enrollment_No = "+Enrollment_No);
            Console.WriteLine("Student Student_Name = " + Student_Name);
            Console.WriteLine("Student Semester = " + Semester);
            Console.WriteLine("Student CPI = " + CPI);
            Console.WriteLine("Student SPI = " + SPI);
        }
    }
}
