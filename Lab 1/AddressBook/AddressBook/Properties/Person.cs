using System;
namespace AddressBook
{
	public class Person
	{

		private int iD = 0;
		private static int last;

		public Person()
		{
			this.FirstName = "No firstname";
			this.LastName = "No lastname";
			last++;
			this.iD = last;
		}
		public Person(string firstname, string lastname)
		{
			this.FirstName = firstname;
			this.LastName = lastname;
			last++;
			this.iD = last;
		}

		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public int getID()
		{
			return iD;
		}


		public void printFirstName()
		{
			System.Console.WriteLine(FirstName);
		}

		public void printLastName()
		{
			System.Console.WriteLine(LastName);
		}
		public void printID()
		{
			System.Console.WriteLine(iD);
		}
		public string fullName
		{
			get
			{
				return FirstName + " " + LastName;
			}
		}

		public override string ToString()
		{
			return "Person: " + FirstName + " " + LastName + ", " + this.iD;
		}

	}
}

