using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class StudentNames
    {
        public void GetStudentNames()
        {
            ArrayList StudentName = new ArrayList();
            StudentName.Add("Deven");
            StudentName.Add("Dhruvraj");
            StudentName.Add("Darshan");
            StudentName.Add("Dev");
            StudentName.Add("Haresh");
            StudentName.Add("Vishal");

            if (StudentName.Count == 0)
            {
                Console.WriteLine("ArrayList IS Empty");
            }
            else
            {
            //Add
            Console.WriteLine("Student List after Add():");
            foreach (var stu in StudentName)
            {
                Console.WriteLine(stu);
            }
            
            StudentName.Remove("Dev");
            StudentName.Remove("Haresh");
            Console.WriteLine("====================================================");
            
            //Remove
            Console.WriteLine("Student List after Remove StudentNames():");
            foreach (var stu in StudentName)
            {
                Console.WriteLine(stu);
            }
            
            StudentName.RemoveRange(3, 1); //first condition is for index and second till you want to remove
            Console.WriteLine("====================================================");

            //RemoveRange
            Console.WriteLine("Student List after RemoveRange():");
            foreach (var stu in StudentName)
            {
                Console.WriteLine(stu);
            }

            StudentName.Clear();
            Console.WriteLine("====================================================");
            
            //Clear
            Console.WriteLine("Student List after Clear():");
            }
        }
    }
}
