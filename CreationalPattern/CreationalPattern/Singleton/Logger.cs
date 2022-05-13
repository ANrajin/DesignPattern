using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Singleton
{
    //sealed ensures that the class connot be inherited
    public sealed class Logger
    {
        private static int count;
        private static Logger? _instance;

        /*
         * Private method will restrict to
         * instantiate this class from outside
         */
        private Logger()
        {
            count++;
            Console.WriteLine($"Intantiated {count} times");
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
