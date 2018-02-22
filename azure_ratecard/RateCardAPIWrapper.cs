using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace azure_ratecard
{

    public class GetInvoice
    {

        string url = "https://management.azure.com/subscriptions/{subscriptionId}/providers/Microsoft.Billing/invoices?api-version=2017-02-27-preview";
    }

    public class RateCardApIWrapper
    {
        private string _clientId;
        private string _clientSecret;
        private string _resource = "https://management.azure.com";

        public RateCardApIWrapper(string clientId,string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
           
        }
        private static string GetAuthCodeURL(string tanentId, string clientID, string redirectUrl, string resource)
        {

            string state = Guid.NewGuid().ToString();
            return @"https://login.microsoftonline.com/" + tanentId + @"/oauth2/authorize?
            client_id=" + clientID + @"
            &response_type=code
            &redirect_uri=" + redirectUrl + @"
            &response_mode=query
            &resource=" + resource + @"
            &state=" + state;

        }

        /// <summary>
        /// This class get the Access token on behalf of client.
        /// </summary>
        /// <param name="grant_type"></param>
        /// <param name="client_id"></param>
        /// <param name="client_secret"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public string GetToken()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://login.microsoftonline.com/ABB.onmicrosoft.com/oauth2/token");
            RestRequest restRequest = new RestRequest(Method.POST);

            //load settings from json file
            //string filedata = File.ReadAllText("./appsettings.json");
            //AppSettings appSettings= Newtonsoft.Json.JsonConvert.DeserializeObject <AppSettings>(filedata);


            restRequest.AddParameter("grant_type", "client_credentials");
            restRequest.AddParameter("client_id", _clientId);
            restRequest.AddParameter("client_secret",_clientSecret);
            restRequest.AddParameter("resource", _resource);

            IRestResponse response = client.Execute(restRequest);
            ResponseData responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseData>(response.Content);
            return responseData.Access_token;
        }
       
    }
}
