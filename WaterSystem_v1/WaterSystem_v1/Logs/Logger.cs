using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace WaterSystem_v1.Logs
{
    public static class Logger
    {
       
        static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Error(object message)
        {
            log.Error(message);
        }

        public static void Error(object message, Exception exception)
        {
            log.Error(message, exception);
        }

        public static void Debug(object message)
        {
            log.Debug(message);
        }

        public static void Debug(Object message, Exception exception)
        {
            log.Debug(message, exception);
        }

        public static void Warn(Object message)
        {
            log.Warn(message);
        }

        public static void Warn(Object message, Exception exception)
        {
            log.Warn(message, exception);
        }

        public static void Info(Object message)
        {
            log.Info(message);
        }

        public static void Info(Object message, Exception exception)
        {
            log.Info(message, exception);
        }
    }
}
