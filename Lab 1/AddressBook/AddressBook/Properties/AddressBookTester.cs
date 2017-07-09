using System;
using System.Collections.Generic;
namespace AddressBook
{
	public class AddressBookTester
	{
		public static void Main(string[] args)
		{
			AddressBook newAddressBook = new AddressBook();
			Person a = new Person("Cuong", "Nguyen");
			Person b = new Person("Tran", "Nguyen");
			Person c = new Person("Linh", "Nguyen");
			Person d = new Person("Daniel", "Nguyen");
			Console.WriteLine(newAddressBook.getList().Count);
			newAddressBook.add(a);
			newAddressBook.add(b);
			newAddressBook.add(c);
			newAddressBook.add(d);
			Console.WriteLine(newAddressBook.getList().Count); //4
			newAddressBook.delete(a);
			Console.WriteLine(newAddressBook.getList().Count); //3
			Console.WriteLine(newAddressBook.Search("Cuong").Count); //0
			List<Person> list = newAddressBook.Search("Nguyen");
			Person[] array = list.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array.GetValue(i));
			}
		}
	}
}

