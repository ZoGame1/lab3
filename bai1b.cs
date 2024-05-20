﻿using System;
using System.IO;

class Program
{
	static void readFile()
	{
		string filePath = "example.txt";

		// Mở file để đọc với FileStream và StreamReader
		using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
		using (StreamReader reader = new StreamReader(fileStream))
		{
			// Đọc và hiển thị nội dung từ file
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				Console.WriteLine(line);
			}
		}
	}
	static void writeFile()
	{
		string filePath = "output.txt";

		// Mở file để ghi với FileStream và StreamWriter
		using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
		using (StreamWriter writer = new StreamWriter(fileStream))
		{
			// Ghi dữ liệu vào file
			writer.WriteLine("Phan Van Quoc");
			writer.WriteLine("Pd11057");

			Console.WriteLine("Dữ liệu đã được ghi vào file.");
		}
	}
	static void Main()
	{
		readFile();
		writeFile();
		Console.ReadLine();
	}
}