using Newtonsoft.Json;
using System.IO;

namespace LeagueInfo.Core.Serialization
{
	[JsonObject(MemberSerialization.OptIn)]
	public abstract class Serializer<T>
	{
		public Serializer(string fileName)
		{
			this.fileName = fileName;
		}

		public void Serialize(T item)
		{
			using (StreamWriter sw = new StreamWriter(fileName))
			using (JsonWriter writer = new JsonTextWriter(sw))
				serializer.Serialize(writer, item);
		}

		public T Deserialize()
		{
			using (var file = File.OpenText(fileName))
				return (T)serializer.Deserialize(file, typeof(T));
		}

		private readonly string fileName;
		private JsonSerializer serializer = new JsonSerializer();
	}
}
