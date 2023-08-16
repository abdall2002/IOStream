﻿// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

Example01();


static void Example01()
{
    //string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample.txt";
    string path = "C:\\Users\\COMPUMARTS\\Desktop\\Sample.txt";
    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
    {
        Console.WriteLine($"Length: {fs.Length} Byte(s)");
        Console.WriteLine($"CanRead: {fs.CanRead}");
        Console.WriteLine($"CanWrite: {fs.CanWrite}");
        Console.WriteLine($"CanSeek: {fs.CanSeek}");
        Console.WriteLine($"CanTimeout: {fs.CanTimeout}");
        Console.WriteLine($"Position: {fs.Position}");
        //fs.WriteByte(65); // A
        //Console.WriteLine($"Position: {fs.Position}");
        //fs.WriteByte(66); // B
        //fs.WriteByte(13); // Enter

        //for (byte i = 65; i < 123; i++)
        //{
        //    fs.WriteByte(i);
        //}
    }

}











