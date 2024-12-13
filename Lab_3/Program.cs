using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A1
            //Write a program to Create a divide by zero exception and handle it.

            //DivideZero divideZero = new DivideZero();
            //try
            //{
            //    divideZero.GetNumber();
            //    divideZero.DivideByZero();
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot Divide By Zero");
            //    Console.WriteLine("Exception Occured Please Enter Correct Divider");
            //}
            
            //A2
            //Write a program that reads 5 numbers from user. Demonstrate concept of IndexOutOfRange Exception.

            //Demonstrate[] demo = new Demonstrate[5];
            //try
            //{
            //    for (int i = 0; i <= demo.Length; i++)
            //    {
            //        demo[i] = new Demonstrate();
            //        demo[i].ReadnNumber();
            //        demo[i].ShowNumber();
            //    }
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index Out Of Bound Exception Occured");
            //}

            //A3
            //Write a program to create an abstract class Sum having abstract methods
            //SumOfTwo(int a, int b) and SumOfThree(int a, int b, int c). Create another
            //class Calculate which extends the abstract class and implements the abstract methods.

            //Calculate calculate = new Calculate();
            //calculate.SumOfTwo(47,47);
            //calculate.SumOfThree(12,14,16);

            //A4
            //Write a program to create interface Calculate. In this interface we have two
            //member functions Addition() and Subtraction(). Implements this interface
            //in another class named Result.

            //Result result = new Result();
            //result.Addition(14,15);
            //result.Subtraction(45,22);


            //A5
            //Write program showing use of common methods of String class.

            //StringMethods stringMethods = new StringMethods();
            //stringMethods.GetInput();
            //stringMethods.CommonStringMethods();

            //B6
            //Write a program to Replace lower case characters to upper case and Vice - versa.

            //LowerUpper LU = new LowerUpper();
            //LU.GetDetail();
            //LU.ToLowerCase();
            //LU.ToUpperCase();

            //B7
            //Write a program to create interface named Shape. In this interface, we
            //have three methods Circle(), Triangle() and Square() which calculates area
            //of Circle, Triangle and Square respectively. Implement Shape interface.

            //AreaCalculate areaCalculate = new AreaCalculate();
            //areaCalculate.Circle(2);
            //areaCalculate.Square(5);
            //areaCalculate.Triangle(50,20);

            //B8
            //Write a program to accept a number from the user and throw an exception
            //if the number is not an even number.

            //EvenNumCheck evenNumCheck = new EvenNumCheck();
            //try
            //{
            //    evenNumCheck.GetNum();
            //    evenNumCheck.CheckEvenOrNot();
            //}
            //catch (Exception)
            //{
            //    throw new Exception("Please Enter a Number That is Even");
            //}

            //C9
            //Write a program to find the longest word in a string.

            Longest  longest = new Longest();
            longest.GetName();
            longest.FindLongest();

            //C10
            //Write a program to change the case of entered character.

            //ChangeCase changeCase = new ChangeCase();
            //changeCase.GetChar();
            //changeCase.Changecase();
        }
    }
}
