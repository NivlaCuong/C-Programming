using System;
namespace Library {
	public class Book {
		public Book(string title, string[] author) {
			Title = title;
			Authors = author;
		}
		public string Title { get; set; }
		public string Publisher { get; set; }
		public string[] Authors { get; set; }
		public string[] Headings { get; set; }
		public int YearPublication { get; set; }
		public int CataNum { get; set; }
		public bool Circulating { get; set; }
		string getAuthors() {
			string res = "";
			for (int i = 0; i < Authors.Length; i++) {
				if (i == Authors.Length - 1) {
					res += Authors[i];
					break;
				}
				res += Authors[i] + ", ";
				}
			return res;
		}
		public override string ToString() {
			return string.Format("[Book: Title = {0}, Authors = [{1}], Catalog Number = {2}]",
			                     Title, getAuthors(), CataNum);
		}
	}
}
