using System;
using Microsoft.Extensions.Logging;


namespace Fabric.Sdk {
    public class HFClient {        
        private ILogger logger = HFLogger.CreateLogger<HFClient>();

        private HFClient() {
             logger.LogTrace("Initialising HF Client");                                             
        }
        public static HFClient CreateNewInstance() {
            return new HFClient();
        }
    }
}