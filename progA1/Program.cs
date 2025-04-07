using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace progA1
{// lerato molokomme st10439626
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                 SoundPlayer player = new SoundPlayer("C:\\Users\\lerat");
                 player.Play();
               
          
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't play welcome sound: " + ex.Message);
            }



            // CREATING A LOGO 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
   _____      _                _____                      _   _             
  / ____|    | |              / ____|                    | | | |            
 | |    _   _| |__   ___ _ __| (___  ___  _ __ ___   ___ | |_| |_ ___ _ __  
 | |   | | | | '_ \ / _ \ '__\___ \/ _ \| '_ ` _ \ / _ \| __| __/ _ \ '__| 
 | |___| |_| | |_) |  __/ |  ____) | (_) | | | | | | (_) | |_| ||  __/ |    
  \_____\__, |_.__/ \___|_| |_____/ \___/|_| |_| |_|\___/ \__|\__\___|_|    
         __/ |                                                              
        |___/                                                               
");


            // creating a intro
            Console.WriteLine("=============================================");
            Console.WriteLine(" Input your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("hello :) im susan how can I help you " + name + "  ?");
            Console.WriteLine("=============================================");

            //basic resopnse system &  //input validator 


            while (true)
            {


                string question = Console.ReadLine()?.Trim();



                if (string.IsNullOrEmpty(question))
                {
                    Console.WriteLine("I didnt understand that " + name + "  try again?");
                    continue;

                }

                if (question.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye :)" + name);
                    break;
                }

                // creating the response to user question .
                switch (question.ToLower())
                {
                    case "how are you":
                        Console.WriteLine("im great and how are you :");
                        break;

                    case "what's your purpose":
                        Console.WriteLine("I'm a chat box at your assistance");
                        break;

                    case "what can i ask you about?":
                        Console.WriteLine("anything relates to passwords , phishing and safe browsing");
                        break;

                    case "password":
                        Console.WriteLine(" A password is a string of characters used to verify a user's identity and grant access to systems, applications, or data.");
                        Console.WriteLine(" It serves as an authentication tool to protect sensitive information from unauthorized access.");
                        Console.WriteLine(" Passwords are a fundamental layer of security, safeguarding personal and organizational data against cyber threats such as hacking, identity theft, and data breaches.");
                        break;


                    case "phishing":
                        Console.WriteLine("Phishing is a cybercrime where targets are contacted by someone posing as a legitimate institution to lure individuals into providing sensitive data.");
                        Console.WriteLine("Common phishing techniques include:");
                        Console.WriteLine("- Fake emails pretending to be from trusted sources");
                        break;


                    case "safe browsing":
                        Console.WriteLine("Safe browsing practices include:");
                        Console.WriteLine("- Using HTTPS websites (look for the padlock icon)");
                        Console.WriteLine("- Keeping your browser and plugins updated");
                        Console.WriteLine("- Being cautious with downloads and email attachments");
                        break;

                    default:
                        Console.WriteLine(" I'm still learning , please input anything related to passwords, phishing , and safe browsing ");
                        break;
                }
            }
        }
    }
}
