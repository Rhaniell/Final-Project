using DataLogic;
using System;

namespace Project2
{
    internal class Program
    {
        static int userInput;
        static int conversionInput;
        static string[] menu = new string[] { "[1] Length", "[2] Time", "[3] Mass", "[4] Temperature", "[5] Data", "[6] Check History", "[7] Exit" };
        static string[] Lengthmenu = new string[] { "[1] Meter to Centimeter", "[2] Meter to Kilometer", "[3] Meter to Inches", "[4] Meter to Feet"};
        static string[] Timemenu = new string[] { "[1] Hour to Second", "[2] Hour to Milisecond", "[3] Hour to Day", "[4] Hour to Week" };
        static string[] Massmenu = new string[] { "[1] Kilogram to Gram", "[2] Kilogram to Ton", "[3] Kilogram to Pound" };
        static string[] Temperaturemenu = new string[] { "[1] Celcius to Kelvin", "[2] Kelvin to Celcius"};
        static string[] Datamenu = new string[] { "[1] Megabyte to Byte", "[2] Megabyte to Kiloyte", "[3] Megabyte to Gigabyte", "[4] Megabyte to Terabyte" };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Converter Calculator");

            DisplayMenu();
            userInput = GetUserInput();

            while (userInput != 6)
            {
                switch (userInput)
                {
                    case 1:
                        DisplayLengthActions();
                        conversionInput = GetConversionInput();
                        switch (conversionInput)
                        {
                            case 1:
                                GetAmountInput();
                                //DisplayNewAmount();
                                break;
                            case 2:
                                GetAmountInput();
                                break;
                            case 3:
                                GetAmountInput();
                                break;
                            case 4:
                                GetAmountInput();
                                break;
                            default:
                                Console.WriteLine("Error. Please input a number between 1-4");
                                break;
                        }    
                        break;
                    case 2:
                        DisplayTimeActions();
                        conversionInput = GetConversionInput();
                        switch (conversionInput)
                        {
                            case 1:
                                GetAmountInput();
                                break;
                            case 2:
                                GetAmountInput();
                                break;
                            case 3:
                                GetAmountInput();
                                break;
                            case 4:
                                GetAmountInput();
                                break;
                            default:
                                Console.WriteLine("Error. Please input a number between 1-4");
                                break;
                        }
                        break;
                    case 3:
                        DisplayMassActions();
                        conversionInput = GetConversionInput();
                        switch (conversionInput)
                        {
                            case 1:
                                GetAmountInput();
                                break;
                            case 2:
                                GetAmountInput();
                                break;
                            case 3:
                                GetAmountInput();
                                break;
                            default:
                                Console.WriteLine("Error. Please input a number between 1-4");
                                break;
                        }
                        break;
                    case 4:
                        DisplayTemperatureActions();
                        conversionInput = GetConversionInput();
                        switch (conversionInput)
                        {
                            case 1:
                                GetAmountInput();
                                break;
                            case 2:
                                GetAmountInput();
                                break;
                            default:
                                Console.WriteLine("Error. Please input a number between 1-2");
                                break;
                        }
                        break;
                    case 5:
                        DisplayDataActions();
                        conversionInput = GetConversionInput();
                        switch (conversionInput)
                        {
                            case 1:
                                GetAmountInput();
                                break;
                            case 2:
                                GetAmountInput();

                                break;
                            case 3:
                                GetAmountInput();
                                break;
                            default:
                                Console.WriteLine("Error. Please input a number between 1-3");
                                break;
                        }
                        break;
                    case 6:
                        DisplayHistory();
                        break;
                    case 7:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Error. Please input a number between 1-6");
                        break;
                }
                DisplayMenu();
                userInput = GetUserInput();
            }
        }

        private static void DisplayHistory()
        { 
            Console.WriteLine("------------------");
            Console.WriteLine("HISTORY");
            Console.WriteLine($"Type: {ConverterProcess.GetHistory(ConverterDataService)}");
            Console.WriteLine("HISTORY");
            Console.WriteLine("HISTORY");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Main Menu");
            foreach (var Mainmenu in menu)
            {
                Console.WriteLine(Mainmenu);
            }
        }

        static int GetUserInput()
        {
            Console.Write("Please Select Conversion: ");
            int userInput = Convert.ToInt16(Console.ReadLine());

            return userInput;
        }

        static void DisplayLengthActions()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Length Options");

            foreach (var LengthAction in Lengthmenu)
            {
                Console.WriteLine(LengthAction);
            }
        }

        static void DisplayTimeActions()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Time Options");

            foreach (var TimeAction in Timemenu)
            {
                Console.WriteLine(TimeAction);
            }
        }

        static void DisplayMassActions()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Mass Options");

            foreach (var MassAction in Massmenu)
            {
                Console.WriteLine(MassAction);
            }
        }

        static void DisplayTemperatureActions()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Temperature Options");

            foreach (var TemperatureAction in Temperaturemenu)
            {
                Console.WriteLine(TemperatureAction);
            }
        }

        static void DisplayDataActions()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Data Options");

            foreach (var DataAction in Datamenu)
            {
                Console.WriteLine(DataAction);
            }
        }

        static int GetConversionInput()
        {
            Console.Write("What conversion would you like to do: ");
            int conversionInput = Convert.ToInt16(Console.ReadLine());

            return conversionInput;
        }

        static void GetAmountInput()
        {
            Console.Write("Input Amount to Convert: ");
            double amountInput = Convert.ToDouble(Console.ReadLine());
            if(ConverterProcess.checkPositive(amountInput))
            {
                ConverterProcess.Convert(userInput, conversionInput, amountInput, ConverterProcess.preamount);
                Console.WriteLine($"Converted amount is: {ConverterProcess.preamount}");
            }
            else
            {
                Console.WriteLine("Please insert a positive number");
            }
        }
    }
}

