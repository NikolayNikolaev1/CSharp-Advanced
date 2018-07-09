namespace Lab_01._Parking_Lot
{
    using System;
    using System.Collections.Generic;

    class Parking_Lot
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var parking = new HashSet<string>();

            while (input != "END")
            {
                string[] inputParams = input.Split(", ");
                string command = inputParams[0];
                string carNumber = inputParams[1];

                if (command == "IN")
                {
                    parking.Add(carNumber);
                }
                else if(command == "OUT")
                {
                    parking.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
