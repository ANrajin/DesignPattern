using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Singleton
{
    public sealed class Logger
    {
        private static Logger? _instance;

        /*
         * Private method will restrict to
         * instantiate this class from outside
         */
        private Logger()
        {
        }

        /*
         * Instantiate the logger and return
         */
        public static Logger GetLogger()
        {
            if(_instance == null)
                _instance = new Logger();
            return _instance;
        }


        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
