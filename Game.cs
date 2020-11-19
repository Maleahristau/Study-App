using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Study
{

  class Game {
     public static void Run(){
       Player player= new Player();
       int[] i = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
       Random rnd = new Random();

       int a = rnd.Next(i.Length);
       string answer;
       
       
        switch (a)
    {
          case 1:
            Console.WriteLine("A variable about to be True or false. 1.Bolean (bool) 2.string 3.integer 4.int ");
            answer = Console.ReadLine();
            if(answer == "1"){player.Score = player.Score+1;}
            Console.WriteLine(player.Score);
            break;
          case 2:
            Console.WriteLine("A variable of charaters 1.Bolean (bool) 2.string 3. array 4.");//string
            answer = Console.ReadLine();
            if(answer == "2"){player.Score = player.Score+1;}
             break;
          case 3:
            Console.WriteLine("A variable of a whole number with the decimal up to the hundreths. 1.Bolean (bool) 2.double 3.integer 4.while loop ");//double
            answer = Console.ReadLine();
            if(answer == "2"){player.Score = player.Score+1;}
            break;
          case 4:
            Console.WriteLine("A variable that is a whole number. 1.integer 2.string 3.array 4.while loop ");//integer
            answer = Console.ReadLine();
            if(answer == "1"){player.Score = player.Score+1;}
            break;
          case 5:
            Console.WriteLine("A number with an infinite decimal. 1.Bolean (bool) 2.string 3.array 4.float ");// float
            answer = Console.ReadLine();
            if(answer == "4"){player.Score = player.Score+1;}
            break;
          case 6:
            Console.WriteLine("A loop that repeatedly executes a block of code as long as the specified condition returns false. 1.for loop 2.string 3.array 4.while loop ");//while loop
            answer = Console.ReadLine();
            if(answer == "4"){player.Score = player.Score+1;}
            break;
          case 7:
            Console.WriteLine("A loop that executes while the statement remains true. 1.Bolean (bool) 2.string 3.for loop 4.int ");// for loop
            answer = Console.ReadLine();
            if(answer == "3"){player.Score = player.Score+1;}
            break;
          case 8:
            Console.WriteLine("An access modifier that causes whatever is modifited to be closed to the class or the struct it is within. 1.Bolean (bool) 2.string 3.array 4.private ");//private
            answer = Console.ReadLine();
            if(answer == "4"){player.Score = player.Score+1;}
            break;
          case 9:
            Console.WriteLine("An access modifier that causes whatever is modifited to be opened to the class or the struct it is within. 1.Bolean (bool) 2.public 3.conditional statement 4.instance "); //public
            answer = Console.ReadLine();
            if(answer == "2"){player.Score = player.Score+1;}
            break;
          case 10:
            Console.WriteLine("A method signature to declare a method that does not return a value. 1.conditional statement 2.string 3.void 4.increment ");
            answer = Console.ReadLine();
            if(answer == "3"){player.Score = player.Score+1;}
            break; //void
            case 11:
            Console.WriteLine("An operator that evaluates a Boolean expression and reacts accordingly. 1.increment 2.conditional statement 3.array 4.instance ");//conditional statement
            answer = Console.ReadLine();
            if(answer == "2"){player.Score = player.Score+1;}
            break;
            case 12:
            Console.WriteLine("A number used to call an element from an array. 1.Bolean (bool) 2.increment 3.array 4.array index number ");//array index number
            answer = Console.ReadLine();
            if(answer == "4"){player.Score = player.Score+1;}
            break;
            case 13:
            Console.WriteLine("An operator is used to add 1 to a variable. 1.Bolean (bool) 2.string 3.array 4.increment ");//increment
            answer = Console.ReadLine();
            if(answer == "4"){player.Score = player.Score+1;}
            break;
            case 14:
            Console.WriteLine("A data type that holds multiple variables within it. 1.Bolean (bool) 2.string 3.array 4.instance ");//array
            answer = Console.ReadLine();
            if(answer == "3"){player.Score = player.Score+1;}
            break;
            case 15:
            Console.WriteLine("A variable of any type contained within a class or struct, and is used to store object data. 1.instance 2.string 3.array 4. ");//"instance"
            answer = Console.ReadLine();
            if(answer == "1"){player.Score = player.Score+1;}
            break;
          
      }
     }
  }

}

