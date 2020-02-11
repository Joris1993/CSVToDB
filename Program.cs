using System;
using System.Collections.Generic;

class program
{
    static void Main(string[] args)
    {
        CSVParser test = new CSVParser();
        CSVParser parser = new CSVParser();
        parser.OpenFile("CSV/input/test.csv");
        //parser.OutputContentToConsole();
        foreach(var line in parser.parseCSV()) 
        {
            foreach (var item in line)
            {
                Console.Write(item + " ");  
            }
            Console.WriteLine();
        }
        parser.CloseFile();
    }
}
