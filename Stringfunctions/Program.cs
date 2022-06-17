using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringfunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print hello world
            Console.WriteLine("Hello World!\n");

            string fruit1 = "apple";
            string fruit2 = "mango";
            string output = "";
            Console.WriteLine("strings are '{0}' and '{1}'", fruit1, fruit2);
            while (fruit1.Length != 0 && fruit2.Length != 0)
            {
                if (fruit1[0] < fruit2[0])
                {
                    output += fruit1[0];
                    fruit1 = fruit1.Length > 1 ? fruit1.Remove(0, 1) : "";
                }
                else
                {
                    output += fruit2[0];
                    fruit2 = fruit2.Length > 1 ? fruit2.Remove(0, 1) : "";
                }
            }
            output += fruit1.Length == 0 ? fruit2 : "";
            output += fruit2.Length == 0 ? fruit1 : "";
            Console.WriteLine("\t output is : '{0}'\n", output);

            #region palindrome string
            string str = "12321";
            bool IsPalindrome = false;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == str[str.Length - i])
                {
                    IsPalindrome = true;
                }
                else
                {
                    IsPalindrome = false;
                }
            }
            if (IsPalindrome)
                Console.WriteLine("string '{0}' is palindrome\n", str);
            else
                Console.WriteLine("string '{0}' is not palindrome\n", str);
            #endregion

            #region Contains
            string s1 = "The quick brown fox jumps over the lazy dog";
            string s2 = "fox";
            Console.WriteLine("string '{0}' is contains string '{1}' ?", s1, s2);
            Console.WriteLine("\t {0}\n", s1.Contains(s2));
            #endregion

            string x = "Welcome";
            string y = " to india!";
            object Clonex = x.Clone();
            Console.WriteLine("Cloned object of '{0}' string is : '{1}'\n", x, Clonex);
            int len = x.Length;
            Console.WriteLine("Length of '{0}' string is : '{1}'\n", x, len);
            var compareResult = x.CompareTo(y);
            //compareResult value - 
            // 0 (strings occur in the same position in the sort order)
            // < 0 (first string precedes the second in the sort order)
            // > 0 (first string follows the second in the sort order)
            Console.WriteLine("Compare result of '{0}' with '{1}' is : {2}\n", x, y, compareResult);
            Console.WriteLine("Concate result of '{0}' with '{1}' is : '{2}'\n", x, y, string.Concat(x, y));
            Console.WriteLine("'{0}' ends with '!' ? ", y);
            Console.WriteLine("\t {0}\n", y.EndsWith("!"));
            Console.WriteLine("'{0}' is equals to '{1}' ?", x, y);
            Console.WriteLine("\t {0}\n", x.Equals(y, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(String.Format("Format result is: {0}, the temperature is {1}°C.\n", DateTime.Now, 20.4));
            Console.WriteLine(String.Format("Format result is: It is now {0:d} at {0:t}\n", DateTime.Now));

            #region alignment
            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 110594667, 1148203 };
            var sb = new System.Text.StringBuilder();
            Console.WriteLine("alignment exmaple");
            sb.Append(String.Format("{0,6} {1,15}\n", "Year", "Population"));
            for (int index = 0; index < years.Length; index++)
                sb.Append(String.Format("{0,6} {1,15:N0}\n", years[index], population[index]));
            Console.WriteLine(sb);
            // Result:
            //  Year      Population
            //  2013       1,025,632
            //  2014     110,594,667
            //  2015       1,148,203
            #endregion

            // Result:
            // *
            // **
            // ***
            // ****
            for (int i = 1; i <= 4; i++)
            {
                string count = "";
                for (int j = 1; j <= i; j++)
                {
                    count += "*";
                }
                Console.WriteLine(count);
            }

            Console.WriteLine("\n");
            // Result:
            // ****
            // ***
            // **
            // *
            for (int i = 4; i >= 1; i--)
            {
                string count = "";
                for (int j = 1; j <= i; j++)
                {
                    count += "*";
                }
                Console.WriteLine(count);
            }

            // Result:

            Console.WriteLine("\n");
            // |     |
            // |     |
            // |-----|
            // |     |
            // |     |
            for (int i = 1; i <= 5; i++)
            {
                if (i != 3)
                    Console.WriteLine("|     |");
                else
                    Console.WriteLine("|-----|");
            }

            Console.WriteLine("\n");
            // - - - -
            //    |
            //    |
            //    |
            // - - - -
            for (int i = 1; i <= 5; i++)
            {
                if (i == 1 || i == 5)
                    Console.WriteLine("-------");
                else
                    Console.WriteLine("   |  ");
            }

            Console.WriteLine("\n");
            // |\    |
            // | \   |
            // |  \  |
            // |   \ |
            // |    \|
            for (int i = 1; i <= 5; i++)
            {
                string backspace = "", frontspace = "";
                for (int j = 1; j < i; j++)
                {
                    frontspace += " ";
                }
                for (int j = 5; j > i; j--)
                {
                    backspace += " ";
                }
                Console.WriteLine("|" + frontspace + "\\" + backspace + "|");
            }

            Console.WriteLine("\n");
            //     /\
            //    /  \
            //   /----\
            //  /      \
            // /        \
            for (int i = 1; i <= 5; i++)
            {
                string space = "";
                string frontspace = "";
                for (int j = i; j < 5; j++)
                {
                    frontspace += " ";
                }

                switch (i)
                {
                    case 3:
                        for (int j = 1; j < i; j++)
                        {
                            space += "--";
                        }
                        break;
                    default:
                        for (int j = 1; j < i; j++)
                        {
                            space += "  ";
                        }
                        break;
                }
                Console.WriteLine(frontspace + "/" + space + "\\");
            }

            Console.WriteLine("\n");
            //  -------
            // |       |
            // |       |
            // |       |
            //  -------
            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                    case 5:
                        Console.WriteLine(" ------ ");
                        break;
                    default:
                        Console.WriteLine("|      |");
                        break;
                }
            }
            Console.WriteLine("\n");

            //     *
            //    * *
            //   *   *
            //    * *
            //     *

            Console.WriteLine("\n");

            //      *
            //     * *
            //    * * * 
            //   * * * *
            //  * * * * *

            Console.WriteLine("\n");

            // |     |  - - - -  |\    |     /\
            // |     |     |     | \   |    /  \
            // |-----|     |     |  \  |   /----\
            // |     |     |     |   \ |  /      \
            // |     |  - - - -  |    \| /        \

            for (int i = 1; i <= 5; i++)
            {
                string backspace = "", frontspace = "", aspace = "", afrontspace = "";
                for (int j = 1; j < i; j++)
                {
                    frontspace += " ";
                }
                for (int j = 5; j > i; j--)
                {
                    backspace += " ";
                    afrontspace += " ";
                }
                string common_space = " ";
                if (i != 3)
                {
                    for (int j = 1; j < i; j++)
                    {
                        aspace += "  ";
                    }
                    if (i == 1 || i == 5)
                    {
                        Console.WriteLine("|     |" + common_space + "------" + common_space + "|" + frontspace + "\\" + backspace + "|" + common_space + afrontspace + "/" + aspace + "\\");
                    }
                    else
                    {
                        Console.WriteLine("|     |" + common_space + "   |  " + common_space + "|" + frontspace + "\\" + backspace + "|" + common_space + afrontspace + "/" + aspace + "\\");
                    }
                }
                else
                {
                    for (int j = 1; j < i; j++)
                    {
                        aspace += "--";
                    }
                    Console.WriteLine("|-----|" + common_space + "   |  " + common_space + "|" + frontspace + "\\" + backspace + "|" + common_space + afrontspace + "/" + aspace + "\\");
                }
            }
        }
    }
}
