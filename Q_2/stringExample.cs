using System;

namespace stringExample
{
    class stringEx
    {
        public static void strmethod()
        {
             // length of the string 
            Console.WriteLine("Enter Any string : ");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("The length of the string "+str+" is "+len);

            // sentence type 
            Console.WriteLine("Enter sentence : ");
            string sentence = Console.ReadLine();

            if(sentence.EndsWith("."))
            {
                Console.WriteLine("This sentence  is declarative sentence ");
            }
            else if (sentence.EndsWith("?"))
            {
                Console.WriteLine("This sentence  is interrogatory sentence ");
            }
            else if (sentence.EndsWith("!"))
            {
                Console.WriteLine("This sentence  is exclamation sentence ");
            }
            else {
                Console.WriteLine("This sentence is something else ");
            }

            // first and last name
            Console.WriteLine("Enter your Full name : ");
            string name = Console.ReadLine();

            int index_of_space = name.IndexOf(" ");

            if(index_of_space == -1)
            {
                Console.WriteLine("Hello "+name);
            }
            else 
            {
                string firstName = name.Substring(0,index_of_space);
                string lastName = name.Substring(index_of_space);

                Console.WriteLine("Hello "+lastName+","+firstName);
            }
            
        }
    }
}