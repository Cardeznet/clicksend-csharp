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

using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Api;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing SearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SearchApiTests
    {
        private SearchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SearchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SearchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SearchApi
            //Assert.IsInstanceOfType(typeof(SearchApi), instance, "instance is a SearchApi");
        }

        
        /// <summary>
        /// Test SearchContactsListsGet
        /// </summary>
        [Test]
        public void SearchContactsListsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.SearchContactsListsGet(q, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}