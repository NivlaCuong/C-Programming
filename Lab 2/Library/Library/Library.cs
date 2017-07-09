using System.Collections.Generic;
namespace Library {
	public class Library { 
		List<Book> list;
		public Library() {
			list = new List<Book>();
		}
		public void addBook(Book aBook) {
			if (!list.Contains(aBook)) 
				list.Add(aBook);
		}
		public void SearchBySubject(string str) {
			List<Book> result = new List<Book>();
			for (int i = 0; i < list.Count; i++) {
				for (int j = 0; j < list[i].Headings.Length; j++) {
					if (str.Equals(list[i].Headings[j]))
						result.Add(list[i]);
				}
			}
			for (int i = 0; i < result.Count; i++) {
				System.Console.WriteLine("{0}", result[i]);
				System.Console.WriteLine();
			}
		}
	}
}
