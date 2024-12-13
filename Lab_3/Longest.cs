using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Longest
    {
        public string Name { get; set; }

        public void GetName()
        {
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
        }

        public void FindLongest()
        {
            string[] words = Name.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longest = "";
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            Console.WriteLine("Longest Word : "+longest);
        }
    }
}
