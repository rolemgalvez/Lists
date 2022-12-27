//Welcome message
Console.WriteLine("Pay Grades");
Console.WriteLine("----------");

//Declare variables
bool runAgain;
string payGrades = "100,200";

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.WriteLine("-------------------");
    Console.WriteLine($"Current Pay Grades: {payGrades}");
    Console.WriteLine("-------------------");
    Console.Write("Enter pay grade to add: ");
    bool validInput = decimal.TryParse(Console.ReadLine(), out decimal value);
    runAgain = validInput == false;

    //Validate input
    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }
    else
    {
        //Update pay grade list
        List<string> payGradeList = payGrades.Split(',').ToList();
        payGradeList.Add(value.ToString());
        payGrades = payGradeList[0];
        int ctr = 1;
        while (ctr < payGradeList.Count)
        {
            payGrades += $",{payGradeList[ctr++]}";
        }

        //Ask if add again
        Console.WriteLine();
        Console.WriteLine("-------------------");
        Console.WriteLine($"Current Pay Grades: {payGrades}");
        Console.WriteLine("-------------------");
        Console.Write("Enter \"yes\" to again: ");
        string? againAnswer = Console.ReadLine()?.ToLower();
        runAgain = againAnswer == "yes";
    }

} while (runAgain);

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();