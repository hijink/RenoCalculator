/********************************************************************************************************/
//
/***************************** ADDITIONAL METHODS *******************************************************/
//
//
//      void indent(int spaces)
//          -indent current line X spaces
//      string GetName(string defaultName)
//          -get string from user checks for Null and returns string
//      int checkChoiceLetter(string[] Choices)
//          - gets user input and checks for match with first char(letter) of string in all array elements
//          - requires matching input and returns array index
//      int checkChoiceNumber(string[] Choices)
//          - gets user input and checks for match with first char(number) of string in all array elements
//          - requires matching input and returns array index
//      bool getYesNo()
//          -gets input from user and confirms valid
//          -requires valid input and returns answer in bool
//      double checkRange(string range)
//          -gets range of numbers listed in input string
//          -gets user input, checks validity and returns value within range
//      double checkRate(string inputString)
//          - searches input string for dollar amount and outputs amount and double
//
/********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoCalculator
{
    internal class UserIP
    {


        public static string GetName(string defaultName)
        {
            string userIP = Console.ReadLine();
            if ((userIP != null) && (userIP != ""))
            {
                return userIP;
            }
            else
            {
                return defaultName;
            }
        }

        static int checkChoiceLetter(string[] Choices)
        {
            bool isValid = false;
            char userIP;
            int choice = 0;
            char[] validIPs = new char[Choices.Length];   //Choices.Length-1

            for (int i = 0; i < Choices.Length; i++)
            {
                validIPs[i] = Choices[i].ToCharArray()[0];
            }
            do
            {
                userIP = Console.ReadKey().KeyChar;
                if (char.IsLetter(userIP))
                {
                    userIP = char.ToUpper(userIP);
                    for (int i = 0; (i < validIPs.Length) && (!isValid); i++)
                    {
                        if (userIP == char.ToUpper(validIPs[i]))
                        {
                            choice = i;
                            isValid = true;
                        }
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("\nInvalid choice, Please choose from available options");
                }
            } while (!isValid);

            return choice;
        }

        static int checkChoiceNumber(string[] Choices)
        {
            bool isValid = false;
            int choice = 0;
            int[] validIPs = new int[Choices.Length];

            for (int i = 0; i < Choices.Length; i++)
            {
                validIPs[i] = int.Parse(Choices[i].Split('.')[0]);
            }
            while (!isValid)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    for (int i = 0; (i < validIPs.Length) && !isValid; i++)
                    {
                        if (choice == validIPs[i])
                        {
                            choice = i;
                            isValid = true;

                            //return i;
                        }
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("\nInvalid choice, Please choose from available options");
                }
            }

            return choice;
        }


        static bool getYesNo()
        {
            bool answer = false,
                isValid = false;
            while (!isValid)
            {
                string s = Console.ReadLine();
                if ((s == null) || (s == ""))
                {
                    answer = false;
                    isValid = true;
                }
                else if ((bool.TryParse(s, out answer)) && (!isValid)) { isValid = true; }
                else
                {
                    s = s.Trim(' ');
                    isValid = true;
                    s = s.ToUpper();
                    if ((s == "Y") || (s == "YES") || (s == "TRUE")) { answer = true; }
                    else if ((s == "N") || (s == "NO") || (s == "FALSE")) { answer = false; }
                    else
                    {
                        Console.WriteLine("Please enter a valid response.");
                        isValid = false;
                    }
                }
            }
            return answer;
        }

        static double checkRange(string range)
        {
            char[] delimiterChars = { '[', '-', ']' };
            bool isValid = false;
            double lowerLimit,
                    upperLimit,
                    userNumber = 0.0;

            string[] stringSegment = range.Split(delimiterChars);
            lowerLimit = double.Parse(stringSegment[1]);
            upperLimit = double.Parse(stringSegment[2]);

            do
            {
                if (Double.TryParse(Console.ReadLine(), out double n))
                {
                    isValid = true;
                    if (n > upperLimit)
                    {
                        userNumber = upperLimit;
                    }
                    else if (n < lowerLimit)
                    {
                        userNumber = lowerLimit;
                    }
                    else
                    {
                        userNumber = n;
                    }
                }
                else
                {
                    Console.WriteLine("Please input a number.");
                }
            } while (!isValid);


            return (userNumber);
        }

        static double checkRate(string inputString)
        {
            char[] delimiterChars = { ' ', ']' };
            string s = inputString.Split('$')[1];
            return (double.Parse(s.Split(delimiterChars)[0]));
        }


        static int getInt(int Lowest, int Highest)
        {
            bool validData = false;
            int userIP = 0;
            while (!validData)
            {
                try
                {
                    userIP = int.Parse(Console.ReadLine());
                    if ((userIP >= Lowest) && (userIP <= Highest))
                        validData = true;
                    else
                        Console.WriteLine($"Error: Entry Out of Range\n  -number must be {Lowest} or higher and {Highest} or Lower.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: Not Valid Data:\n{e.Message}");
                }
            }
            return userIP;
        }

        static int getInt(int Lowest)

        {
            bool validData = false;
            int userIP = 0;
            while (!validData)
            {
                try
                {
                    userIP = int.Parse(Console.ReadLine());
                    if (userIP >= Lowest)
                        validData = true;
                    else
                        Console.WriteLine($"Error: Entry Out of Range\n  -number must be {Lowest} or higher.");
                }

                catch (Exception e)
                {
                    Console.WriteLine($"Error: Not Valid Data:\n{e.Message}");
                }
            }
            return userIP;
        }

        static double getDouble(double Lowest, double Highest)

        {
            bool validData = false;
            double userIP = 0.0;
            while (!validData)
            {
                try
                {
                    userIP = double.Parse(Console.ReadLine());
                    if ((userIP >= Lowest) && (userIP <= Highest))
                        validData = true;
                    else
                        Console.WriteLine($"Error: Entry Out of Range\n  -number must be {Lowest} or higher and {Highest} or Lower.");
                }

                catch (Exception e)
                {
                    Console.WriteLine($"Error: Not Valid Data:\n{e.Message}");
                }
            }
            return userIP;
        }

        static double getDouble(double Lowest)

        {
            bool validData = false;
            double userIP = 0.0;
            while (!validData)
            {
                try
                {
                    userIP = double.Parse(Console.ReadLine());
                    if (userIP >= Lowest)
                        validData = true;
                    else
                        Console.WriteLine($"Error: Entry Out of Range\n  -number must be {Lowest} or higher.");
                }

                catch (Exception e)
                {
                    Console.WriteLine($"Error: Not Valid Data:\n{e.Message}");
                }
            }
            return userIP;
        }
    }
}

