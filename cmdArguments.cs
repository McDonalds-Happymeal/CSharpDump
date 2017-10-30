using System;
using System.IO;

public class cmdArguments {
    public static void Main (string[] Args) {
        string[] file = File.ReadAllLines(Args[0]);

        file[0] = "<title>"+file[0]+"</title>";
        for (int i=1;i<file.Length;i++) {
            if (file[i]=="") {
                file[i]="<br />";
            }
            else {
                file[i] = "<p>"+file[i]+"</p>";
            }
        }
        string html = (System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Args[0]), System.IO.Path.GetFileNameWithoutExtension(Args[0]))) + ".html";

        File.WriteAllLines(html, file) ;


    }
}