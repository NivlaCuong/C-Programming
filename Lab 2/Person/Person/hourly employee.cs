using System;
namespace Person {
	public class hourly_employee : employee {
		public double HrRate { get; set; }
		public double HourPerWeek { get; set; }
		public hourly_employee(string firstname, string lastname, double hourlyRate, double hoursPerWeek, string department) 
			:base(firstname, lastname, department) {
			HrRate = hourlyRate;
			HourPerWeek = hoursPerWeek;
		}
		public override double totalHr() {
			return HourPerWeek * 4;
		}
		public override double HrPerWeek() {
			return HourPerWeek;
		}
		public override double totalWage() {
			return HourPerWeek * HrRate * 4;
		}
	}
}
