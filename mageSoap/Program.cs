using System;
using mageSoap.ServiceReference;

namespace mageSoap
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage_Api_Model_Server_Wsi_HandlerPortTypeClient client = new Mage_Api_Model_Server_Wsi_HandlerPortTypeClient();

            //log in Magento API to get the session_id
            loginResponse session = client.loginAsync("userAPI","keyAPI").Result;
            string sessionId = session.result;
            Console.WriteLine("Session ID: " + sessionId);

            //Let's get the info from Order "100000010"
            var response = client.salesOrderInfoAsync(sessionId,"100000010").Result;
            salesOrderEntity order = response.result;
            Console.WriteLine("Status in Order: " + order.status);
        }
    }
}
