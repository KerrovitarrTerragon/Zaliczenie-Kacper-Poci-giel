string[] availableDecisions = { "challenge", "leave" };

static void DragonDisapproval()
{
    Console.WriteLine("Foolish being. Get out of my sight.");
    Environment.Exit(0);
}

static void DragonApproval()
{
    Console.WriteLine("Very well then, you have earned your freedom.");
    Environment.Exit(0);
}

Console.WriteLine("Welcome to my lair mortal. This is your last chance to leave. If you wish to challenge me then speak: Challenge. Lest you want to spare your life speak Leave, and never come back");
Console.WriteLine("What is your decision?");

string Decision = Console.ReadLine().ToLower().Trim();

while (!availableDecisions.Contains(Decision))
{
    Console.WriteLine("That is not a valid answer, human.");
    Decision = Console.ReadLine().ToLower().Trim();
}

if (Decision == "leave")
{
    DragonDisapproval();
}
else
{
    Console.WriteLine("Let us begin with something easy then.");
}

string NameOfTheGame = "Rock, Paper, Scissors";

    Console.WriteLine("We are going to play a simple game of what you humans call (" + NameOfTheGame + ")");
    Thread.Sleep(2000);
    Console.WriteLine("Instead we will be using fire, air, and water");
    Thread.Sleep(2000);
    Console.WriteLine("fire beats air, air beats water, water beats fire. Let us begin");
    Thread.Sleep(2000);

int humanPoints = 0;
int dragonPoints = 0;
string[] availableSigns = { "Fire", "Water", "Air" };

static string RandomSign(string[] signs)

{

Random random = new Random();
int index = random.Next(signs.Length);
return signs[index];

}

while (true)
{
    if (humanPoints < 3 && dragonPoints < 3)
    {
        Console.WriteLine("Provide sign, Human.");
        string humanSign = Console.ReadLine().ToLower().Trim();

        if (humanSign != "fire" && humanSign != "water" && humanSign != "air")
        {
            Console.WriteLine("That is not a valid answer, human.");
        }
        else
        {
            
                string dragonChoice = RandomSign(availableSigns);
                
                Console.WriteLine("Dragon chose: " + dragonChoice);
                if ((humanSign.ToLower() == "fire" && dragonChoice.ToLower() == "air") ||
                    (humanSign.ToLower() == "water" && dragonChoice.ToLower() == "fire") ||
                    (humanSign.ToLower() == "air" && dragonChoice.ToLower() == "water"))
                {
                    humanPoints++;
                    Console.WriteLine("Human wins this round!");
                }
                else if ((dragonChoice.ToLower() == "fire" && humanSign.ToLower() == "air") ||
                        (dragonChoice.ToLower() == "water" && humanSign.ToLower() == "fire") ||
                        (dragonChoice.ToLower() == "air" && humanSign.ToLower() == "water"))
                {
                    dragonPoints++;
                    Console.WriteLine("Dragon wins this round!");
                }
                else
                {
                    Console.WriteLine("Tie!");
                }

                Console.WriteLine($"Human: {humanPoints}, Dragon: {dragonPoints}");
        }
    }
    else
    {
            Console.WriteLine("The game has ended!");
            Thread.Sleep(2000);
            break;
    }
}

if (humanPoints == 3)
{
        string[] availableChoices = { "challenge", "leave" };

        Console.WriteLine("Impressive. This is your chance to leave, or are you eager for another challenge?");
        string choice = Console.ReadLine().ToLower().Trim();

        while (!availableChoices.Contains(choice))
        {
            Console.WriteLine("That is not a valid answer, human.");
            choice = Console.ReadLine().ToLower().Trim();
        }

        if (choice == "leave")
        {
            DragonApproval();
        }
        else
        {
            Console.WriteLine("Let another challenge begin then.");
        }
}
else
{
    DragonDisapproval();
}

Console.WriteLine("Now we will play the game of guessing. I will think of a number between 1 and 10. You have 3 attempts");

Random random = new Random();

int targetNumber = random.Next(1, 11);
int maxAttempts = 3;
int attemptsLeft = maxAttempts;

while (attemptsLeft > 0)
{
    Console.Write("What is the number I am thinking about? ");
    if (int.TryParse(Console.ReadLine(), out int userGuess))
    {
        if (userGuess == targetNumber)
        {
                Console.WriteLine("Impressive, you have managed to guess the number");
                Thread.Sleep(2000);
                break;
        }
        else
        {
                attemptsLeft--;

                if (userGuess < targetNumber)
                {
                    Console.WriteLine("The number I think of is greater.");
                }
                else
                {
                    Console.WriteLine("The number I think of is smaller.");
                }

                Console.WriteLine($"You have only {attemptsLeft} attempts left");
        }
    }
    else
    {
            Console.WriteLine("That is not a valid answer, human.");
    }
}

if (attemptsLeft == 0)
{
            Console.WriteLine($"You've run out of attempts. The number I was thinking of was {targetNumber}.");
            Thread.Sleep(2000);
            DragonDisapproval();
}
else
{
        string[] availableChoices = { "challenge", "leave" };
        Console.WriteLine("Impressive. This is your chance to leave, or are you eager for another challenge?");
        string choice = Console.ReadLine().ToLower().Trim();

        while (!availableChoices.Contains(choice))
        {
            Console.WriteLine("That is not a valid answer, human.");
            choice = Console.ReadLine().ToLower().Trim();
        }

        if (choice == "leave")
        {
            DragonApproval();
        }
        else
        {
            Console.WriteLine("Let another challenge begin then.");
        }
}

Console.WriteLine("This will be the test of wits. I will provide a riddle, and you will provide an answer.");
Thread.Sleep(2000);
Console.WriteLine("Ready yourself, human.");

    string[] options = { "Riddle1", "Riddle2", "Riddle3" };
    int index = random.Next(options.Length);
    string chosenRiddle = options[index];

ExecuteCodeForOption(chosenRiddle);

static void ExecuteCodeForOption(string option)
{
    int maxAttempts = 3;
    int attemptsLeft = maxAttempts;

            switch (option)
            {
                case "Riddle1":
                    Console.WriteLine("A palace made of silver hair,");
                    Thread.Sleep(2000);
                    Console.WriteLine("Shining jewels are laid there,");
                    Thread.Sleep(2000);
                    Console.WriteLine("but tiny thieves had best beware.");
                    Thread.Sleep(2000);
                    Console.WriteLine("What is it?");

                    while (attemptsLeft > 0)
                    {
                        string riddleAnswer = Console.ReadLine().ToLower().Trim();

                        if (riddleAnswer == "web")
                        {
                            Console.WriteLine("Impressive, you have guessed correctly.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That is not a correct answer.");
                            attemptsLeft--;
                        }
                    }
                    if (attemptsLeft == 0)
                    {
                        DragonDisapproval();
                    }
                    else
                    {
                        DragonApproval();
                    }
                    break;

                case "Riddle2":
                    Console.WriteLine("Born of water and wind,");
                    Thread.Sleep(2000);
                    Console.WriteLine("Only myself when with my kind,");
                    Thread.Sleep(2000);
                    Console.WriteLine("Though I feel soft beneath your feet, I am as hard as I've ever been.");
                    Thread.Sleep(2000);
                    Console.WriteLine("What am I?");

                    while (attemptsLeft > 0)
                    {
                        string riddleAnswer = Console.ReadLine().ToLower().Trim();

                        if (riddleAnswer == "snow")
                        {
                            Console.WriteLine("Impressive, you have guessed correctly.");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That is not a correct answer.");
                            attemptsLeft--;
                        }
                    }
                    if (attemptsLeft == 0)
                    {
                        DragonDisapproval();
                    }
                    else
                    {
                        DragonApproval();
                    }
                    break;

                case "Riddle3":
                    Console.WriteLine("A box without hinges,");
                    Thread.Sleep(2000);
                    Console.WriteLine("Nor lock or a key,");
                    Thread.Sleep(2000);
                    Console.WriteLine("Yet a golden treasure is hidden within.");
                    Thread.Sleep(2000);
                    Console.WriteLine("What is it?");

                    while (attemptsLeft > 0)
                    {
                        string riddleAnswer = Console.ReadLine().ToLower().Trim();

                        if (riddleAnswer == "egg")
                        {
                            Console.WriteLine("Impressive, you have guessed correctly.");
                            Thread.Sleep(2000);

                            break;
                        }
                        else
                        {
                            Console.WriteLine("That is not a correct answer.");
                            attemptsLeft--;
                        }
                    }
                    if (attemptsLeft == 0)
                    {
                        DragonDisapproval();
                    }
                    else
                    {
                        DragonApproval();
                    }
                    break;
    }
}

        




                        
                        
    


        
    

 


    

  


