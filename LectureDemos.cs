using System;
using System.Collections.Generic;

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

        public void NumbersAdding()
        {
            int x = 5; int y = 10;

            int myanswer = x + y;
            Console.WriteLine(myanswer);
        }

        public void NumberRanges()
        {
            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integers is {min} to {max}");

        }

        public void DisplayEnums()
        {
            Day myDay = Day.Fri;

            if (myDay == Day.Fri)
                Console.WriteLine("It's Almost weekend");
            else
            {
                Console.WriteLine("Still a long way to go");
            }


            Console.WriteLine("Day of the week" + myDay);
        }

        public void DisplayStucts()
        {
            Coords coords;
            coords.x = 10;
            coords.y = 20;
            Console.WriteLine("X: " + coords.x);
            Console.WriteLine("Y: " + coords.y);
        }

        public void DisplayIfStatement()
        {

            int x = 15;
            int y = 6;

            if (x - y < 12)
                Console.WriteLine("The answer is less than 10.");
        }

        public void DisplayIfElse()
        {
            int x = 2;
            int y = 3;
            int z = 3;

            if ((x * y > 10) && (y == z))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        public void DisplayIfBooleanLogic()
        {
            int x = 2;
            int y = 3;
            int z = 3;

            if ((x * y > 10) && (y == z))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

        }

        public void DisplayWhileLoops()
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }

        public void DisplayForLoops()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        public void DisplayCollectionsForEach()
        {
            var names = new List<string> { "Bob", "Craig", "John" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
