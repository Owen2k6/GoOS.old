﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.Core;
using Cosmos.System.Graphics;
using Cosmos.Debug.Kernel;
using Cosmos.HAL.Drivers.PCI.Video;

namespace GoOS
{


    public class Kernel : Sys.Kernel
    {
        public static VGAScreen VScreen = new VGAScreen();
        protected override void BeforeRun()
        {
            
            Console.Clear();
            Cosmos.HAL.Global.TextScreen.SetColors(ConsoleColor.Black, ConsoleColor.White);
            Console.WriteLine("   Goplex Studios");
            Console.WriteLine("   Development Release 3");
            Console.WriteLine("   ");
            Console.WriteLine("   Type HELP for a list of commands");
            Console.WriteLine("   Type SUPPORT for support links...");
            Console.WriteLine(" ");
            Console.Write("> ");
        }

        protected override void Run()
        {
            String prefix = "> ";
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
                Console.WriteLine("- run* - run an application              -");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("if a command has a * after it, it means you need to use " +
                    "arguments to control it");
                Console.WriteLine(" ");
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
                Console.WriteLine("Goplex Studios GoOS 1.0");
                Console.WriteLine("Build type: Development");
                Console.WriteLine("Build number: 135");
                Console.WriteLine("Build Support key: 0x9282635467");
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
                Console.WriteLine("Yo there user! welcome to GoOS DevR 2");
                Console.WriteLine("Whats new? well heres a list:");
                Console.WriteLine("- Added Whats New command");
                Console.WriteLine("- Removed the UItest command");
                Console.WriteLine("- added OS build number to system info");
                Console.WriteLine("- added GoCalc as an application");
                Console.WriteLine("- added the run command for applications");
            }
            else if (input.ToLower() == "gocalc")
            {
                int firstNum;
                int secondNum;                   //Variables for equation
                string operation;
                int answer;

                Console.WriteLine("GoCalc 1.0");
                Console.WriteLine("Note: can only do simple math");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();

                Console.Write("Enter the first number in your basic equation: ");
                firstNum = Convert.ToInt32(Console.ReadLine());

                //User input for equation

                Console.Write("Ok now enter your operation ( x , / , +, -) ");
                operation = Console.ReadLine();

                Console.Write("Now enter your second number in the basic equation: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                if (operation == "x")
                {
                    answer = firstNum * secondNum;
                    Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else if (operation == "/")
                {
                    answer = firstNum / secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                //Getting answers
                else if (operation == "+")
                {
                    answer = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else if (operation == "-")
                {
                    answer = firstNum - secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "Test")
            {
                Console.WriteLine("Test");
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