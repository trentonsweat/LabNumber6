using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1; // prompts user for word
            
            


            Console.WriteLine("Please enter a word");
            

            word1 = Console.ReadLine().ToLower(); // converts word to lowercase

           

            if (word1[0] == 'a' || word1[0] == 'e'|| word1[0] == 'i'|| word1[0] == 'o'||word1[0] == 'u')

            { Console.WriteLine(word1 + "way");}
            

            else 
            {

                char[] vow = { 'a', 'e', 'i', 'o', 'u' };

                int index = word1.IndexOfAny(vow);

                string str1 = (word1.Substring(0, index));

                string str2 = (word1.Substring(index));

                Console.WriteLine(str2 + str1 + "ay");




            }








        }
    }
}












//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TestStrings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            {
//                string s1 = "Hello C#";
//                string s2 = s1.Insert(5, "-"); //If you just want to insert a value at a certain position in a string, you can use the String.Insert method:
//                Console.WriteLine(s2);
//            }




//            //string str = "hello Wordl";

//            //string str1 = new string('*', 20); // this will create a string of 20 characters

//            //// Console.WriteLine(str1);

//            //for (int i = 1; i <=10; i++)
//            //{
//            //    string str2 = new string('#', i );
//            //    Console.WriteLine(str2);
//            //}


//            //int x = 10;
//            //string str3 = "You need to pay $" + x;

//            //Console.WriteLine("Please say yes or no");
//            //string Choice = Console.ReadLine();

//            //if (Choice.ToLower() == "yes")

//            //{
//            //    Console.WriteLine("now you are in trouble!");
//            //}












//        }
//    }
//}