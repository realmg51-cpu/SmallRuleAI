using System;
using DryFish.ILib;
namespace NtAI
{
	class Core
	{
		public static void Logic()
		{
			bool run = true;
			while(run)
			{
				ILib.ISetConsoleColor("green");
				Console.Write("You: ");
				ILib.IResetConsoleColor();
				string input = Console.ReadLine()?.ToLower().Trim() ?? "";
				ILib.ISetConsoleColor("cyan");
				Console.Write("bot: ");
				ILib.IResetConsoleColor();
				if(string.IsNullOrWhiteSpace(input))
				{
					Response.HandleNull();
				}
				else if(input.Contains("hi") || input.Contains("hello"))
				{
					Response.Greet();
				}
				else if(input.Contains("how are you") || input.Contains("how r u") || input.Contains("how r you"))
				{
					Response.SayFine();
				}
				else if(input == "exit")
				{
					Response.SayBye();
					run = false;
				}
				else if(input == "introduce")
				{
					Response.IntroduceAboutThisProgram();
				}
				else
				{
					Response.HandleElse();
				}
			}
		}
	}
}
