﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Example
{
    public class Utility
    {

        public static void write_error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " ERROR]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " ERROR]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
        public static void write_fatal(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " FATAL ERROR]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " FATAL ERROR]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
        public static void write_warning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " WARNING]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " WARNING]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
        public static void write_info(string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " INFO]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " INFO]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
        public static void write_debug(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " DEBUG]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " DEBUG]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
        public static void write_verbose(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " VERBOSE]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " VERBOSE]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
        public static void write_critical(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Console.WriteLine("[" + time + " CRITICAL]: " + msg);
            StreamWriter sw = new StreamWriter(file, append: true);
            sw.Write("[" + time + " CRITICAL]: " + msg + "\n");
            sw.Close();
            Console.ResetColor();
        }
    }
}
