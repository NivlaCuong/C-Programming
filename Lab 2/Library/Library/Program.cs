using System;

namespace Library {
	class MainClass {
		public static void Main(string[] args)
		{
			Library a = new Library();
			Book java = new Book("A Java Reference: Assorted Java Reference Material", new string[] { "Paul Hilfinger", "Adam Jones"});
			Book python = new Book("A Python Reference: Assorted Python Reference Material", new string[] { "Calvin Nguyen", "Thana" });
			Book swift = new Book("A swift Reference: Assorted Swift Reference Material", new string[] { "James Bond", "Power Rangers" });

			java.Headings = new string[] { "java", "Programming", "Paul", "Hilfinger", "cs61b", "IDE", "Object oriented" };
			java.CataNum = 199922249;
			python.Headings = new string[] { "python", "Programming", "Calvin", "Nguyen", "cs61A" };
			python.CataNum = 199922250;
			swift.Headings = new string[] { "swift", "Programming", "Santa", "Clause", "apple", "iOS" };
			swift.CataNum = 199922251;
			java.Circulating = true;
			python.Circulating = false;
			swift.Circulating = true;

			a.addBook(java);
			a.addBook(python);
			a.addBook(swift);

			Console.WriteLine("---------------Testing SearchBySubject() method-------");
			a.SearchBySubject("python");
			a.SearchBySubject("Programming");
		}
	}
}
