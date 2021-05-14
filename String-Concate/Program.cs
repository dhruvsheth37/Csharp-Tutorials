using System;
using System.Text;

namespace String_Concate
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Using the + and the += Operators
            PlusOperator();

            //2. String.Format() Method
            StringFormat();

            //3. Using String Interpolation(C# 6 Feature)
            StringInterpolation();

            //4. Joining Strings with String.Join() Method
            StringJoin();

            //5. StringBuilder.Append() Method
            StringBuilderAppend();

            //6. String.Concat() Method
            String_Concate();

            Console.ReadKey();
        }



        private static void PlusOperator()
        {
            //Let understand concating strings using + 
            string firstName = "Dhruv";
            string lastName = "Sheth";
            string fullName = firstName + " " + lastName;

            Console.WriteLine("1. Using the + and the += Operators");
            Console.WriteLine(" Using the +  operator");
            Console.WriteLine(fullName); // Output: "Dhruv Sheth"

            //Let understand concating strings using +=

            string[] data = { firstName, " ", lastName };
            string fullNamePlusEqual = string.Empty;
            foreach (var item in data)
                fullNamePlusEqual += item;


            Console.WriteLine(" Using the += operator");
            Console.WriteLine(fullName); // Output: "Dhruv Sheth"

        }

        private static void StringFormat()
        {
            string firstNameFormat = "Dhruv";
            string lastNameFormat = "Sheth";
            string fullNameFormat = string.Format(" {0} {1}", firstNameFormat, lastNameFormat);

            Console.WriteLine("2. String.Format() Method");
            Console.WriteLine(fullNameFormat); // Output: "Dhruv Sheth"
        }


        private static void StringInterpolation()
        {
            string firstName = "Dhruv";
            string lastName = "Sheth";
            DateTime date = DateTime.Now;

            Console.WriteLine("3. Using String Interpolation(C# 6 Feature)");
            Console.WriteLine($" Hi, {firstName} {lastName}, it's {date:HH:mm} now."); // Output: "Hi, Dhruv Sheth, it's 17:02 now."
        }
        private static void StringJoin()
        {
            string[] data = { "Dhruv", "Sheth" };
            string FullName = string.Join(" ", data);
            Console.WriteLine("4. Joining Strings with String.Join() Method");
            Console.WriteLine(FullName);

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string foobar = String.Join(",", array);

            Console.WriteLine(foobar); // outputs "1,2,3,4,5,6,7,8,9"
        }

        private static void StringBuilderAppend()
        {
            string firstName = "Dhruv";
            string lastName = "Sheth";
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(firstName);
            stringBuilder.Append(" ");
            stringBuilder.Append(lastName);

            Console.WriteLine("5. StringBuilder.Append() Method");
            Console.WriteLine(stringBuilder); // output: Dhruv Sheth
        }

        private static void String_Concate()
        {
            string firstName = "Dhruv";
            string lastName = "Sheth";

            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine("6. String.Concat() Method");
            Console.WriteLine(fullName); // output:Dhruv Sheth
        }

    }
}
