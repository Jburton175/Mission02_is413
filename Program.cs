// enter a number of rolls 
// how many rolls occur for each number
// print results

using Mission02;
using static System.Net.Mime.MediaTypeNames;

DiceTools dt = new DiceTools();

int TotalRolls = 0;
string line = "";

System.Console.WriteLine("How many times do you want to roll the dice?");


line = System.Console.ReadLine();
int value;
if (int.TryParse(line, out value))
{
    TotalRolls = int.Parse(line);

    dt.RollCounter(TotalRolls);
}
else
{
    System.Console.WriteLine("Invalid Number");
    
};

