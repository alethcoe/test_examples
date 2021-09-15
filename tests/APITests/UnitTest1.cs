using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace APITests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var client = new RestClient("https://localhost:44374");
            var request = new RestRequest("cars/10");

            var response = client.Get(request);
            Assert.AreEqual(HttpStatusCode.OK,response.StatusCode);
        }
    }
}