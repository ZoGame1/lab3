using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Progam
{

	static void create()
	{
		Console.OutputEncoding = Encoding.UTF8;
		string dataDirectory = @"Z:\Desktop\lab\Bai3Lab3";
		Directory.CreateDirectory(dataDirectory);
		string dataFilePath = Path.Combine(dataDirectory, "data.txt");

		using (StreamWriter writer = new StreamWriter(dataFilePath))
		{
			writer.WriteLine("Mssv: PD11057");
			writer.WriteLine("Họ và tên: PHAN VAN QUOC");
			writer.WriteLine("Gmail: phanvanquoc1226@gmail.com");
	
	}
		Console.WriteLine("Đã ghi xong: " + dataFilePath);
	}
	static void copy()
	{
		string sourceDirectory = @"..\\..\\..\data\\";
		string targetDirectory = @"..\\..\\..\data2\\";

		if (Directory.Exists(sourceDirectory))
		{
			Directory.CreateDirectory(targetDirectory);
			string[] files = Directory.GetFiles(sourceDirectory);
			foreach (string file in files)
			{
				string fileName = Path.GetFileName(file);
				string targetFile = Path.Combine(targetDirectory, fileName);
				File.Copy(file, targetFile, true);
			}
			Console.WriteLine("Sao chép hoàn tất");
		}
		else
		{
			Console.WriteLine("Thư mục nguồn không tồn tại");
		}
	}
	static void Main()
	{
		create();
		copy();
	}

}


