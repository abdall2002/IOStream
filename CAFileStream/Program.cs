// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

//Example01();
//Example02();
//Example03();
Example04();




static void Example01()
{
    //string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample.txt";
    string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample.txt";
    using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
    {
        Console.WriteLine($"Length: {fs.Length} Byte(s)");
        Console.WriteLine($"CanRead: {fs.CanRead}");
        Console.WriteLine($"CanWrite: {fs.CanWrite}");
        Console.WriteLine($"CanSeek: {fs.CanSeek}");
        Console.WriteLine($"CanTimeout: {fs.CanTimeout}");
        Console.WriteLine($"Position: {fs.Position}");     // print Position: 0
        fs.WriteByte(65); // A
        Console.WriteLine($"Position: {fs.Position}");     // print Position: 1
        fs.WriteByte(66); // B
        Console.WriteLine($"Position: {fs.Position}");     // print Position: 2
        fs.WriteByte(13); // Enter

        for (byte i = 65; i < 123; i++)
        {
            fs.WriteByte(i);
        }
    }

}
static void Example02()
{
    string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample.txt";
    using (var fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
    {
        byte[] data = new byte[fs.Length];
        int numBytesToRead = (int)fs.Length;
        int numBytesRead = 0;
        while (numBytesToRead > 0)
        {
            int n = fs.Read(data, numBytesRead, numBytesToRead);

            if (n == 0)
                break;

            numBytesToRead -= n;
            numBytesRead += n;
        }
        foreach (var b in data)
        {
            Console.WriteLine(b);

        }

        var newPath = "C:\\Users\\COMPUMARTS\\Desktop\\Sample1.txt";
        using (var fsw = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            fsw.Write(data, 0, data.Length);
        }

    }
}

static void Example03()
{
    string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample2.txt";
    using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
    {
        fs.Seek(20, SeekOrigin.Begin);
        fs.WriteByte(65);
        fs.Position = 0;
        for (int i = 0; i < fs.Length; i++)
        {
            Console.WriteLine(fs.ReadByte());
        }
    }
}

static void Example04()
{
    string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample3.txt";
    using(var sw = new StreamWriter(path))
    {
        sw.WriteLine("This");
        sw.WriteLine("is");
        sw.WriteLine("C#");

    }
}











