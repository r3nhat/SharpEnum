using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEnum
{
    class Runner
    {

        public string ProcessRunner()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine("dir");
               process.StandardInput.WriteLine("echo hello");
                //process.StandardInput.WriteLine("yourCommand.exe arg1 arg2");

                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
                Console.WriteLine(outputString);
                return outputString;
            }

            return string.Empty;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Runner runner = new Runner();
            runner.ProcessRunner();
           
            
    }
    }
}
