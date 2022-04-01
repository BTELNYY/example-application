using System;
using Discord.Net;
using Newtonsoft.Json;
namespace Simple_Server_Bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(Globals.log_path))
            {
                Directory.CreateDirectory(Globals.log_path);
            }
            Console.WriteLine("Hello World!");
            Utility.write_info("This is a test");
        }
    }
}
