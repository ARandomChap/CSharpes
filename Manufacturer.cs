using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpes
{
    public class Manufacturer
    {
		public string Name;
		public List<Driver> Drivers = new List<Driver>();

		public void Announce()
		{
			Console.WriteLine("Welcome " + Name + " to the event");

			foreach (var driver in Drivers)
			{
				Console.WriteLine("With " + driver.Name + " Driving a" + driver.CarModel);
			}
		}

		public void AddDriver()
		{
			var driver = new Driver();
			Console.WriteLine("what is the name of the driver?");
			driver.Name = Console.ReadLine();
			Console.WriteLine("what car will they be driving?");
			driver.CarModel = Console.ReadLine();

			Drivers.Add(driver);
		}

		public void AddDriver(string name, string model)
		{
			var driver = new Driver();
			driver.Name = name;
			driver.CarModel = model;
			Drivers.Add(driver);

			Console.WriteLine(driver.Name + " was added. He is driving a " +driver.CarModel);
		}
    }
}
