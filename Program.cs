//Michelle Malfabon
//Aug. 9 2022

//Description: declared string for name, printed question with Console.Writeline, 
//used Console.Readline for user to input name and stored that in variable called name. 
//Then I printed the greeting with name using interpolation. 

//------Mini Challenge 1--SAY HELLO----------///
// Directtions: Create a brand new console project where you are asked your name. 
// You will then print out the following "Hello <name entered>"
// Name entered should be the variable that the user types in. 

string name;
int playAgain;

void PlayGame()
{
Console.WriteLine("Hey, what is your name?");
name = Console.ReadLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine("Enter 1 to play again.");
playAgain= Convert.ToInt32(Console.ReadLine());
if (playAgain== 1)
{
    PlayGame();
}
else{
    Console.WriteLine("Goodbye.");
}
}

PlayGame();