using System;
using Newtonsoft.Json;
namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check if the logs directory exists
            if (!Directory.Exists(Globals.log_path))
            {
                Directory.CreateDirectory(Globals.log_path);
            }
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string time = DateTime.Now.ToString("hh\\:mm\\:ss");
            string file = Globals.log_path + date + ".log";
            Utility.write_verbose("Verbose message");
            Utility.write_debug("Debug message");
            Utility.write_info("Info message");
            Utility.write_warning("Warning message");
            Utility.write_error("Error message");
            Utility.write_fatal("Fatal message");
            Utility.write_critical("Critical message");
            Utility.write_info("All messages are saved here: " + file);
        }
    }
}
