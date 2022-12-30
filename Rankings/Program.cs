//Welcome message
Console.WriteLine("Rankings");
Console.WriteLine("--------");

//Declare variables
bool runAgain;
string currentRankings = "6,8";

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.WriteLine("-----------------");
    Console.WriteLine($"Current Rankings: {currentRankings}");
    Console.WriteLine("-----------------");
    Console.Write("Enter id number for the next rank: ");
    bool validInput = int.TryParse(Console.ReadLine(), out int nextId);

    //Validate input
    if (validInput == false)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
        runAgain = true;
    }

    if (validInput)
    {
        //Update content
        List<string> rankings = currentRankings.Split(',').ToList();
        rankings.Add(nextId.ToString());
        currentRankings = $"{rankings[0]}";
        int ctr = 1;
        while (ctr < rankings.Count)
        {
            currentRankings += $",{rankings[ctr++]}";
        }

        //Show output
        Console.WriteLine();
        Console.WriteLine("-----------------");
        Console.WriteLine($"Updated Rankings: {currentRankings}");
        Console.WriteLine("-----------------");
        Console.Write("Enter \"yes\" to add again: ");
        runAgain = Console.ReadLine()?.ToLower() == "yes";
    }

} while (runAgain);

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();