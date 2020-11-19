using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Study
{
  class MatchGame
  {
    public static void Build()
        {

          //Setting some style
          Console.ForegroundColor = ConsoleColor.White;
          Console.BackgroundColor = ConsoleColor.Blue;

          //Player's name collected And 
          Console.WriteLine("First, what is your name?");
          Player player= new Player(); 
          Console.ResetColor();
          player.Name = Console.ReadLine();
    
          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("Welcome "+ player.Name + "! Let's start with all 15 terms and their definitions");
          Console.ResetColor();


           string[] terms = { "Bolean (bool)", "string", "double","integer", "float","while loop","for loop","private","public","void","conditional statement","array index number","increment","array","instance"};

           string[] definitions = { "A variable about to be True or false.", "A variable of charaters.", "A variable of a whole number with the decimal up to the hundreths.","A variable that is a whole number.", "A number with an infinite decimal","A loop that repeatedly executes a block of code as long as the specified condition returns false.","A loop that executes while the statement remains true.","An access modifier that causes whatever is modifited to be closed to the class or the struct it is within.","An access modifier that causes whatever is modifited to be opened to the class or the struct it is within.","A method signature to declare a method that does not return a value.","An operator that evaluates a Boolean expression and reacts accordingly. ","A number used to call an element from an array.","An operator is used to add 1 to a variable","A data type that holds multiple variables within it. ","A variable of any type contained within a class or struct, and is used to store object data"};
      

        for (int i = 0; i < 15; i++)
            {
               Console.ForegroundColor = ConsoleColor.Blue;
               Console.WriteLine(terms[i]+" : ");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine(definitions[i]);
            }

          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("Once you think you know the terms, press ENTER to continue");
          Console.ReadLine();
          Console.Clear();
          Console.WriteLine("In this Section you will be given 5 random definitions and 4 options. Enter the number according to the term you think is correct.");
          Console.ReadLine();

          Game.Run();
          Game.Run();
          Game.Run();
          Game.Run();
          Game.Run();
        
          Console.WriteLine(player.Name +" has scored "+player.Score+" Out of a Possible 5.");
          Console.ReadLine();
         // WriteAllText(player.Name, player.Score);
          Console.Clear();
        }
  }
}