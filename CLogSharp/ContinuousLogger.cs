using System;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace CLogSharp;
public class ContinuousLogger
{
    public static string directory = Environment.CurrentDirectory;
    public static string fileName = "log";

    public static void WriteLogInfo(string text, [CallerMemberName] string callerMethodName = "")
    {
        CheckFileExist();

        DateTime dt = DateTime.Now;
        Encoding enc = Encoding.GetEncoding("UTF-8");

        string path = directory + "/" + fileName + ".log";
        using (StreamWriter writer = new StreamWriter(path, true, enc))
        {
            writer.WriteLine(String.Format("{0},{1},{2},{3}", dt.ToString("yyyy/MM/dd HH:mm:ss"), "Info", callerMethodName, text));
        }            
    }
    
    public static void WriteLogError(string text, [CallerMemberName] string callerMethodName = "")
    {
        CheckFileExist();

        DateTime dt = DateTime.Now;
        Encoding enc = Encoding.GetEncoding("UTF-8");

        string path = directory + "/" + fileName + ".log";
        using (StreamWriter writer = new StreamWriter(path, true, enc))
        {
            writer.WriteLine(String.Format("{0},{1},{2},{3}", dt.ToString("yyyy/MM/dd HH:mm:ss"), "Error", callerMethodName, text));
        }            
    }

    private static void CheckFileExist()
    {
        string path = directory + "/" + fileName + ".log";
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
            using (FileStream fs = File.Create(path));
        }
        else
        {
            if(!System.IO.File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) ;
            }
        }
    }
}
