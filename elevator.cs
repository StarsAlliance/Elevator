using System.Diagnostics;
using System.IO;
using Ini;
namespace elevator
{
    internal static class Start
    {
        private static void Main(string[] args)
        {
            var ep = new Process();
            string exec = "autorun-old.exe";
            string IniFile = "elevator.ini";
            string fargs = "";
            string wnferror = exec + " was not found";
            if (File.Exists(IniFile))
            {
                var MyIni = new IniFile(IniFile);
                exec = MyIni.Read("openfile", "elevator");
                fargs = MyIni.Read("params", "elevator");
                wnferror = MyIni.Read("notfound","elevator");
                // var wdir = MyIni.Read("workdir","elevator");
            }
            if (File.Exists(exec))
            {
                ep.StartInfo.FileName = exec;
                ep.StartInfo.Arguments = fargs;
                ep.StartInfo.CreateNoWindow = true;
                ep.StartInfo.UseShellExecute = false;
                ep.Start();
            }
            else
            {
                System.Console.WriteLine(wnferror); //error message
                System.Threading.Thread.Sleep(1500); //Pause before closing
            }
        }
    }
}