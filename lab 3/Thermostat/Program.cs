namespace Thermostat {
	class MainClass {
		public static void Main(string[] args) {
			ThermoStat t = new ThermoStat(0, 100);

			System.Console.WriteLine("-----------Testing setting the degree to 50--------------\n");
			t.setTemp(50);
			System.Console.WriteLine("The Temprerature is set to {0}\n", t.Degree);

			//System.Console.WriteLine("-----------Testing setting the degree to 150--------------\n");
			//System.Console.WriteLine("Print out the TempTooLow Exception");
			//t.setTemp(150);

			System.Console.WriteLine("-----------Testing setting the degree to -50--------------\n");
			System.Console.WriteLine("Print out the TempTooLow Exception");
			t.setTemp(-50);

			         
		}
	}
}
