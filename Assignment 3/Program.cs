using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to enter a number then print it.
            //
            //int number;

            //    Console.WriteLine("please, enter a number:");
            //    int.TryParse(Console.ReadLine(), out number);
            //    Console.WriteLine($"you entered {number}");



            /////best answer 
            //bool tryenter;
            //int number;
            //do
            //{
            //    Console.WriteLine("please, enter a number:");
            //    tryenter = int.TryParse(Console.ReadLine(), out number);
            //}
            //while (tryenter == false);
            //Console.WriteLine($"you entered {number}");

            #endregion

            #region Question02 
            ////Write C# program that converts a string to an 
            //// integer, but the string contains non - numeric
            //// characters.And mention what will happen
            ///

            //string name = "ali";
            //int c = int.Parse(name);//system format exception
            //int e = Convert.ToInt32(name);
            //Console.Write(c);//system format exception
            //int d = (int)name; //compile time error
            //int.TryParse(name, out int f);
            //Console.Write(f);//print default value for null which is zero for value type variables
            #endregion



            #region Question03
            ////3 - Write C# program that Perform a simple arithmetic 
            ////operation with floating-point numbers And mention
            ////what will happen
            ///



            ////expected for 3 arithmetic operations(+,*,/) between values 1.4&1.2
            ////+ 2.6
            ////* 1.68
            //// '/' 1.1666666666666666666666666667

            ////arrangement of accuracy as shown below
            ////1.decimal
            ////2.double
            ////3.float

            //float a = 1.4f;
            //float b = 1.2f;
            //Console.WriteLine(a + b);//will print 2.6 float like the numbers in the operation
            //Console.WriteLine(a * b);//the same⬆ 1.6800001 //not accurate compared with decimal or double
            //Console.WriteLine(a / b); //1.1666666


            //double d1 = 1.4;
            //double d2 = 1.2;
            //Console.WriteLine(d1 + d2);//will print 2.5999999999999996 double // less accurate than decimal but more accurate than float
            //Console.WriteLine(d1 * d2);//the same⬆ 1.68
            //Console.WriteLine(d1 / d2); //1.1666666666666667

            //decimal Dec1 = 1.4m;
            //decimal Dec2 = 1.2m;
            //Console.WriteLine(Dec1 + Dec2);//will print 2.6 decimal  // more accurate
            //Console.WriteLine(Dec1 * Dec2);//the same⬆ 1.68
            //Console.WriteLine(Dec1 / Dec2); //1.1666666666666666666666666667

            //Console.WriteLine(a / d1);//accepted arithmetic operations between float an double
            ////Console.WriteLine(Dec1 + d2);//Error when perform arithmetic operation between decimal and float or double



            #endregion




            #region Question04
            //4 - Write C# program that Extract a substring from a 
            //given string.

            //string address = "Cairo, Egypt";
            //Console.WriteLine("You'r from "+address.Substring(0,5));
            //Console.WriteLine("You'r from " + address.Split(",")[0]);

            #endregion


            #region Question05
            //Write C# program that Assigning one value type 
            //variable to another and modifying the value of one
            //variable and mention what will happen


            //int one=4;
            //int another=one;
            //one += 1;
            //Console.WriteLine($"one => {one}, another => {another}");


            //when we are modifying a value of value type variable
            //, the another variable which assigned to same variable isn't affected at all
            // because we change value 
            // Both are stored their values in the stack


            #endregion

            #region Question06
            //Write C# program that Assigning one reference type 
            //variable to another and modifying the object through
            //one variable and mention what will happen

            //Class1 c1=new Class1();
            //Class1 c2 = c1;

            //c1.x = 2;
            //Console.WriteLine($"object1.x => {c1.x}, object2.x => {c2.x}");
            //c2.x = 4;
            //Console.WriteLine($"object1.x => {c1.x}, object2.x => {c2.x}");

            //when Assigning one reference type variable to another like c2 = c1,
            //we will see that any change at any one of Both variables will be reflected to the other 
            //Both are equal in value in stack which refrence  to the same object in heap

            //in details:⬇⬇⬇⬇⬇⬇
            //Because of reference type variables stored in heap and stored refrence of this object into stack
            //So when we put object1=object2
            //, both references point to the same object in the heap.


            #endregion

            #region Question07
            //7 - Write C# program that take two string variables and 
            //print them as one variable

            //Console.WriteLine("Enter your first name:");
            //string? firstName=Console.ReadLine();
            //Console.WriteLine("Enter your first name:");

            //string? lastName=Console.ReadLine();
            //Console.WriteLine($"Hi! {firstName} {lastName}");



            #endregion

            #region Question08
            //8 - Write a program that calculates the simple interest
            //given the principal amount, rate of interest, and
            //time.The formula for simple interest is
            //Interest = (principal * rate * time) / 100.

            //double interest, principalAmount, interestRate, time;
            //Console.WriteLine("Hi, to calculate the simple interest. \nFirst, Enter principal value amount:");
            //double.TryParse(Console.ReadLine(), out principalAmount);
            //Console.WriteLine("Enter rate of interest value");
            //double.TryParse(Console.ReadLine(), out interestRate);
            //Console.WriteLine("Enter time value");
            //double.TryParse(Console.ReadLine(), out time);
            //interest = (principalAmount * interestRate * time) / 100;
            //Console.WriteLine("Interest value = {0} ", interest);


            #endregion

            #region Question09
            //9 - Write a program that calculates the Body Mass Index
            //(BMI) given a person's weight in kilograms and height 
            //in meters.The formula for BMI is
            //BMI = (Weight) / (Height * Height)

            //double BMI, weight, height;

            //Console.WriteLine("Enter your weight in kilograms:");
            //double.TryParse(Console.ReadLine(), out weight);
            //Console.WriteLine("Enter your height in meters:");
            //double.TryParse(Console.ReadLine(), out height);
            //BMI = weight / (height * height);
            //Console.WriteLine("your weight is {0}kg, your height is {1}m,\n Your BMI is {2}kg/m*m", weight, height, BMI);


            #endregion

            #region Question10
            //            10 -
            //Write a program that uses the ternary operator to
            //check if the temperature is too hot, too cold, or
            //just good. Assign the result in a variable then
            //display the result. Assume that below 10 degrees is
            //"Just Cold", above 30 degrees is "Just Hot", and
            //anything else is "Just Good".

            //int temp;
            //string? weather;
            //Console.WriteLine("Enter temperature degree:");
            //int.TryParse(Console.ReadLine(), out temp);
            //weather= temp < 10 ?"Just Cold" : 
            //        temp > 30 ? "Just Hot" :
            //        "Just Good";
            //Console.WriteLine($"Temperature is {weather} in {temp} degree");


            #endregion


            #region Question11
            //11 -
            //Write a program that takes the date from the user
            //and displays it in various formats using string
            //interpolation.
            //Ex : 
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001 
            //Today's date : 20 – 11 – 2001


            //DateOnly date;
            //int day, month, year;


            //Console.WriteLine("Enter a day");
            //int.TryParse(Console.ReadLine(), out day);

            //Console.WriteLine("Enter a month");
            //int.TryParse(Console.ReadLine(), out month);

            //Console.WriteLine("Enter a year");
            //int.TryParse(Console.ReadLine(), out year);

            //date = new DateOnly(year, month, day);
            //Console.WriteLine($"Today’s date : {date.ToString("MM - dd - yyyy")}");
            //Console.WriteLine($"Today’s date : {date.ToString("dd , MM , yyyy")}");
            //Console.WriteLine($"Today’s date : {date.ToString("dd - MM - yyyy")}");
            //Console.WriteLine($"Today’s date : {date.ToString("dd MMMM yyyy")}");

            //Console.WriteLine($"Today’s date : {date.ToString("dd / MM / yyyy")}");
            //Console.WriteLine($"Today’s date : {date.ToString("yyyy _ MM _ dd ")}");
            //Console.WriteLine($"Today’s date : {date.ToString("MMM  dddd  yyyy")}");


            #endregion


            #region Question12
            //12 -
            //What is the output of the following C# code? 
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //a)  The event is on 14/06/2024 
            //b)  The event is on 2024-06-14 
            //c)  The event is on 06/14/2024 
            //d)  The event is on June 14, 2024
            //

            /////output is =>c)The event is on  06/14/2024
            #endregion


            #region Question13
            //13 -
            //Which of the following statements is correct
            //about the C#.NET code snippet given below? 
            //int d;
            //d = Convert.ToInt32(!(30 < 20));//0!=1
            //e) A value 0 will be assigned to d.
            // f)A value 1 will be assigned to d.
            //g) A value -1 will be assigned to d.
            //h) The code reports an error.
            //i)The code snippet will work correctly if ! is replaced by Not.

            /////answer
            //f)A value 1 will be assigned to d.//!0=1



            #endregion

            #region Question14
            //14 -
            //Which of the following is the correct output for
            //the C# code given below? 
            //Console.WriteLine(13 / 2 + " " + 13 % 2); 
            //a) 6.5 1
            //b) 6.5 0
            //c) 6 0
            //d) 6 1
            //e) 6.5 6.5


            ////answer
            //6 1

            #endregion

            #region Question15
            // 15 - What will be the output of the C# code given below? 
            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //a) 5 6
            //b) 6 5
            //c) 6 6
            //d) 7 7

            ///////answer
            ///d)7 7

            //++num 2
            //z++ =5
            // z=6
            //++z 7


            #endregion

        }


    }
}
