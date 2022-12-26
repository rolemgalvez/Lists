//Welcome message
Console.WriteLine("Employees");
Console.WriteLine("---------");

//Prepare variables
bool runAgain;
string employees = "Juan,Pedro";

do
{
    runAgain = false;


    //Get user input
    Console.WriteLine();
    Console.WriteLine("----------------------");
    Console.WriteLine($"Current employee list: {employees}");
    Console.WriteLine("----------------------");
    Console.Write("Enter first name of the employee to add: ");
    string? userInput = Console.ReadLine();
    runAgain = string.IsNullOrEmpty(userInput);

    //Validate input
    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }
    else
    {
        //Process input
        List<string> employeeList = employees.Split(",").ToList();
        employeeList.Add(userInput);
        employees = employeeList[0];
        int ctr = 1;
        while (ctr < employeeList.Count)
        {
            employees += $",{employeeList[ctr++]}";
        }

        //Ask if add again
        Console.WriteLine("----------------------");
        Console.WriteLine($"Current employee list: {employees}"); 
        Console.WriteLine("----------------------");
        Console.Write("Enter \"yes\" if want to add again: ");
        runAgain = string.Equals(Console.ReadLine()?.ToLower(), "yes");
    }

} while (runAgain);

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();