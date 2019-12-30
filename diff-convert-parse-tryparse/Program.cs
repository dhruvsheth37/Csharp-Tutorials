using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diff_convert_parse_tryparse
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "9009";
            string str2 = null;
            string str3 = "9009.9090800";
            string str4 = "90909809099090909900900909090909";
            int finalResult;

            finalResult = int.Parse(str1); //success
            finalResult = int.Parse(str2); // ArgumentNullException
            finalResult = int.Parse(str3); //FormatException
            finalResult = int.Parse(str4); //OverflowException


            finalResult = Convert.ToInt32(str1); // 9009
            finalResult = Convert.ToInt32(str2); // 0
            finalResult = Convert.ToInt32(str3); //FormatException
            finalResult = Convert.ToInt32(str4); //OverflowException 


            bool output;
            output = int.TryParse(str1, out finalResult); // 9009
            output = int.TryParse(str2, out finalResult); // 0
            output = int.TryParse(str3, out finalResult); // 0
            output = int.TryParse(str4, out finalResult); // 0
        }
    }
}
