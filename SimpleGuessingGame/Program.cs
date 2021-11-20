string secretWord = "monkey";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outOfGuesses = false;

while (guess != secretWord && !outOfGuesses)
{
    if (guessCount < guessLimit)
    {
        Console.WriteLine("Enter a guess! ");
        guess = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfGuesses = true;
    }
}

if (outOfGuesses)
{
    Console.WriteLine("Sorry,you lose!");
}
else
{
    Console.WriteLine("Congrats,you win!");
}