using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


 class Program
{
	static void readf()
	{
		string filePath1 = "example.txt";
		string filePath2 = "data.txt";

		using (FileStream fileStream1 = new FileStream(filePath1, FileMode.Open, FileAccess.Read))
		using (StreamReader reader = new StreamReader(fileStream1))

		using (FileStream fileStream2 = new FileStream(filePath2, FileMode.Create, FileAccess.Write))
		using (StreamWriter writer = new StreamWriter(fileStream2))
		{
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				
				writer.WriteLine("phan van quoc");
				writer.WriteLine("password: 0902004");
				writer.WriteLine("Gmail:phanvanquoc1226@gmail.com");
			}
			Console.WriteLine("Du lieu duoc sao chep tuw flie input sang file output");
		}

	}
	static void Main()
	{
		readf();
		Console.ReadLine();
	}

}

