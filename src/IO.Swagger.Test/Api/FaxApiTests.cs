/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FaxApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FaxApiTests
    {
        private FaxApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaxApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FaxApi
            //Assert.IsInstanceOfType(typeof(FaxApi), instance, "instance is a FaxApi");
        }

        
        /// <summary>
        /// Test FaxHistoryGet
        /// </summary>
        [Test]
        public void FaxHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? dateFrom = null;
            //int? dateTo = null;
            //string q = null;
            //string order = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.FaxHistoryGet(dateFrom, dateTo, q, order, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxPricePost
        /// </summary>
        [Test]
        public void FaxPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FaxMessageCollection faxMessage = null;
            //var response = instance.FaxPricePost(faxMessage);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxReceiptsByMessageIdGet
        /// </summary>
        [Test]
        public void FaxReceiptsByMessageIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string messageId = null;
            //var response = instance.FaxReceiptsByMessageIdGet(messageId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxReceiptsGet
        /// </summary>
        [Test]
        public void FaxReceiptsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.FaxReceiptsGet();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test FaxSendPost
        /// </summary>
        [Test]
        public void FaxSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FaxMessageCollection faxMessage = null;
            //var response = instance.FaxSendPost(faxMessage);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}