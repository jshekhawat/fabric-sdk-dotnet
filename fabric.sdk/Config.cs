using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Fabric.Sdk
{
    public class HFConfig {

        private static ILogger logger = HFLogger.CreateLogger<HFConfig>();
        private static HFConfig _config;        

        private HFConfig(IConfiguration config)
        {
            
        }

        //some defaults
        private HFConfig() {
                
        }

        public static HFConfig GetConfiguration(IConfiguration config = null) {
            if(_config != null) {
                return _config;
            }
            return new HFConfig(config);
        }
    }    
}