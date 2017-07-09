using System;
using System.Collections.Generic;
using System.Linq;

namespace Library {
	public class Library {
		public List<Book> listBook { get; set; }
		public List<Member> listMember { get; set; }
		public Library() {
			listBook = new List<Book>();
			listMember = new List<Member>();
		}
		public void addBook(Book aBook) {
			if (!listBook.Contains(aBook))
				listBook.Add(aBook);
		}
		public void addMember(Member member) {
			if (!listMember.Contains(member))
				listMember.Add(member);
		}
		public void checkInBook(Book a, Member member) {
			if (listMember.Contains(member) && listBook.Contains(a) && a.Circulating == true) {
				a.BorrowerID = member.getID();
				a.Circulating = false;
			}
			else {
				throw new Exception("You cannot check in the book when you haven't reserved the book before!");
			}
		}

		public void checkOutBook(Book a, Member member) {
			if (listMember.Contains(member) && listBook.Contains(a) && a.Circulating == false) {
				a.BorrowerID = member.getID();
				a.Circulating = true;
				member.listBookBorrowed.Add(a);
			}
			else {
				throw new Exception("You cannot check out the book when the book is reserved!");
			}
		}

		public void SearchBySubject(string str) {
			List<Book> result = new List<Book>();
			for (int i = 0; i < listBook.Count; i++) {
				for (int j = 0; j < listBook[i].Headings.Count; j++) {
					if (str.Equals(listBook[i].Headings[j]) || str.Equals(listBook[i].Title.ToList())) 
						result.Add(listBook[i]);
				}
			}
			for (int i = 0; i < result.Count; i++) {
				Console.WriteLine(result[i] + "\n");
			}
		}
		public void SearchBooksBorrowed(int ID) {
			for (int i = 0; i < listMember.Count; i++) {
				if (listMember[i].getID() == ID) {
					Console.WriteLine(listMember[i]);
					foreach (Book a in listMember[i].listBookBorrowed) 
						Console.WriteLine(a + "\n");
				}
			}
		}

		public void searchBySubjectLinQ(string str) {
			var result = from book in listBook 
						 where book.Headings.Contains(str) || book.Title.Split(' ').Contains(str)
						 select book;
			foreach (var book in result) {
				Console.WriteLine(book);
			}
		}

		public void searchBooksBorrowedLinQ(int id) {
			var member = from info in listMember where info.getID() == id select info;
			var resultBooks = from bookBorrowed in member select bookBorrowed.listBookBorrowed;
			Console.WriteLine(member);
			foreach (var name in resultBooks) {
				Console.WriteLine(name);
			}
		}

		public void lstBookBorrowedByAllMembers() {
			var bookIsOnReserved = from book in listBook
								   where book.Circulating
								   orderby book.BorrowerID
								   select book;
			var BookBorrowedByAllMem = from book in listBook
									   group book by book.BorrowerID into ListOfBooks
									   select new {
										   ID = ListOfBooks.Key,
										   ListOfBooks
									   };
			Console.WriteLine("List of book that all members borrowed since the beginning of semester: \n");
			foreach (var a in BookBorrowedByAllMem) {
				Console.WriteLine("Member ID: {0}\n", a.ID);
				foreach (Book res in a.ListOfBooks) {
					Console.WriteLine(res + "\n");
				}
			}
			Console.WriteLine("List of books that are currently reserved by members: \n");
			foreach (var a in bookIsOnReserved) {
				Console.WriteLine("Member ID: {0}" + Environment.NewLine +
				                  "{1} \n", a.BorrowerID, a);
			}
		}
	}
}