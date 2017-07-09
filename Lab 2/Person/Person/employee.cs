using System;
namespace Person {
	public abstract class employee : Person {
		public string department;
		public employee(string firstname, string lastname, string dep) : base(firstname, lastname) {
			department = dep;
		}
		public abstract double totalHr();
		public abstract double HrPerWeek();
		public abstract double totalWage();
	}
}
