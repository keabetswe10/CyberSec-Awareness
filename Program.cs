using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSec_Awareness
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASCII Art Title Screen
            string asciiArt = @"
      .----------------.  
     | .--------------. |  
     | |  CYBERSEC   | |  
     | |  AWARENESS  | |  
     | |     BOT     | |  
     | '--------------' |  
      '----------------'  
        [==]    [==]   
       /~~~~\  /~~~~\   
      | |  | || |  | |   
      |_|  |_||_|  |_|  
            ";

            Console.WriteLine(asciiArt);


            // Personalized Welcome Message
            SoundPlayer player = new SoundPlayer(@"audio.wav"); // Add your own audio file
            player.PlaySync(); // Play audio synchronously

            // Ask user to enter their name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nWelcome, {userName}, to the Cybersecurity Awareness Bot!");
            Console.ResetColor();
            Console.WriteLine("I'm here to help you stay safe online.");

            // Display available questions
            DisplayAvailableQuestions();

            // Tell the user to ask a question
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine(" Ask Me a Question");
            Console.WriteLine("------------------------------------\n");

            Console.WriteLine("Ask me a question (or type 'exit' to quit):");

            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                // Tell the user to ask another question
                ProcessInput(input, userName);
                Thread.Sleep(500); // Pause before asking the next question
                Console.WriteLine("Ask another question:");
            }
        }

    }
}
