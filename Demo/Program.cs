using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Fractions & Discards
            //float x = 3.12345678f;// will ignore which after 7 digit
            //double y= 3.5;//by default double
            //decimal z = 3.5m;
            //var f = 3.5f;//float
            //Console.WriteLine(x);

            // long x = 181_234_567_897_644;
            // Console.WriteLine($"{x:c}");

            //var cultureInfo=new CultureInfo("en-US");
            // Console.WriteLine(x.ToString("c",cultureInfo));

            #endregion



            #region Part02 Implicit&Explicit-Casting
            //int x = 1000;// 4 bytes
            //long y = x; // 8 bytes - implicit casting
            //Console.WriteLine(y);
            //long z = 3456656567777788;
            //int w = (int)z; //exlicit casting - unsafe casting
            //Console.WriteLine(w);
            //Overflowing - data loss

            //checked // unchecked
            //{
            //    long x = 52545456677778;
            //    int y = (int)x;
            //    Console.WriteLine(y);

            //}

            //long x = 445678899975432;
            //if (x > int.MaxValue || x < int.MinValue)
            //    Console.WriteLine("EXception will be thrown");
            //else 
            //{
            //    int y=(int)x;
            //    Console.WriteLine(y);
            //}
            #endregion



            #region Part03 Convert - Casting
            //Console.WriteLine("Please, Enter your Name:");
            //string? name=Console.ReadLine();
            //Console.WriteLine("Please, Enter your Age:");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please, Enter your salary:");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Employee Data: ==========");
            //Console.WriteLine("Name is" + name);
            //Console.WriteLine("Age is" + age);
            //Console.WriteLine("salary is" + salary);


            #endregion



            #region Part04 Parse - Casting
            //Console.WriteLine("Please, Enter your Name:");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Please, Enter your Age:");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please, Enter your salary:");
            //decimal salary = Decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Employee Data: ==========");
            //Console.WriteLine("Name is" + name);
            //Console.WriteLine("Age is" + age);
            //Console.WriteLine("salary is" + salary);
            #endregion

            #region Part05 TryParse - Casting

            //string number01 = "100";
            //int x01 = int.Parse(number01);
            //Console.WriteLine(x01);

            // string number02 = "Ahmed";
            //int x02 = int.Parse(number01);
            /*Console.WriteLine(x02);*///exception


            //string number02 = "Ahmed";

            //bool isParsed=  int.TryParse(number02, out int x02);
            //Console.WriteLine(isParsed);

            //Console.WriteLine(x02);


            //Console.WriteLine("Please, Enter your Name:");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Please, Enter your Age:");
            //  int.TryParse(Console.ReadLine(),out int age);

            //Console.WriteLine("Please, Enter your salary:");
            // Decimal.TryParse(Console.ReadLine(), out Decimal salary);

            //Console.Clear();
            //Console.WriteLine("Employee Data: ==========");
            //Console.WriteLine("Name is" + name);
            //Console.WriteLine("Age is" + age);
            //Console.WriteLine("salary is" + salary);


            #endregion

            #region P06 Operators
            #region unary Operator
            //int x = 5;
            ////prefix
            //Console.WriteLine(++x);//6
            ////suffix
            //Console.WriteLine(x++);//5

            #endregion
            #region Binary| Arithmetic operators
            //+ / * -
            #endregion
            #region Assignment operators
            // (=,+=,-=,*=,/=,%=)
            #endregion

            #endregion

            #region part07 operators priority  & associativity
            //prefix unary operator
            //()
            //*  /
            //+ -
            #endregion


            #region part08 String formating
            //equation 10+5=15
            int x = 10, y = 5, result;
            result = x + y;
            string message;

            #region string Concatenation
            //message = "equation: " + x + " + " + y + " = " + result;
            //Console.WriteLine(message);
            #endregion
            #region compositeFormatting

            Console.WriteLine("equation: {0} +{1}={2}", x, y, result);

            #endregion

            #region String.format

            //message = string.Format("equation: {0} +{1}={2}", x, y, result);
            //Console.WriteLine(message);
            //int z= 1000;
            //message=string.Format("{0:c}", z);
            //Console.WriteLine(message);

            #endregion

            #region String Interpolation
             message=$"equation: {x}+{y}={result}";
            Console.WriteLine(message);


            #endregion

            #endregion
        }
    }
}
