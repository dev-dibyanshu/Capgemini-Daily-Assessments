using System;

class Program
{
    static void Main(string[] args)
    {
        VehicleRentalEstimator estimator = new VehicleRentalEstimator();

        Console.Write("Enter your choice (1 for car, 2 for truck, 3 for bike): ");
        int choice = int.Parse(Console.ReadLine());

        double estimatedCost = 0;
        string vehicle = "";

        if (choice == 1)
        {
            Console.Write("Enter days: ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Enter distance: ");
            int distance = int.Parse(Console.ReadLine());
            
            estimatedCost = estimator.EstimateCost(days, distance);
            vehicle = "car";
        }
        else if (choice == 2)
        {
            Console.Write("Enter days: ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Enter distance: ");
            int distance = int.Parse(Console.ReadLine());
            Console.Write("Enter driver required (true/false): ");
            bool withDriver = bool.Parse(Console.ReadLine());
            
            estimatedCost = estimator.EstimateCost(days, distance, withDriver);
            vehicle = "truck";
        }
        else if (choice == 3)
        {
            Console.Write("Enter days: ");
            int days = int.Parse(Console.ReadLine());
            Console.Write("Enter insurance required (true/false): ");
            bool includeInsurance = bool.Parse(Console.ReadLine());
            
            estimatedCost = estimator.EstimateCost(days, includeInsurance);
            vehicle = "bike";
        }

        Console.WriteLine($"The estimated rental cost of the {vehicle} is: ${estimatedCost}");
    }
}