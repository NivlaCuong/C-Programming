using System;
namespace Person {
	public class full_time_salaried_employee : employee {
		public double Salary { get; set; }
		public full_time_salaried_employee(string firstname, string lastname, string department, double salary) 
			:base(firstname, lastname, department) {
			Salary = salary;
		}
		public override double totalHr() {
			return 160;
		}
		public override double HrPerWeek() {
			return 40;
		}
		public override double totalWage() {
			return Salary/12;
		}
	}
}
