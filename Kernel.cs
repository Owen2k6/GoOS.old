using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.Core;
using Cosmos.System.Graphics;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Cosmos.Debug.Kernel;
using Cosmos.HAL.Drivers.PCI.Video;
using Cosmos.System.Network;
using System.IO;


namespace GoOS
{
    public class Kernel : Sys.Kernel
    {
        public static VGAScreen VScreen = new VGAScreen();
        CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        protected override void BeforeRun()
        {

            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.Clear();
            Cosmos.HAL.Global.TextScreen.SetColors(ConsoleColor.Black, ConsoleColor.White);
            Console.WriteLine("   Goplex Studios - GoOS");
            Console.WriteLine("   Version 1.0.2");
            Console.WriteLine("   ");
            Console.WriteLine("   Type HELP for a list of commands");
            Console.WriteLine("   Type SUPPORT for support links...");
            Console.WriteLine(" ");
            var drive = new DriveInfo("0");
            Console.WriteLine("Volume in drive 0 is " + $"{drive.VolumeLabel}");
            Console.WriteLine("Directory of " + @"0:\");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("        " + $"{drive.TotalSize}" + " bytes");
            Console.WriteLine("        " + $"{drive.AvailableFreeSpace}" + " bytes free");
            Console.Write(@"0:\ ");
            try
            {
                Sys.FileSystem.VFS.VFSManager.CreateFile(@"0:\BootSuccess.txt");
                Sys.FileSystem.VFS.VFSManager.DeleteFile(@"0:\BootSuccess.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        protected override void Run()
        {
            String prefix = @"0:\ ";
            String input = Console.ReadLine();



            if (input.ToLower() == "help")
            {
                //
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("----------------GoOS Help-----------------");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("- here is the list of commands:          -");
                Console.WriteLine("- Help - Shows this page                 -");
                Console.WriteLine("- credits - shows the developers         -");
                Console.WriteLine("- clear - clears the text                -");
                Console.WriteLine("- sysinf - Shows system info             -");
                Console.WriteLine("- shutdown - Shuts down GoOS             -");
                Console.WriteLine("- whatsnew - shows all new features      -");
                Console.WriteLine("- gocalc - GoOS calculator               -");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(" ");
                //
            }
            else if (input.ToLower() == "credits")
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("-------------credits--------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("---------Created by Owen----------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("---------Helped by Zulo-----------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("-----Others that have helped!-----");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("---------British Geek Guy---------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Thank you for trying out GoOS!");
                Console.WriteLine(" ");
                Console.WriteLine("Returned to Command centre");
                Console.WriteLine(" ");
            }
            else if (input.ToLower() == "clear")
            {
                Console.Clear();
            }
            else if (input.ToLower() == "sysinf")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Goplex Studios GoOS 1.0.2");
                Console.WriteLine("Build type: Release");
                Console.WriteLine("Build number: 1012");
                Console.WriteLine("Build Support key: 0x6574837632");
                Console.WriteLine(" ");
            }
            else if (input.ToLower() == "shutdown")
            {
                Console.WriteLine("System shutting down...");
                Console.WriteLine("Goodbye!");
                Stop();
            }
            else if (input.ToLower() == "support")
            {
                Console.WriteLine("Discord: https://dsc.gg/goplex");
                Console.WriteLine("type the link into the VM host webbrowser");
                Console.WriteLine("if your running the os as your active OS, please stick to using VMs until we have a stable mainframe.");
            }
            else if (input.ToLower() == "whatsnew")
            {
                Console.WriteLine("Yo there user! welcome to GoOS 1.0");
                Console.WriteLine("Whats new? well heres a list:");
                Console.WriteLine("- First public release. its all new!");
            }
            else if (input.ToLower() == "gocalc")
            {
                Console.Write("Disabled.");
                
            }
            else if (input.ToLower() == "dir")
            {
                string[] filePaths = Directory.GetFiles(@"0:\");
                for (int i = 0; i < filePaths.Length; ++i)
                {
                    string path = filePaths[i];
                    Console.WriteLine(System.IO.Path.GetFileName(path));
                }
                foreach (var d in System.IO.Directory.GetDirectories(@"0:\"))
                {
                    var dir = new DirectoryInfo(d);
                    var dirName = dir.Name;

                    Console.WriteLine(dirName + " <DIR>");
                }

            }
            else
            {
                Console.WriteLine("sorry, but `" + input + "` is not a command");
                Console.WriteLine("type HELP for a list of commands");
            }
                Console.Write(prefix);
            }
        }
    } 