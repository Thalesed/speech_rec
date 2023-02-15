using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

class Teste{
    static void Main(string[] args){
        ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = "python3", Arguments = "sr.py", }; 
        Process proc = new Process() { StartInfo = startInfo, };
        proc.Start();

        Thread.Sleep(1600);

        string text = File.ReadAllText("speech");
        Console.WriteLine(text);
    }
}