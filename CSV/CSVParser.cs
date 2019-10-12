using System;
using System.IO;
using System.Collections.Generic;

class CSVParser
{
    private StreamReader reader;
    public void OpenFile(string filename)
    {
        reader = new StreamReader(filename);
    }
    public void CloseFile()
    {
        reader.Close();
    }
    public void OutputContentToConsole()
    {
        string ln;

        while ((ln = reader.ReadLine()) != null)
        {
            Console.WriteLine(ln);
        }
    }
    public SortedList<int, Queue<String>> parseCSV()
    {
        string ln;
        while ((ln = reader.ReadLine()) != null)
        {
            ln.
        }
    }

}