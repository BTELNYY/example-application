using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public static class Globals
    {
        public static string version = "1.0.0";
        public static string log_path
        {
            get
            {
                return "./Logs/";
            }
            set
            {
                log_path = value;
            }
        }
    }
}
