/*Maleah Ristau October 5th 2020 - October 20th 2020 - October 27th 2020
Study Application: "Study Buddy"
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Study
{
class MainClass {
  public static void Main (string[] args) {
    Console.Title = "Study Buddy By Maleah Ristau";
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine ("Welcome! This is Study Buddy, a application to help you learn about some Programming terms.");
    MatchGame.Build();
    
  }
}
}