using System;
using System.Collections;
namespace Person
{
	public class Person
	{
		
		int iD = 0;
		static int last;

		public Person()
		{
			FirstName = "No firstname";
			LastName = "No lastname";
			last++;
			iD = last;
		}
		public Person(string firstname, string lastname)
		{
			FirstName = firstname;
			LastName = lastname;
			last++;
			iD = last;
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
			Console.WriteLine(FirstName);
		}

		public void printLastName()
		{
			Console.WriteLine(LastName);
		}
		public void printID()
		{
			Console.WriteLine(iD);
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
			return "Person: " + FirstName + ", " + LastName + ", " + iD;
		}

	}
}

