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
    ///  Class for testing VoiceDeliveryReceiptRulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VoiceDeliveryReceiptRulesApiTests
    {
        private VoiceDeliveryReceiptRulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoiceDeliveryReceiptRulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoiceDeliveryReceiptRulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VoiceDeliveryReceiptRulesApi
            //Assert.IsInstanceOfType(typeof(VoiceDeliveryReceiptRulesApi), instance, "instance is a VoiceDeliveryReceiptRulesApi");
        }

        
        /// <summary>
        /// Test VoiceDeliveryReceiptAutomationDelete
        /// </summary>
        [Test]
        public void VoiceDeliveryReceiptAutomationDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.VoiceDeliveryReceiptAutomationDelete(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceDeliveryReceiptAutomationGet
        /// </summary>
        [Test]
        public void VoiceDeliveryReceiptAutomationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //var response = instance.VoiceDeliveryReceiptAutomationGet(receiptRuleId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceDeliveryReceiptAutomationPost
        /// </summary>
        [Test]
        public void VoiceDeliveryReceiptAutomationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.VoiceDeliveryReceiptAutomationPost(deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceDeliveryReceiptAutomationPut
        /// </summary>
        [Test]
        public void VoiceDeliveryReceiptAutomationPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? receiptRuleId = null;
            //DeliveryReceiptRule deliveryReceiptRule = null;
            //var response = instance.VoiceDeliveryReceiptAutomationPut(receiptRuleId, deliveryReceiptRule);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceDeliveryReceiptAutomationsGet
        /// </summary>
        [Test]
        public void VoiceDeliveryReceiptAutomationsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.VoiceDeliveryReceiptAutomationsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}