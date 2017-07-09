using System;

namespace Person {
	class MainClass {
		public static void Main(string[] args) {
			Student s = new Student("Calvin", "Nguyen");
			employee e1 = new hourly_employee("Alan", "Walker", 15.00, 6, "Math");
			employee e2 = new full_time_salaried_employee("Thana", "God", "CIS", 70000);

			Console.WriteLine("----------Testing method for PT-Employee class----------");
			Console.WriteLine("Hours Work of one month: {0} Hours", e1.totalHr());
			Console.WriteLine("Hours Work Per Week: {0} Hours", e1.HrPerWeek());
			Console.WriteLine("Wages for 4 weeks: ${0}",e1.totalWage());

			Console.WriteLine();

			Console.WriteLine("----------Testing method for FT-Employee class----------");
			Console.WriteLine("Hours Work of one month: {0} Hours", e2.totalHr());
			Console.WriteLine("Hours Work Per Week: {0} Hours", e2.HrPerWeek());
			Console.WriteLine("Wages for 4 weeks: ${0}", e2.totalWage());

			Console.WriteLine();

			Console.WriteLine("----------Testing Student Class and print Transcript----------");
			s.addClass("Math", "C", 5);
			s.addClass("English", "A", 4);
			s.addClass("CIS 23", "B", 4);
			s.addClass("Sociology", "D", 3);
			s.addClass("Chemistry", "A", 5);
			s.dropClass("Math");
			Console.Write(s.printTranscript());
		}
	}
}
