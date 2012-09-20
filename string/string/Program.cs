/*
 * Created by SharpDevelop.
 * User: Liang
 * Date: 2012/7/12
 * Time: 20:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace StringCoding
{
	class Program
	{
		static void Main1(string[] args)
		{
			/*
			Person person = new Person();
			person.personName = "Jerry";
			person.personHeight = "175CM";
			person.PersonAge = 22;
			Stream stream = Serialize(person);
			
			//保存到文件
			MemoryStream ms = (MemoryStream)stream;			
			Stream fs = new FileStream(@"D:\dotnetserial\person.txt", FileMode.OpenOrCreate);
			BinaryWriter bw = new BinaryWriter(fs);
			bw.Write(ms.ToArray());
			bw.Flush();
			fs.Close();
			
			//从文件中读取
			Stream fs1 = new FileStream(@"D:\dotnetserial\person2.txt", FileMode.Open);
			

			Person person1 = Deserialize(fs1);
			person1.Write();
			*/

			
			Console.ReadKey();
		}
		
		private static void M(StringBuilder s)
		{
			s.Append(" world");
			Console.WriteLine(s);
		}
		
		private static MemoryStream Serialize(Person person)
		{
			MemoryStream stream = new MemoryStream();

			// 构造二进制序列化格式器
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			// 告诉序列化器将对象序列化到一个流中
			binaryFormatter.Serialize(stream, person);

			return stream;

		}

		private static Person Deserialize(Stream stream)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			return (Person)binaryFormatter.Deserialize(stream);
		}

	}

    class A
    {
        public static int X =3;
        static A()
        {
            X = B.Y + 1;
        }
    }

    class B
    {
        public static int Y = A.X + 1;
        static B()
        {
        }
        static void Main(string[] args)
        {
            Console.WriteLine("X={0}, Y={1}", A.X, B.Y);
        }
    }
	
	[Serializable]
	public class Person
	{
		public string personName;

		[NonSerialized]
		public string personHeight;

		private int personAge;
		public int PersonAge
		{
			get { return personAge; }
			set { personAge = value; }
		}

		public void Write()
		{
			Console.WriteLine("Person Name: "+personName);
			Console.WriteLine("Person Height: " +personHeight);
			Console.WriteLine("Person Age: "+ personAge);
		}
		
	}

}