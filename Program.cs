using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
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

        }
    }
}
