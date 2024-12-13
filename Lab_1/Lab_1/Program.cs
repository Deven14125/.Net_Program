using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //A1 
            // Write a program to print your name, address, contact number & city.

            Console.WriteLine("Deven Machchhar");
            Console.WriteLine("Yadunandan Park-2,Near Umiya Circle");
            Console.WriteLine("1234567890");
            Console.WriteLine("Morbi");

            //A2 
            // Write a program to get two numbers from user and print those two numbers.

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered: " + num1 + " and " + num2);

            //A3
            // Write program to prompt a user to input his/her name and country name
            // and then output will be shown as given: Hello<yourname> from country
            // <countryname>

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Country Name: ");
            string country = Console.ReadLine();

            Console.WriteLine("Hello " + name + " from Country " + country);

            //A4
            // Write a program to calculate the size of the area in square-feet based on
            // Specified length and width

            Console.Write("Enter the length (in feet): ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width (in feet): ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("The area is: " + area + " square feet.");


            //A5
            // Write a program to calculate area of Square, Rectangle and Circle.


            //Area OF Square

            Console.Write("Enter Length: ");
            double len = Convert.ToDouble(Console.ReadLine());

            double areaSquare = len * len;

            Console.WriteLine("Area Of Square = " + areaSquare);

            //Area OF Rectangle

            Console.Write("Enter Length: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Breadth: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double areaReatangle = l * b;

            Console.WriteLine("Area Of Rectangle = " + areaReatangle);

            //Area OF Circle

            Console.Write("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaCircle = radius * radius * Math.PI;

            Console.WriteLine("Area Of Circle = " + areaCircle);

            //B6
            // Write a program to calculate Celsius to Fahrenheit and vice-versa using
            // function.

            Console.WriteLine("Enter Celcius Which Will Convert to Farhenheit : ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Farhenheit Which Will Convert to Celcius : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double Fahrenheit = (celcius * (9 / 5)) + 32;

            double Celcius = (Fahrenheit - 32) * (5 / 9);

            Console.WriteLine("Fahrenheit = " + Fahrenheit);
            Console.WriteLine("Celcius = " + Celcius);

            //B7
            // Write a program to find out Simple Interest using function. (I = PRN/100)

            Console.WriteLine("Enter Value Of P : ");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value Of R : ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Value Of N : ");
            int N = Convert.ToInt32(Console.ReadLine());

            double Interest = (P * R * N) / 100;

            Console.WriteLine("Interest = " + Interest);

            //B8
            // Write a program to create a Simple Calculator for two numbers (Addition,
            // Multiplication, Subtraction, Division) [Also using if…else &Switch Case]

            Console.WriteLine("Enter First Number : ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Which Operation You Want To Do -> +,-,*,/ ");
            char operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                double addition = c + d;
                Console.WriteLine("Addition Of " + c + "and " + d + " is = " + addition);
            }
            else if (operation == '-')
            {
                double subtraction = c - d;
                Console.WriteLine("Addition Of " + c + "and " + d + " is = " + subtraction);
            }
            else if (operation == '*')
            {
                double multiplication = c * d;
                Console.WriteLine("Multiplication Of " + c + "and " + d + " is = " + multiplication);
            }
            else if (operation == '/')
            {
                double division = c / d;
                Console.WriteLine("Division Of " + c + "and " + d + " is = " + division);
            }


            //Using Switch Case

            switch (operation)
            {
                case '+':
                    double addition = c + d;
                    Console.WriteLine("Addition Of " + c + "and " + d + " is = " + addition);
                    break;
                case '-':
                    double subtraction = c - d;
                    Console.WriteLine("Addition Of " + c + "and " + d + " is = " + subtraction);
                    break;
                case '*':
                    double multiplication = c * d;
                    Console.WriteLine("Multiplication Of " + c + "and " + d + " is = " + multiplication);
                    break;
                case '/':
                    double division = c / d;
                    Console.WriteLine("Division Of " + c + "and " + d + " is = " + division);
                    break;
                default:
                    Console.WriteLine("Enter Valid Input");
                    break;
            }


            //C9
            // Write a program to Swapping without using third variable.

            //using addition and subtraction
            Console.WriteLine("Enter First Variable : ");
            int var1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Variable : ");
            int var2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swaping");

            Console.WriteLine("Using Affition and Subtraction");
            var1 = var1 + var2; // var1 = 10+20=30
            var2 = var1 - var2; //var2 = 30-20=10
            var1 = var1 - var2; //var1 = 30-10=20

            Console.WriteLine("Before Swaping");
            Console.WriteLine("Var1 = " + var1 + "var2 = " + var2);
            //using multiply and division

            Console.WriteLine("Using Multiply and Division");
            var1 = var1 * var2; //var1 = 10*20=200
            var2 = var1 / var2; //var2 = 200/20=10
            var1 = var1 / var2; //var1 = 200/10=20

            Console.WriteLine("Var1 = " + var1 + "var2 = " + var2);

            //C10
            // Write a program to find maximum numbers from given 3 numbers using
            // ternary operator.


            Console.Write("Enter the first number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());

            // Find the maximum using the ternary operator
            int max = (num3 > num4)
                        ? (num3 > num5 ? num3 : num5)
                        : (num4 > num5 ? num4 : num5);

            // Output the maximum number
            Console.WriteLine("The maximum number is: " + max);
        }
    }
}
