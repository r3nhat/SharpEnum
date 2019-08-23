using SharpEnum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpEnum
{
    class Logo
    {
        public static void Banner()
        {
            Console.WriteLine(@"   _____ _                      ______                       ");
            Console.WriteLine(@"  / ____| |                    |  ____|                      ");
            Console.WriteLine(@" | (___ | |__   __ _ _ __ _ __ | |__   _ __  _   _ _ __ ___  ");
            Console.WriteLine(@"  \___ \| '_ \ / _` | '__| '_ \|  __| | '_ \| | | | '_ ` _ \ ");
            Console.WriteLine(@"  ____) | | | | (_| | |  | |_) | |____| | | | |_| | | | | | |");
            Console.WriteLine(@" |_____/|_| |_|\__,_|_|  | .__/|______|_| |_|\__,_|_| |_| |_|");
            Console.WriteLine(@"                         | |                                 ");
            Console.WriteLine(@"                         |_|                                 ");
            Console.WriteLine("                               v0.0.1                         ");
            Console.WriteLine("                                @r3n_hat                      ");
            Console.WriteLine("                                                              ");
            Console.WriteLine("                                                              ");
        }
    }

   class Enum
    {

        public static void runCmd(string command)
        {

            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = false;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Arguments = "/c " + command;
            proc.RedirectStandardOutput = true;
            proc.RedirectStandardError = true;
            proc.CreateNoWindow = true;

            var results = Process.Start(proc);
            string output = results.StandardOutput.ReadToEnd();
            Console.WriteLine(output);

        }

    }

}



    class Program
    {
        static void Main(string[] args)
        {
        Logo.Banner();

        List<String> commands = new List<String>();
        commands.Add("nslookup www.google.com");
        commands.Add("ipconfig /all");
        commands.Add("whoami /priv");
        commands.Add("netstat -ano");
        commands.Add("route PRINT");
        commands.Add("net users");
        commands.Add("net localgroup administrators");
        commands.Add("dir c:\\");
        commands.Add("arp -a");
        commands.Add("hostname");
        commands.Add("echo %logonserver%");
        commands.Add("schtasks /query /fo LIST 2>nul | findstr TaskName");
        commands.Add("quser");
       /*
       commands.Add("");
       commands.Add("");
       commands.Add("");
       commands.Add("");
       */

        foreach (string cmd in commands)
        {


            Thread thread = new Thread(() => 
            {
                SharpEnum.Enum.runCmd(cmd);
            });

            thread.Start();
        }    
        
    }
    }

