using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailAlerts
{
    class Program
    {
        // Create a logger for use in this class
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            if (log.IsInfoEnabled) log.Info("The ConnectionString is test");
            
        }
    }
}
