using System;

class TemperatureTracker
{
    private double[] temperatures;

    public TemperatureTracker()
    {
        temperatures = new double[7]; 
    }

    public void InputTemperatures()
    {
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write($"Enter temperature for Day {i + 1}: ");
            double temp;
            while (!double.TryParse(Console.ReadLine(), out temp)) 
            {
                Console.WriteLine("Invalid . Please enter a number.");
            }
            temperatures[i] = temp;
        }
    }

    public void DisplayTemperatures()
    {
        Console.WriteLine("\nWeekly Temperature Report:");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {temperatures[i]}°C");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureTracker tracker = new TemperatureTracker();
        tracker.InputTemperatures();
        tracker.DisplayTemperatures();
    }
}
