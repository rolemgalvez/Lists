//Welcome message
Console.WriteLine("Sequence");
Console.WriteLine("---------");

//Declare variables
bool runAgain;
string currentSequence = $"{true}, {false}";

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.WriteLine("-----------------");
    Console.WriteLine($"Current Sequence: {currentSequence}");
    Console.WriteLine("-----------------");
    Console.Write("Enter boolean value to add in the sequence: ");
    bool validInput = bool.TryParse(Console.ReadLine(), out bool value);

    //Valid input
    if (validInput == false)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
        runAgain = true;
    }

    if (validInput)
    {
        //Update values
        List<string> sequences = currentSequence.Split(", ").ToList();
        sequences.Add(value.ToString());
        currentSequence = $"{sequences[0]}";
        int ctr = 1;
        while (ctr < sequences.Count)
        {
            currentSequence += $", {sequences[ctr++]}";
        }

        //Show results
        Console.WriteLine();
        Console.WriteLine("-----------------");
        Console.WriteLine($"Updated Sequence: {currentSequence}");
        Console.WriteLine("-----------------");
        Console.Write("Enter \"yes\" to add again: ");
        runAgain = Console.ReadLine()?.ToLower() == "yes";
    }

} while (runAgain);

//End of program
Console.WriteLine();
Console.WriteLine("End of program");
Console.ReadLine();