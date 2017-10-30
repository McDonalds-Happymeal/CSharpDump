using System;
using System.IO;

public class log {
    public static void Main(string[] args) {
        File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "log.txt") , "\n" + DateTime.Now + ": " + args[0]);
    }
}