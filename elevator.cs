using System.Diagnostics;
using System.IO;

namespace elevator
{
    internal static class Start
    {
        private static void Main(string[] args)
        {
            var ep = new Process();
            const string exec = "autorun-old.exe";
            if (File.Exists(exec))
            {
                ep.StartInfo.FileName = exec;
                ep.StartInfo.Arguments = "";
                ep.StartInfo.CreateNoWindow = true;
                ep.StartInfo.UseShellExecute = false;
                ep.Start();
            }
            else
            {
                System.Console.WriteLine(exec + " was not found"); //error message
                System.Threading.Thread.Sleep(1500); //Pause before closing
            }
        }
    }
}