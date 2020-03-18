using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            //multi dimensional arrays -rectangular and jagged(array of arrays)
            //rectangular
            //var matrix = new int[3, 5];//can make it 3D

            ////jagged
            //var array = new int[3][];

            //int[] numbers = new int[] { 3, 5, 6, 1, 7 };
            //Console.WriteLine(numbers.Length);//static method
            //Console.WriteLine(Array.IndexOf(numbers, 6));
            //Array.Clear(numbers, 0, 2);
            //int[] another = new int[3];
            //Array.Copy(numbers, another, 3);
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers);



            //###########Strings##################################
            //sequence of characters
            //immutable
            //format strings
            //verbatim strings
            //class
            //methods - formatting, searching, substrings, nullchecking, splitting, converting(parse,convert)
            //var name = "john snow ";
            //name.Trim();
            //name.ToUpper();
            //var index = name.IndexOf(' ');
            //var firstname = name.Substring(0, index);
            //var lastName = name.Substring(index + 1);
            //var easierway = name.Split(' ');//than assign first and lastname to an element of array
            //name.Replace("john", "joe");
            //if (String.IsNullOrWhiteSpace("    "))
            //    Console.WriteLine("invalid");
            //var str = "25";
            //Convert.ToByte(str);

            //float price = 29.95f;
            //price.ToString("C");

            //var sentence = "this is a really really long sentence ";
            //const int maxlen = 10;
            //if (sentence.Length < maxlen)
            //    Console.WriteLine(sentence);
            //else
            //{
            //    var words = sentence.Split(' ');
            //    var totalCharacters = 0;
            //    var summaryWords = new List<string>();
            //    foreach(var word in words)
            //    {
            //        summaryWords.Add(word);
            //        totalCharacters += word.Length + 1;
            //        if (totalCharacters > maxlen)
            //            break;
            //    }
            //    var summary = String.Join(" ", summaryWords) + "...";
            //    Console.WriteLine(summary);
            //}

            //String builder -append, insert, remove, replace, clear
            //no searching methods
            //var builder = new StringBuilder("Hello World");
            //builder.Append('*', 10)
            //       .AppendLine()//chained together
            //       .Append("Header")
            //       .AppendLine();

            //builder.Replace('*', '#');

            //builder.Remove(0, 10);
            //builder.Insert(0, new string('-', 10));


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

            //while (true)
            //{
            //    Console.WriteLine("type here: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo " + input);
            //        continue;
            //    }
            //    break;
            //}

            //#############Random###################################
            //var random = new Random();
            //const int passwordlen = 10;
            //var buffer = new char[passwordlen];
            //for (var i = 0; i < 10; i++)
            //    buffer[i] = ((char)('a' + random.Next(0, 26)));
            //var password = new string(buffer);

            //Console.WriteLine(password);

            //############Exercises#################################
            //while (true)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    var number = Console.ReadLine();
            //    if ((Convert.ToInt32(number) >= 1) && (Convert.ToInt32(number) <= 10))
            //    {
            //        Console.WriteLine("Valid");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid");
            //        continue;
            //    }
            //}

            //##########Lists##############################
            //dynamic size
            //generic type
            //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //foreach (var item in numbers)
            //    Console.WriteLine(item);
            //numbers.Add(7);//cant do this with arrays
            //numbers.AddRange(new int[2] { 9, 8});
            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            //IndexOf
            //LastIndexOf
            //Count
            //Remove can use in for loop
            //Clear

            //##############DateTime##########################
            //var dateTime = new DateTime(2015, 1, 1);
            //var now = DateTime.Now;
            //var today = DateTime.Today;

            //Console.WriteLine(now.Hour);//minute
            ////many formats can be use look at the methods of the object

            //var tommorow = now.AddDays(1);
            //var yesterday = now.AddDays(-1);

            //###########TimeSpan##############################
            //var timeSpan = new TimeSpan(1, 2 ,3);//hms
            //var timeSpan2 = TimeSpan.FromHours(1);

            //var start = DateTime.Now;
            //var end = DateTime.Now.AddMinutes(2);
            //var duration = end - start;

            //timeSpan.ToString()
            //timeSpan.Parse("01:02:03")

            //#############Files###########################
            //system.io namespace
            //File, FileInfo, Directory, Directory Info, Path -classes
            //File(static methods) and FileInfo(instance methods) demo


            //###########Debugging##########################
            //breakpoint - f9 
            //run with debug -f5
            //f10 -step over
            //step into - f11
            //step out shift f11
            //debug/windows/watch/watch one

            //#########Palindrome###########################
            var str = "aba";
            char[] rev = str.ToCharArray();
            Array.Reverse(rev);
            var revstr = new String(rev);
            if (String.Equals(str, revstr))
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not a palindrome");
        }
    }
}
//ctrl shift b compile
//ctrl f5 run