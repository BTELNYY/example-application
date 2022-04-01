using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Server_Bot
{
    public static class Globals
    {
        public static string version = "1.0.0";
        public static string bot_token { get; private set; }
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
        public static void change_token(string token)
        {
            bot_token = token;
        }
    }
}
