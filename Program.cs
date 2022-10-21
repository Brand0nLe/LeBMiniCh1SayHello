//Brandon Le
//10-20-22
//Mini Challenge 1 Say Hello
//Project will store the user's input for their name and print it back out to them in the terminal
//If user enters in numbers it will display a message to have them enter in their real name.
//Has the ability to play again.
//Peer Review: Madeline Gowan - I like the program! It runs as intended, and I appreciate the compliment on how beautiful 
//my name is lol. I also like the fact that Ken is then included into the conversation. I was a bit confused when it looped, 
//but I now understand that when it loops, it's because you said you have time to talk to Ken.

string userInput = "";
string userInputTwo = "";
int number = 0;
bool playAgain = true;
bool realName = true;


while (playAgain == true)
    {
    Console.WriteLine("Hello there! Nice to meet you. What's your name?");
    userInput = Console.ReadLine().ToUpper();
    realName = Int32.TryParse(userInput, out number);
    


    if (realName == true)
        {
        Console.WriteLine("It seems like you only entered numbers, is that your real name? Please enter your real name to continue:");
        userInput = Console.ReadLine();
        realName = Int32.TryParse(userInput, out number);
        }
    if (realName == false)
        {
        Console.WriteLine($"Hello {userInput} it's nice to meet you! What a beautiful name you have.");
        Console.WriteLine("Are you in a rush to go somewhere?");
        Console.WriteLine("YES/NO");
        userInputTwo = Console.ReadLine().ToUpper();

    if (userInputTwo == "YES")
        {
        playAgain = false;    
        Console.WriteLine("Goodbye! Have a great rest of your day! :)");
        }
    if (userInputTwo == "NO")
    {
        playAgain = true;
         Console.WriteLine("Oh you can meet my friend Ken. Here he is!");
         Console.WriteLine("Ken: \"Oh you're a new face.\"");
    }

        }

            


    }