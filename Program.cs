/************************************************************************************************************************************/
//  Purpose:			1. Create a model for the program by drawing a flowchart or writing the pseudo code for the
//                          program.
//                      2.Create a test plan and proof of output
//                      3. Enter the code to implement your model.
//                      4. Test your code with your test plan. If you discover mistakes, correct the code and model,
//                          and execute the test plan again
//
//  Input()s:			Dimensions of a rectangular room (standard room height is 8 feet)
//                      Dimensions of a single window, entry door and closet door
//                      Type of paint
//                          Basic 29.99 / gallon (covers 300 sq feet on walls and 200 sq feet on ceilings)
//                          Premium 39.99 / gallon(covers 400 sq feet on walls and 250 sq feet on ceilings)
//                          Deluxe 49.99 / gallon(covers 500 sq feet on walls and 300 sq feet on ceilings)
//                      Type of flooring
//                          Carpet 2.75 / square foot
//                          Tile 3.50 / square foot
//                          Hardwood 4.85 / square foot
//                      Price of Baseboard per linear foot
//                      Price of Casing per linear foo
//
//  Process:			Console.WriteLine()
//                      Console.ReadLine()
//
//  Output(s):			Amount and type of paint required and price
//                      Amount and type of flooring required and extended price
//                      Length of Baseboard required and extended price
//                      Length of Casing required and extended price
//                      Net Price
//                      Total GST (5%)
//                      Total Price
//
//  Additional Requirement(s):
//                      • View supplied video demonstration
//                      • Calculate a 10 percent waste factor for Baseboard and Casing
//                      • Paint can only be bought in full gallons
//                      • Right align the number columns
//                      • Format prices to two decimal places and all other numbers to one decimal place
//                      • Input data must be valid positive number or valid choices
//                      • Continue prompting for a valid value per required input
//                      • A menu to allow for choice of renovation data to be entered. If the required renovation choice
//                          already has had data entered, the new data will replace the existing data. Example: you had
//                          already entered the size of the window, then, decide to change the window size. You may
//                          choose the window menu choice again and the newly enter data would replace the existing
//                          window data
//                      • The packing slip must display zeros for all items that do not have complete input data
//                      • i.e. no casing price entered... casing footage should also show zero
//
//  Test Plan:          Test1________________________________________________Test2________________________________________________Test3________________________________________________
//                      |       Inputs                                      |        Inputs                                      |        Inputs                                      |
//                      |                                                   |                                                    |                                                    |
//                      |       Outputs                                     |        Outputs                                     |        Outputs                                     |
//                      |___________________________________________________|____________________________________________________|____________________________________________________|   
//                          
//                          
//                          
//                          
//
//  Written by: 		Jessie Hink - jhink1@nait.ca - hijink
//
//  Written for: 		CPSC1012E01 - Asad Iqbal
//
//  Last modified:		Feb 02, 2021 (PST)
//
//
/************************************************************************************************************************************/

using System;
//using UserIP;

namespace RenoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] paintChoices = new string[]{ "A - Basic $29.99 / gallon (covers 300 sq feet on walls and 200 sq feet on ceilings)",
                                            "B - Premium $39.99 / gallon(covers 400 sq feet on walls and 250 sq feet on ceilings)",
                                            "D - Deluxe $49.99 / gallon(covers 500 sq feet on walls and 300 sq feet on ceilings)"};
            string[] flooringChoices = new string[]{"A -  Carpet $2.75 / square foot",
                                                "B - Tile $3.50 / square foot",
                                                "C - Hardwood $4.85 / square foot" };

            double[] room = { 0, 0 },
                        window = new double[]{ 0, 0 },
                        entryDoor = new double[] { 0, 0 },
                        closetDoor = new double[] { 0, 0 };

            double castingCost = 0.0,
                        baseboardCost = 0.0;

            Console.WriteLine(UserIP.GetName("whatever"));
            //UserIP.GetName("whatever");


        }



    }

}