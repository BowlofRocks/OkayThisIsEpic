using System;
using System.Threading;


namespace week3;


public class Main
{
//main function


static void Main(string[] args)
{
    do
    {
        bool play_again = true;
        float continue_game;
        Console.WriteLine("The card is: "); // number to be displayed after card class is complete
        Console.WriteLine("Higher or lower? [h/l] ");
        Console.ReadLine();
        Console.WriteLine("Next card was: "); // also needed from card class
        Console.WriteLine("Your score is: "); // enter from score function
        Console.WriteLine("Play again? [y/n] ");     
        continue_game = Console.ReadLine();
        
    }
    while (play_again == true);
    
}

//display function (display rules of game)



//score function(keeps track of score as game is played)




   
            
}