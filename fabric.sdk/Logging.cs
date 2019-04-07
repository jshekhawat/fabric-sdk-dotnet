using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;

namespace Fabric.Sdk {

    public class HFLogger {

        internal static ILoggerFactory LoggerFactory {
            get;
            set;
        }

        static HFLogger() {
            LoggerFactory = new LoggerFactory();
            LoggerFactory.AddConsole();
            LoggerFactory.AddDebug();
        
        }

        internal static ILogger CreateLogger<T>() {
            return LoggerFactory.CreateLogger<T>();
        }


    } 


}