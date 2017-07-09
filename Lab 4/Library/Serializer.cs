using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Library {
	public class Serializer {
		public void CreateNewFile(string filename)
		{
			Stream stream = File.Create(filename);
			stream.Close();
		}
		public void SerializeObject(string filename, Library library)
		{
			Stream stream = File.Open(filename, FileMode.OpenOrCreate);
			BinaryFormatter bFormatter = new BinaryFormatter();
			bFormatter.Serialize(stream, library);
			stream.Close();
		}

	}
}
