using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class StudentNamesList
    {
        public void GetStudentNamesList()
        {
            List<string> StudentNamesList = new List<string>();

            StudentNamesList.Add("Dhruvraj");
            StudentNamesList.Add("Dhairya");
            StudentNamesList.Add("Darshan");
            StudentNamesList.Add("Deven");
            StudentNamesList.Add("Dev");
            StudentNamesList.Add("Deven");
            StudentNamesList.Add("Parth");
            StudentNamesList.Add("haresh");
            StudentNamesList.Add("Vishal");

            //Add
            Console.WriteLine("After Add StudentName() : ");
            foreach (string studentName in StudentNamesList)
            {
                Console.WriteLine(studentName);
            }

            Console.WriteLine("===========================================");

            
            StudentNamesList.Remove("Dhairya");
            StudentNamesList.Remove("Dev");

            //Remove
            Console.WriteLine("After Remove StudentName() : ");
            foreach (string studentName in StudentNamesList)
            {
                Console.WriteLine(studentName);
            }

            Console.WriteLine("===========================================");


            StudentNamesList.RemoveRange(4, 2);
            StudentNamesList.RemoveRange(1, 1);

            //RemoveRange
            Console.WriteLine("After RemoveRange StudentName() : ");
            foreach (string studentName in StudentNamesList)
            {
                Console.WriteLine(studentName);
            }

            Console.WriteLine("===========================================");

            //Clear
            StudentNamesList.Clear();
        }
    }
}
