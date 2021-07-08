using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp
{
    public class LogHelper
    {
        public static log4net.ILog GetLogger([CallerFilePath] string fileName = "")
        {
            log4net.Config.XmlConfigurator.Configure();
            return log4net.LogManager.GetLogger(fileName);
        }
    }
}
