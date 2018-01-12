using System;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring values
            int num1;
            int num2;
            int sizeOfNum;
            string choice = "yes";

            while (choice == "yes")
            {
                //Taking in the first input from the User
                Console.WriteLine("Input your first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Input your second number");
                num2 = int.Parse(Console.ReadLine());

                sizeOfNum = num1.ToString().Length;

                //Vverifying the tow numbers are of equal length
                if (sizeOfNum != num2.ToString().Length)
                    Console.WriteLine("Please enter a number with the same length");


                //declarying an array 
                int[] num1Array = new int[sizeOfNum];
                int[] num2Array = new int[sizeOfNum];

                SeparateNumbers(num1Array, num1);
                SeparateNumbers(num2Array, num2);

                //Assigning the values to the Array
                var sum0 = num1Array[0] + num2Array[0];
                var sum1 = num1Array[1] + num2Array[1];
                var sum2 = num1Array[2] + num2Array[2];


                // If the code is true it wont run the else code
                if (sum0 == sum1 && sum1 == sum2 && sum0 == sum2)
                    Console.WriteLine(true);

                // if the if statement is true it will run this else statement
                else
                    Console.WriteLine(false);

                //This method is sperating the numbers and inserting them into an anrray
                void SeparateNumbers(int[] intArray, int num)
                {
                    for (int i = 0; i < sizeOfNum; i++)
                    {
                        if (num >= 10)
                            intArray[i] = num % 10;
                        else
                            intArray[i] = num;


                        num = num / 10;
                    }
                }

                // when the function is done it will ask the user if he/she would like to try again
                Console.WriteLine("Would you like to try again?");
                choice = Console.ReadLine();


                // Gives the user a choice
                if (choice != "yes")
                    choice = "no";

            }

        }

    }
}
