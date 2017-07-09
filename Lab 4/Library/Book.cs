using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Library {
	public class Book : ISerializable {
		public int ID;
		static int last;
		public Book(string title, List<string> author) {
			Title = title;
			Authors = author;
			last++;
			ID = last;
		}
		public Book(SerializationInfo info, StreamingContext context) {
			Title = (string)info.GetValue("Title", typeof(string));
			Publisher = (string)info.GetValue("Publisher", typeof(string));
			Authors = (List<string>)info.GetValue("Authors", typeof(List<string>));
			Headings = (List<string>)info.GetValue("Headings", typeof(List<string>));
			YearPublication = (int)info.GetValue("YearPublication", typeof(int));
			Circulating = (bool)info.GetValue("Circulating", typeof(bool));
			ID = (int)info.GetValue("iD", typeof(int));
			BorrowerID = (int)info.GetValue("BorrowerID", typeof(int));
		}
		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			info.AddValue("Title", Title);
			info.AddValue("Authors", Authors);
			info.AddValue("iD", ID);
			info.AddValue("Headings", Headings);
			info.AddValue("Publisher", Publisher);
			info.AddValue("YearPublication", YearPublication);
			info.AddValue("Circulating", Circulating);
			info.AddValue("BorrowerID", BorrowerID);
		}
		public int BorrowerID { get; set; }
		public string Title { get; set; }
		public string Publisher { get; set; }
		public List<string> Authors { get; set; }
		public List<string> Headings { get; set; }
		public int YearPublication { get; set; }
		public bool Circulating { get; set; }
		string getAuthors() {
			string res = "";
			for (int i = 0; i < Authors.Count; i++) {
				if (i == Authors.Count - 1) {
					res += Authors[i];
					break;
				}
				res += Authors[i] + ", ";
			}
			return res;
		}
		public override string ToString() {
			return string.Format("Book: Title: {0}, Authors: {1}, Year of Publication: {2}, Book ID: ",
			                     Title, getAuthors(), YearPublication, BorrowerID);
		}
	}
}