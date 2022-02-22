// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, это игра Угадай число");
Console.WriteLine("Введите свое имя");
string? userName = Console.ReadLine();

Console.WriteLine($"Привет {userName}");

var random = new Random();
int Number = random.Next(0, 99);
bool isWin = false;
int score = 1;

while (!isWin)
{
    int userNumber = -1;
    bool isIntNumber = false;

    do
    {
        Console.WriteLine("Загадано число от 0 до 99, какое число было загадано?");
        string? userInput = Console.ReadLine();
        isIntNumber = int.TryParse(userInput, out userNumber);

        if (!isIntNumber)
        {
            Console.WriteLine($" вы ввели {userInput}.Загадано число от 0 до 99");
        }
    } while (!isIntNumber);

    if (userNumber > Number)
    {
        Console.WriteLine($"Ваше число ({userNumber}), больше чем загаданное число");
        score++;
    }
    else if (userNumber < Number)
    {
        Console.WriteLine($"Ваше число ({userNumber}), меньше чем загаданное число");
        score++;
    }
    else
    {
        isWin = true;
        Console.WriteLine($"Вы угадали число за {score} попыток");
    }
}
