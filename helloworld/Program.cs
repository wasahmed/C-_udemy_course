using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 2;
            //var count = 10;
            //var totalPrice = 20.95f;
            //var character = 'A';
            //var firstName = "x";

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);

            //###############Format String##############################
            //Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);

            //###########Type conversion###################
            //explicit (the is a data loss)
            //strtoint convert class Convert.ToInt32   Parse

            //Implicit example
            //byte b = 1;     (1byte)
            //int i = b;//no dataloss (4bytes)
            //Console.WriteLine(i);

            //Explicit 
            //int i = 2;
            //byte b = (byte)i;
            //Console.WriteLine(b);

            //non compatible types
            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //############Exception handling####################
            //try
            //{
            //    var number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("caught");
            //}


            //############Operators#########################
            //postfix increment
            //int a = 1;
            //int b = a++;//++a
            ////remember order of precedence
            //byte number = 255;

            //number += 2;

            //Console.WriteLine(number);


            //###########Classes##################################
            //access mod than class name
            ////static modifier -- when we only want one instance in date
            //Person x = new Person();
            //x.firstName = "john";//could be default
            //x.Lastname = "snow";
            //x.Introduce();


            //################Arrays##############################
            //var numbers = new int[3];// int[]
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;
            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);
            //can use string arrays

            //###########Strings##################################
            //sequence of characters
            //immutable
            //format strings
            //verbatim strings

            //#############Enum##################################
            //name value pairs
            //internally an int can be :byte
            //
            //integer value of enum
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);
            //
            //string value of the enum
            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            //Console.WriteLine(method.ToString());
            //var methodName = "testparsing";
            ////converting a string to a enum
            //var x = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            //###############Reference and value types##########################
            //var a = 10;
            //var b = a;
            //b++; // what is the value of a? value type so a copy of the value is made

            //var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1;
            //array2[0] = 0;
            //Console.WriteLine(array1[0]);

            //##########Loops#######################
            //for(initialize, condition, inc)

            //foreach(var tmp in array/list)

            //while(condition){inc}

            //break - out of the loop

            //continue - next iteration

            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    }
            //}

            //var name = "abcdef";
            //foreach(var letter in name)
            //{
            //    Console.WriteLine(letter);
            //}

            while (true)
            {
                Console.WriteLine("type here: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo ");
                }
            }
        }
    }
}
//ctrl shift b compile
//ctrl f5 run