using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Program_In_Console_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            // 1.Declaring Variables


            // string characterName = "Ali";
            // int characterAge =  100;

            // Console.WriteLine("Magaceygu waa " + characterName);
            // Console.WriteLine("Waxaan jiraa " + characterAge + " Sanno");

            // characterName = "Abdullaahi";
            // characterAge = 33;
            // Console.WriteLine("Waxaan Jeclaahy Magaca "+ characterName);
            // Console.WriteLine("Balse waa " + characterAge + " sanno Jir");

            // Console.ReadLine();


            // 2.Data Types

            // string phrase = "Omar";
            // char onlyOne = 'A';
            // int age = 10; // You Can use Negative Number and Positive Numbers not for Decimals or Float
            // There is Three Variables that you can store Data that is decimals and they are: decimal , float, double;
            // double gpa = 3.3;
            // bool isMale = true;
            // Console.WriteLine();

            // Console.ReadLine();

            // 3.Working With String

            //string Upper = "Omar Mohamed";
            //Console.WriteLine(Upper.ToUpper());// Make all Upper character

            //string Lower = "Omar Mohamed";
            //Console.WriteLine(Lower.ToLower()); //  Make all Small characters

            //string phrase = "Omar Mohamed";
            //Console.WriteLine(phrase.Contains("Omar")); // Tells where it contains the character you give is inside or not

            //string Index = "Omar Mohamed";
            //Console.WriteLine(Index[9]); // Note in C# Index Space will counted

            //string bigCharacter = "Omar Mohamed";
            //Console.WriteLine(bigCharacter.IndexOf("Mohamed"));// tells where the passed character or thing started its index

            //string oneChar = "Omar Mohamed";
            //Console.WriteLine(oneChar.IndexOf("w"));// tells only one character index, if the character not inside it will print negative One -1 that means there is no 

            //string sub = "Omar Mohamed";
            //Console.WriteLine(sub.Substring(6));// You can pass the index where you need to display and all what is its behind 

            //string subFromAndto = "Omar Mohamed";
            //Console.WriteLine(subFromAndto.Substring(5, 3));// Tells where you start the index and stop whats behind starting from 1 to Where you need

            // 4.Working With Numbers

            //Console.WriteLine(5);// normal you use like this
            //Console.WriteLine(5.1);
            //Console.WriteLine(5 + 5 - 10 * 8 / 4); // You you all Operations
            //Console.WriteLine(5 % 2);// Will Give you the remainder
            //Console.WriteLine(5 / 2); // Will give you Only Integer part not the decimal part
            /*Console.WriteLine(5.0 + 2.45)*/
            ;// Deciamls also Use Operqations
            /*Console.WriteLine(4.5 / 2)*/
            ;// You get only for Decimal if dive integer with decimals

            //int num = 7;
            //num++;// You Use The all Operations
            //Console.WriteLine(num);

            //Console.WriteLine(Math.Abs(-9) );// Absolute value
            //Console.WriteLine(Math.Pow(3,2));// Power, also uses Decimal Number and Whole , You can use all methods that has math.----

            // 5.Getting Use Input

            //Console.Write("Enter Your Name: ");
            //    string name = Console.ReadLine(); Kan saan waa loo samyn karaa balse int ahaan saan looma qori karo waa in conversion lagu sameyaa
            //    Console.Write("Enter Your Age: ");
            //    string age = Console.ReadLine();

            //    Console.WriteLine("Hello " + name + " You are " + age);

            //Console.ReadLine();


            // 6. Building a Calculator

            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);


            //Console.ReadLine();

            // 7.Arrays

            // Conditions
            
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}
