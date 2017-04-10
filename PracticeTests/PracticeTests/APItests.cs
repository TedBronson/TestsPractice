using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;

namespace PracticeTests
{
    class APItests
    {
        const string BaseUrl = "https://launchlibrary.net/1.1/";

        [Test]
        public void getListOfLaunches()
        {
            var client = new RestClient(BaseUrl);

            //Creating a GET request
            var request = new RestRequest("launch/Falcon", Method.GET);

            //Executing the request
            IRestResponse response = client.Execute(request);

            const string statusCode = "OK";

            //HttpStatusCode 
            Assert.AreEqual(statusCode, response.StatusDescription);
        }

    }
}
