// enter a number of rolls 
// how many rolls occur for each number
// print results

using Mission02;
using static System.Net.Mime.MediaTypeNames;

DiceTools dt = new DiceTools();

int TotalRolls = 0;
string line = "";


System.Console.WriteLine("Welcome to the dice throwing simulator!");
System.Console.WriteLine("How many times do you want to roll the dice?");


line = System.Console.ReadLine();
int value;
if (int.TryParse(line, out value))
{
    TotalRolls = int.Parse(line);
 
    System.Console.WriteLine("");
    System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
    System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
    System.Console.WriteLine("Total number of rolls = " + TotalRolls+ "\r\n");
    dt.RollCounter(TotalRolls);
}
else
{
    System.Console.WriteLine("Invalid number. Try again.");
    
};

