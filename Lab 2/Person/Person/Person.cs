using System;
namespace Person {
	public class Person {
		int iD;
		static int last;
		public Person() : this("no firstname", "no Lastname") { }
		public Person(string firstname, string lastname) {
			FirstName = firstname;
			LastName = lastname;
			last++;
			iD = last;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int getID() { return iD; }
		public void printFirstName() { Console.WriteLine(FirstName); }
		public void printLastName() { Console.WriteLine(LastName); }
		public void printID() { Console.WriteLine(iD); }
		public string fullName { get { return FirstName + " " + LastName;} }
		public override string ToString() { return "Person: " + FirstName + ", " + LastName + ", " + iD; }
	}
}

