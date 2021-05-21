using System;

string[,] mooseQuestions = {
    { "Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!" },
    {"Are you enthusiastic?","Yay!","You should try it!"},
    {"Do you love C# yet?","Good job sucking up to your instructor!","You will...oh, yes, you will..."},
    {"Do you want to know a secret?","ME TOO!!!! I love secrets...tell me one!","Oh, no...secrets are the best, I love to share them!"}
};
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");
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

