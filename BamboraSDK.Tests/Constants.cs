using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bambora.NA.SDK.Tests
{
    public static class Constants
    {
        private static int _merchantId = 379080000;
        private static int? _subMerchantId = 300208546;
        private static string _paymentsApiKey = "56D9e5e870664452A4D51DBBd81Ec67C";
        private static string _reportingApiKey = "f2Beb8aeC0434b5885F7324B2aC37F77";
        private static string _profilesApiKey = "9CD45D2BE37246E0BCB7E9B47AFA7D95";
        private static string _batchApiKey = "67e0082A4B2d4C1Ea5a0EB4d0Ab7cd7e";
        private static string _apiVersion = "1";

        public static int MerchantId
        {
            get
            {
                return _merchantId;
            }
        }

        public static int? SubMerchantId 
        { 
            get 
            {
                return _subMerchantId;
            } 
        }

        public static string PaymentsApiKey
        {
            get
            {
                return _paymentsApiKey;
            }
        }

        public static string ReportingApiKey
        {
            get
            {
                return _reportingApiKey;
            }
        }

        public static string ProfilesApiKey
        {
            get
            {
                return _profilesApiKey;
            }
        }

        public static string BatchApiKey
        {
            get
            {
                return _batchApiKey;
            }
        }

        public static string ApiVersion
        {
            get
            {
                return _apiVersion;
            }
        }
    }
}
