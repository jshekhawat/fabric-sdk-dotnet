using System;
using Fabric.Sdk;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.DependencyInjection;


namespace Fabric.Test
{
    class Program
    {
        static void Main(string[] args)
        {               
            HFClient client = HFClient.CreateNewInstance();            
            Console.ReadLine();
        }

    }
}
