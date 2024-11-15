// if (6 >= 3)
// {
    // Console.WriteLine("Hello, World!");
// }

// Console.Write("Enter username: ");
// string username = Console.ReadLine();
// if (username == "kalleanka")
// {
    // Console.WriteLine("Welcome!");
// }

// Console.Write("Enter username: ");
// string user = Console.ReadLine();
// Console.Write("Enter password: ");
// string password = Console.ReadLine();
// if (user == "kalleanka" && password == "12345")
// {
//   Console.WriteLine("Welcome!");
// }
// else
// {
//   Console.WriteLine("Wrong username or password");
// }

// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, World!");
// }

// string correctPassword = "password";
// string inputPassword;
// do
// {
//     Console.Write("Enter password: ");
//     inputPassword = Console.ReadLine();
// } while (inputPassword != correctPassword);
// Console.WriteLine("Access granted.");

// for (int i = 0; i < 5; i++)
// {
//     Console.Write("Enter a number: ");
//     if (int.TryParse(Console.ReadLine(), out int number))
//     {
//         if (number > 5)
//         {
//             Console.WriteLine("Higher than 5!");
//         }
//         else
//         {
//             Console.WriteLine("5 or lower.");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Invalid number.");
//     }
// }

// string input;
// bool isNumeric;
// do
// {
//     Console.Write("Enter a string: ");
//     input = Console.ReadLine();
//     isNumeric = int.TryParse(input, out _);
// } while (isNumeric);
// Console.WriteLine("You entered a non-numeric string.");

Random random = new Random();
int secretNumber = random.Next(1, 101); // Random number between 1 and 100
int guess;
bool isValid;

Console.WriteLine("Guess the number between 1 and 100!");

do
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();
    
    // Check if input can be converted to an integer
    isValid = int.TryParse(input, out guess);
    
    if (isValid)
    {
        if (guess < secretNumber)
        {
            Console.WriteLine("Too low!");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("Too high!");
        }
        else
        {
            Console.WriteLine("Correct! You guessed the number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
    
} while (!isValid || guess != secretNumber);



