using System;

/*
                        Phase:1
Display a message to the user asking them to guess the secret number.
Display a prompt for the user's guess.
Take the user's guess as input and save it as a variable.
Display the user's guess back to the screen.
*/

// Console.WriteLine("Guess the secret numer ");
// string input = Console.ReadLine();
// int parsedInput = int.Parse(input);
// int userInput = parsedInput;
// Console.Write("You guessed number:");
// Console.WriteLine(userInput);

/*
                        Phase:2
Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
No longer display the user's guess. They know what they guessed, right?
Compare the user's guess with the secret number. Display a success message if the guess is correct, otherwise display a failure message.
*/


// Console.WriteLine("Guess the secret numer ");
// int secretNumber = 42;
// string input = Console.ReadLine();
// int parsedInput = int.Parse(input);
// int userInput = parsedInput;
// if(userInput == secretNumber){
//     Console.WriteLine("Yay! You guessed It!");
// }else{
//     Console.WriteLine("Booo! Try again!");
// }

// /*
//                         Phase:3
// Give the user four chances to guess the number.
// Continue to display the success or failure messages as in phase 2
// */

// for (int i = 0; i < 4; i++)
// {
//     Console.WriteLine("Guess the secret numer ");
//     int secretNumber = 42;
//     string input = Console.ReadLine();
//     int parsedInput = int.Parse(input);
//     int userInput = parsedInput;

//     if(userInput == secretNumber){
//     Console.WriteLine("Yay! You guessed It!");
// }else{
//     Console.WriteLine("Booo! Try again!");
// }

// }


/*
                        Phase:4
Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
End the loop early if the user guesses the correct number.
*/
// Console.WriteLine("Guess the secret number:");
// int secretNumber = 42;

// while (true)//creates an infinite loop that is manually exited using break when the user guesses the secret number correctly.
// {
//     string input = Console.ReadLine();


//     try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         Console.Write("Your guess is:");
//         Console.WriteLine(userParsedInput);

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             Console.WriteLine("Wrong guess. Try again:");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }
// }

/*
                        Phase:5
Use a random number between 1 and 100 instead of a hard-coded number.
The prompt should display the number of guesses the user has left.
*/


// for (int i = 0; i < 4; i++)
// {
//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(4-i );
//    Console.WriteLine("guesses");
//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         Console.Write("Your guess is:");
//         Console.WriteLine(userParsedInput);

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             Console.WriteLine("Wrong guess. Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

// }


/*
                        Phase:6
Inform the user if their guess was too high or too low, when they guess incorrectly.
*/



/*
                        Phase:7
Prompt the user for a difficulty level before they are prompted to guess the number.
The difficulty level should determine how many guesses the user gets. The difficulty levels should be:
Easy - this gives the user eight guesses.
Medium - this gives the user six guesses.
Hard - this gives the user four guesses.
*/

// Console.Write("Select Difficulty level(Easy, Medium, Hard):");
// string difficultyInput = Console.ReadLine();

// if(String.Equals(difficultyInput, "Easy", StringComparison.OrdinalIgnoreCase))

// {
//     for (int i = 0; i < 8; i++)
// {

//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(8-i );
//    Console.WriteLine("guesses");

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
// //    Console.WriteLine(secretNumber);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {
//             Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{
//              Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

// }

// } else if (String.Equals(difficultyInput, "Medium", StringComparison.OrdinalIgnoreCase))
// {
//         for (int i = 0; i < 6; i++)
// {

//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(6-i );
//    Console.WriteLine("guesses");

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
// //    Console.WriteLine(secretNumber);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {
//             Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{
//              Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

//     }
// } else if(String.Equals(difficultyInput, "Hard", StringComparison.OrdinalIgnoreCase))
// {
//         for (int i = 0; i < 4; i++)
// {

//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(4-i );
//    Console.WriteLine("guesses");

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
// //    Console.WriteLine(secretNumber);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {
//             Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{
//              Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

//     }
// } else 
// {
//     Console.WriteLine("Invalid input. Please enter a valid number:");
// }



/*
                        Phase:8
Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.
*/

// Console.Write("Select Difficulty level(Easy, Medium, Hard, Cheater):");
// string difficultyInput = Console.ReadLine();

// if(String.Equals(difficultyInput, "Easy", StringComparison.OrdinalIgnoreCase))

// {
//     for (int i = 0; i < 8; i++)
// {

//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(8-i );
//    Console.WriteLine("guesses");

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
// //    Console.WriteLine(secretNumber);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {
//             Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{
//              Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

// }

// } else if (String.Equals(difficultyInput, "Medium", StringComparison.OrdinalIgnoreCase))
// {
//         for (int i = 0; i < 6; i++)
// {

//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(6-i );
//    Console.WriteLine("guesses");

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
// //    Console.WriteLine(secretNumber);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {
//             Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{
//              Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

//     }
// } else if(String.Equals(difficultyInput, "Hard", StringComparison.OrdinalIgnoreCase))
// {
//         for (int i = 0; i < 4; i++)
// {

//    Console.Write("Guess the secret number,");
//    Console.Write("You have: ");
//    Console.Write(4-i );
//    Console.WriteLine("guesses");

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
// //    Console.WriteLine(secretNumber);
//    string input = Console.ReadLine();

//    try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {
//             Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{
//              Console.Write("Your guess is:");
//             Console.WriteLine(userParsedInput);
//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }

//     }
//  }else if(String.Equals(difficultyInput, "Cheater", StringComparison.OrdinalIgnoreCase))
// {

//    int secretNumber = RandomNumberGenerator.GetRandomInt(1, 100);
//     Console.WriteLine(secretNumber);


// while (true)
// {
//      Console.Write("Guess the secret number:");
//     string input = Console.ReadLine();
//     try
//     {
//         int userParsedInput = int.Parse(input);//convert user input from string to int

//         Console.Write("Your guess is:");
//         Console.WriteLine(userParsedInput);

//        if (userParsedInput == secretNumber)
//         {
//             Console.WriteLine("Congratulations! You guessed the secret number.");
//             break;//used to exit the while loop when the user successfully guesses the secret number
//         }
//         else
//         {
//             if (userParsedInput < secretNumber)
//         {

//             Console.WriteLine("Wrong guess. It is too low! ");
//         } else{

//             Console.WriteLine("Wrong guess. It is too high! ");
//         }
//             Console.WriteLine("Try again!");
//         }
//     }
//     catch
//     {
//         Console.WriteLine("Invalid input. Please enter a valid number:");
//     }
// }

// } else 
// {
//     Console.WriteLine("Invalid input. Please enter a valid number:");
// }



// Function to generates a random number 
// public class RandomNumberGenerator
// {
//     public static int GetRandomInt(int min, int max)
//     {
//         Random random = new Random();
//         return random.Next(min, max + 1);
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        // Usage Example in a Program.cs file somewhere
        Car stella = new Car();

        // UseEmergencyBreak method can use the protected SqueezeBreakPads from the Automobile class.
        Console.WriteLine($"Applying the break: {stella.UseEmergencyBreak()}");

    }
}