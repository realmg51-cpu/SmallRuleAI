using System;

namespace NtAI
{
    class Response
    {
        private static Random rand = new Random();
        
        private static string[] nullResponses = {
            "Oops! Please talk anything!",
            "You didn't say anything! Try again!",
            "Hello? Are you there?",
            "Don't be shy, say something!"
        };
        
        private static string[] greetResponses = {
            "Hi there! What's up!",
            "Hello! Nice to see you!",
            "Hey! How's your day going?",
            "Greetings! What can I do for you?"
        };
        
        private static string[] fineResponses = {
            "Fine, thank you!",
            "I'm doing great! Thanks for asking!",
            "Wonderful! And you?",
            "Couldn't be better!"
        };
        
        private static string[] byeResponses = {
            "Bye! See you again!",
            "Goodbye! Have a nice day!",
            "See you later! Take care!",
            "Bye bye! Come back soon!"
        };
        
        private static string[] elseResponses = {
            "Sorry, I don't know about that",
            "I'm not sure how to respond to that",
            "Interesting! Tell me more!",
            "Hmm, I haven't learned about that yet"
        };
        
        public static void HandleNull()
        {
            Console.WriteLine(nullResponses[rand.Next(nullResponses.Length)]);
        }
        
        public static void Greet()
        {
            Console.WriteLine(greetResponses[rand.Next(greetResponses.Length)]);
        }
        
        public static void SayFine()
        {
            Console.WriteLine(fineResponses[rand.Next(fineResponses.Length)]);
        }
        
        public static void SayBye()
        {
            Console.WriteLine(byeResponses[rand.Next(byeResponses.Length)]);
        }
        
        public static void HandleElse()
        {
            Console.WriteLine(elseResponses[rand.Next(elseResponses.Length)]);
        }
        public static void IntroduceAboutThisProgram()
        {
            Console.WriteLine(@"
                About this program:
                This program written in C# basic, by dryfish09 (formerly realmg51-cpu)
                This program under license MIT.
                Available command:
                - exit (to exit program).
                - introduce (to introduce this program.
                ");
        }
    }
}

