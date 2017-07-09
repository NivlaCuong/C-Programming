using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Library {
	public class Member : ISerializable {
		int iD;
		static int last;
		public Member(string firstname, string lastname, string email) {
			FirstName = firstname;
			LastName = lastname;
			last++;
			iD = last;
			Email = email;
		}

		public Member(SerializationInfo info, StreamingContext ctxt)
		{
			FirstName = (string)info.GetValue("Firstname", typeof(string));
			LastName = (string)info.GetValue("Lastname", typeof(string));
			Email = (string)info.GetValue("Email", typeof(string));
			iD = (int)info.GetValue("ID", typeof(int));
		}

		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("Firstname", FirstName);
			info.AddValue("Lastname", LastName);
			info.AddValue("ID", iD);
			info.AddValue("Email", Email);
		}
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<Book> listBookBorrowed { get; set; }
		public int getID() { return iD; }
		public string fullName { get { return FirstName + " " + LastName; } }
		public override string ToString() {
			return string.Format("Fullname: {0}" + Environment.NewLine +
								 "ID: {1}" + Environment.NewLine +
								 "Email: {2}", fullName, iD, Email);
		}
	}
}