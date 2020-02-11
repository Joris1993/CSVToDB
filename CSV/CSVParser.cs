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
    public List<List<String>> parseCSV()
    {
        List<List<String>> list = new List<List<String>>();
        string ln;
        while ((ln = reader.ReadLine()) != null)
        {
            list.Add(new List<string>(ln.Split(';')));
        }
        return list;
    }

}