using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;


namespace strings_manipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "test";
            string sentence = @"this is  string which will work on all next functions FBI by using this link c:\\test\";
            // stringConversion(sentence);
            //stringAsArray(word);
            //appendinginstrings();
            // interpolationandliteral();
            //stringbuilder();
            // workingOnArray();
            // PadAndTrim();
            // SearchOnString(sentence);
            //compareHelper("ahmedgf", "azhaa");
            //equality("YASSS", "yasss");
            // substring(sentence);
            OperationOnString(sentence);
        }
        //start the fun of string conversion
        public static void stringConversion(string test)
        {
            //convert to lower and upper cases
            Console.WriteLine($"convert to lower:{test.ToLower()} \nconvert to upper :{test.ToUpper()}");
            //convert to title case
            TextInfo textObj = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine($"convert to title case:{textObj.ToTitleCase(test)}");
        }
        //start working on string as arr
        public static void stringAsArray(string test)
        {
            //for on the string
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }
        //working on appendings and display the strings
        public static void appendinginstrings()
        {
            string firstName = "yasmeen";
            string lastName = "abdallah";
            string name;
            name = "my name is " + firstName + " " + lastName;
            Console.WriteLine(name);
            name = string.Format("{0} this is my first name", firstName);
            Console.WriteLine(name);
            name = $"{firstName} hello my last name is {lastName} ";
            Console.WriteLine(name);
        }
        public static void interpolationandliteral()
        {
            string name = "yasmeen";
            string result = $@"c:/\ hello\{name}\""path""";
            Console.WriteLine(result);
            Stopwatch war = new Stopwatch();
            war.Start();
            string test = "";
            for (int i = 0; i < 10; i++)
            {
                test += i;
            }
            war.Stop();
            Console.WriteLine(war.ElapsedMilliseconds);
            ;
        }
        //use the string builder
        public static void stringbuilder()
        {
            // the string builder is better than the string
            StringBuilder Test = new();
            //us append if we wnat to add value
            Test.Append("hello world");
            Console.WriteLine(Test);
        }
        //WORKING ON string as array
        public static void workingOnArray()
        {
            int[] arr = new int[] { 1, 2, 3, 5, 8, 9, 6 };
            string result;
            result = string.Concat(arr);
            Console.WriteLine($"this is output using contact {result} ");
            result = string.Join('*', arr);
            Console.WriteLine($"this is output using join {result} ");
            string test = "hello,hdjshd, h";
            string[] results = test.Split(',');
            Console.WriteLine("this is output using spilt ");
            Array.ForEach(results, x => Console.WriteLine(x));
            /*string isnull = null;
            if(!string.is)*/
        }
        //pad and trim with string
        public static void PadAndTrim()
        {
            //the trim part
            string test = "  hello   ";
            string results;
            results = test.Trim();
            Console.WriteLine($"'{results}'");
            //the pad part
            String testint = "1.150";
            testint = testint.PadLeft(10, '0');
            Console.WriteLine($"the pad left  {testint}");
            testint = testint.PadRight(20, '0');
            Console.WriteLine($"the pad right {testint}");
        }
        //start search
        public static void SearchOnString(string test)
        {
            Boolean result;
            int resultint;
            result = test.StartsWith("this is ");
            Console.WriteLine($"if has a start with this is : {result}");
            result = test.EndsWith("this is ");
            Console.WriteLine($"if has a end with this is : {result}");
            result = test.Contains("this");
            Console.WriteLine($"if has contains this  : {result}");
            resultint = test.IndexOf("string", 10);
            Console.WriteLine($"if has contains this  : {resultint}");
            resultint = test.LastIndexOf("string");
            Console.WriteLine($"if has contains this  : {resultint}");
        }
        //compare on strings
        public static void compareHelper(string? testa, string? testb)
        {
            int ressult = string.Compare(testa, testb);
            switch (ressult)
            {
                case > 0:
                    Console.WriteLine("a is greater");
                    return;
                case < 0:
                    Console.WriteLine("b is greater");
                    return;
                case 0:
                    Console.WriteLine("equal");
                    return;
            }
        }
        //  equality
        public static void equality(string? testa, string? testb)
        {
            Boolean result = string.Equals(testa, testb, StringComparison.InvariantCultureIgnoreCase);
            if (result)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        // work with substring
        public static void substring(string test)
        {
            string result = test.Substring(3, 10);
            Console.WriteLine(result);
        }

        //replace the string , remove AND INSERT 
        public static void OperationOnString(string test)
        {
            //replace
            string result = test.Replace(" This ", "testfinal" ,StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(result);
            //insert
            result = test.Insert(5, "yasmen ");
            Console.WriteLine(result);
            //remove
            result = test.Remove(5 ,10);
            Console.WriteLine(result);

            

        }
    }
}
