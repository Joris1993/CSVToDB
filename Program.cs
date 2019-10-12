using System;

class program
{
    static void Main(string[] args)
    {
        CSVParser test = new CSVParser();
        CSVParser parser = new CSVParser();
        parser.OpenFile("CSV/input/test.csv");
        parser.OutputContentToConsole();
        parser.CloseFile();
    }
}
