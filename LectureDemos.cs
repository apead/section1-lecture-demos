using System;

namespace Section1
{

    public class HelloWorld
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Hello World");
        }

        public int AddTwoNumbers(int number1, int number2)
        {
            int theValueIWantToSendBackToCaller = number1 + number2;

            return theValueIWantToSendBackToCaller;
        }


    }

    public class LectureDemos
    {
        public void DisplayStringVariables()
        {
            string stringToDisplay = "Hello";
            Console.WriteLine(stringToDisplay);
        }

        public void DisplayStringConcat()
        {
            string stringToDisplay = "String Concat";

            Console.WriteLine(stringToDisplay + " is awesome");

        }

        public void DisplayStringInterpollation()
        {

            string stringToDisplay = "Whoohoo";
            Console.WriteLine($"BLAH   {stringToDisplay} This is Cool!!!");
        }


        public void DisplayStringMultipleInterpollation()
        {
            string firstNoun = "cat";
            string secondNoun = "mat";
            Console.WriteLine($"The { firstNoun} sat on the { secondNoun}");
        }

        public void StringUpperCase()
        {
            string myString = "Hello World";
            string myUpperCaseString = myString.ToUpper();
            Console.WriteLine(myUpperCaseString);
        }

        public void StringSplit()
        {
            /*             string myString = "Hello World";
                       Console.WriteLine(myString.Split(' ')[1]);
            */
            string myString = "Hello Cool World";
            string[] myStringArray = myString.Split(' ');

            for (int index = 0; index < myStringArray.Length; index++)
            {
                Console.WriteLine(myStringArray[index]);
            }
        }

        public void SplitAllCharacters()
        {
            string myString = "Hello Cool World";

            for (int index = 0; index < myString.Length; index++)
            {
                Console.WriteLine(myString[index]);
            }

        }

        public void StringContains()
        {
            string mystring = "Hello World";

            Console.WriteLine("String has Hello: " + mystring.Contains("Hello"));
            Console.WriteLine("String has Cat: " + mystring.Contains("Cat"));
        }

        public void StringIndexOf()
        {
            string mystring = "Hello World";

            Console.WriteLine("String has World: " + mystring.IndexOf("World"));
            Console.WriteLine("String has Cat: " + mystring.IndexOf("Cat"));
        }

    }


}
