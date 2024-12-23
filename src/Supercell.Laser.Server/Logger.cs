﻿namespace Supercell.Laser.Server
{
    using Supercell.Laser.Titan.Debug;
    using System;

    public static class Logger
    {

        public static void cmd(string log)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                                [INIT] " + log);
        }
        public static void Print(string log)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                [DEBUG] " + log);
        }

        public static void Init()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Debugger.SetListener(new DebuggerListener());
        }

        public static void Warning(string log)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[WARNING] " + log);
        }

        public static void Error(string log)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] " + log);
        }
    }

    public class DebuggerListener : IDebuggerListener
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                [LOGIC] Error: " + message);
        }

        public void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                [LOGIC] Info: " + message);
        }

        public void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                [LOGIC] Warning: " + message);
        }
    }
}
