using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debloat_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.SetCursorPosition(15, 7);
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("║ Name:        Debloat Files                            ║");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("║ Purpose:     Delete files that Mac OS X leavs behinde ║");
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(15, 12);
            Console.WriteLine("║ Auther:      JJakaJonas                               ║");
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("╠═══════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(15, 14);
            Console.WriteLine("║ Revision:    1.0.0.0                                  ║");
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");            

            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;


            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe")
                {
                    UseShellExecute = true,
                    RedirectStandardInput = false,
                    Arguments = "/c Debloat.bat"
                };
                Process proc = new Process() { StartInfo = psi };

                proc.Start();
                proc.WaitForExit();
                proc.Close();

            Console.ReadKey();
        }
    }
}
