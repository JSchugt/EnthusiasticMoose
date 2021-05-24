using System;

string[,] mooseQuestions = {
    { "Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!" },
    {"Are you enthusiastic?","Yay!","You should try it!"},
    {"Do you love C# yet?","Good job sucking up to your instructor!","You will...oh, yes, you will..."},
    {"Do you want to know a secret?","ME TOO!!!! I love secrets...tell me one!","Oh, no...secrets are the best, I love to share them!"}
};
string[] magicQuestions = {"As I see it, yes.",
"Ask again later.",
"Better not tell you now.",
"Cannot predict now.",
"Concentrate and ask again.",
"Don’t count on it.",
"It is certain.",
"It is decidedly so.",
"Most likely.",
"My reply is no.",
"My sources say no.",
"Outlook not so good.",
"Outlook good.",
"Reply hazy, try again.",
"Signs point to yes.",
"Very doubtful.",
"Without a doubt.",
"Yes.",
"Yes – definitely.",
"You may rely on it."};
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
MooseSays("I really am enthusiastic");
bool first = MooseAsks("Do you want to ask the moose a question?");
if (first)
{
    Console.Write("What is your question?");
    string answer = Console.ReadLine();
    Random r = new Random();
    Console.WriteLine(magicQuestions[r.Next(0, magicQuestions.Length)]);
}
else
{
    bool second = MooseAsks("Do you want to play ro sham bo?");
    if (second)
    {
        MooseRocks();
    }
    else
    {

        for (int i = 0; i < mooseQuestions.Length / 3; i++)
        {
            if (MooseAsks(mooseQuestions[i, 0]))
            {
                MooseSays(mooseQuestions[i, 1]);
            }
            else
            {
                MooseSays(mooseQuestions[i, 2]);
            }
        }
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
void MooseRocks()
{
    string choice;
    bool quit = false;
    Random rock = new Random();
    while (!quit)
    {
        Console.Write("Rock(1), Paper(2), Scissor(3): ");
        choice = Console.ReadLine();
        Console.WriteLine(choice);
        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.Write($"{choice} is not an opption!");
            Console.Write("Rock(1), Paper(2), Scissor(3): ");
            choice = Console.ReadLine();
        }
        winner(choice, rock);
        Console.Write("Want to play again? (Y/N): ");
        string answer = Console.ReadLine().ToLower();
        while (answer != "y" && answer != "n")
        {
            Console.Write("Want to play again? (Y/N): ");
            answer = Console.ReadLine().ToLower();
        }
        if (answer == "n")
        {
            quit = true;
        }
    }
    Console.WriteLine("Thanks for playing!!!");
}

void winner(string choice, Random rock)
{
    string mooseChoice = rock.Next(1, 3).ToString();
    MooseSays($"I chose {getChoice(mooseChoice)}");
    if (mooseChoice == choice)
    {
        Console.WriteLine("We Tied!!");
    }
    else if (choice == "1" && mooseChoice == "3"
            || choice == "2" && mooseChoice == "1"
            || choice == "3" && mooseChoice == "2")
    {

        Console.WriteLine(" you won :(");
    }
    else
    {
        MooseSays("I WIN!!!!!");
    }
}

string getChoice(string choice)
{
    if (choice == "1") { choice = "rock"; }
    else if (choice == "2") { choice = "paper"; }
    else { choice = "scissor"; }
    return choice;

}