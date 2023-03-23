using System;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace CLogSharp;
public class IntermittentLogger
{
    public static List<string[]> logList = new List<string[]>();

    public static void LogListInstance()
    {
        logList = new List<string[]>();
    }

    public static void MakeLogFile(string path, string fileName)
    {
        WriteFile(path, fileName);
    }

    public static void MakeLogFile(string fileName)
    {
        string path = Directory.GetCurrentDirectory();
        WriteFile(path, fileName);
    }

    private static void WriteFile(string path, string fileName)
    {
        string filePath = path + @"/" + fileName + ".csv"; 
        using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
        {
            foreach(string[] datas in logList)
            {
                sw.WriteLine(String.Format("{0},{1},{2},{3}", datas[0], datas[1], datas[2], datas[3]));
            }
        }
    }

    public static void WriteLogInfo(string text,  [CallerMemberName] string callerMethodName = "")
    {
        DateTime dt = DateTime.Now;
        logList.Add(new string[]{ dt.ToString("yyyy/MM/dd HH:mm:ss"), "Info", callerMethodName, text });
    }

    public static void WriteLogError(string text,  [CallerMemberName] string callerMethodName = "")
    {
        DateTime dt = DateTime.Now;
        logList.Add(new string[]{ dt.ToString("yyyy/MM/dd HH:mm:ss"), "Error", callerMethodName, text });
    }
}