using System;

namespace CSharpes
{
    class Program
    {
        static void Main(string[] args)
        {
			var manufacturer = new Manufacturer();
			Console.WriteLine("What is the name of the Manufacturer?");
			manufacturer.Name = Console.ReadLine();

			Console.WriteLine("Type 'Add' to add a Driver");
			Console.WriteLine("Type 'Announce' to announce the Manufacturer");
			Console.WriteLine("Type 'Quit' to quit the application");

			while (true)
			{
				Console.WriteLine("Add, Announce, or Quit?");
				var action = Console.ReadLine();

				if (action == "Add")
					manufacturer.AddDriver();
					
				else if (action.StartsWith("Add"))
				{
					var arguments = action.Split();
					manufacturer.AddDriver(arguments[1], arguments[2]);
				}

				else if (action == "Announce")
					manufacturer.Announce();

				else if (action == "Quit")
					break;

				else
					Console.WriteLine(action + " Is invalid, Quit yo jibba jabba fool...");
			}
			//Console.Read();
		}
    }
}
