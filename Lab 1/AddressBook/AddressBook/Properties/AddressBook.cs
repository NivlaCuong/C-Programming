using System.Collections.Generic;
namespace AddressBook
{
	public class AddressBook
	{
		List<Person> array = new List<Person>();

		public List<Person> getList()
		{
			return array;
		}

		public void add(Person p)
		{
			if (!array.Contains(p))
			{
				array.Add(p);
			}
		}
		public void delete(Person p)
		{
			array.Remove(p);
		}

		public List<Person> Search(Person p)
		{
			List<Person> newLst = new List<Person>();
			foreach (Person a in array)
			{
				if (p.Equals(a))
				{
					newLst.Add(p);
				}
			}
			return newLst;
		}
		public List<Person> Search(string name)
		{
			List<Person> newLst = new List<Person>();
			foreach (Person a in array)
			{
				if (a.FirstName.Equals(name) || a.LastName.Equals(name))
				{
					newLst.Add(a);
				}
			}
			return newLst;
		}
		public List<Person> Search(int id)
		{
			List<Person> newLst = new List<Person>();
			foreach (Person a in array)
			{
				if (a.getID().Equals(id))
				{
					newLst.Add(a);
				}
			}
			return newLst;
		}
	}
}

