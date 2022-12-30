//Welcome message
Console.WriteLine("Measurements");
Console.WriteLine("------------");

//Declare variables
bool runAgain;
string currentMeasurements = "123.2, 5.3";

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.WriteLine("---------------------");
    Console.WriteLine($"Current measurements: {currentMeasurements}");
    Console.WriteLine("---------------------");
    Console.Write("Enter measurement to add: ");
    bool validInput = double.TryParse(Console.ReadLine(), out double nextValue);

    //Validate input
    if (validInput == false)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
        runAgain = true;
    }

    if (validInput)
    {
        //Update measurements
        List<string> measurements = currentMeasurements.Split(", ").ToList();
        measurements.Add(nextValue.ToString());
        currentMeasurements = $"{measurements[0]}";
        int ctr = 1;
        while (ctr < measurements.Count)
        {
            currentMeasurements += $", {measurements[ctr++]}";
        }

        //Show results
        Console.WriteLine("---------------------");
        Console.WriteLine($"Updated measurements: {currentMeasurements}");
        Console.WriteLine("---------------------");
        Console.Write("Enter \"yes\" to add again: ");
        runAgain = Console.ReadLine()?.ToLower() == "yes";
    }

} while (runAgain);

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();