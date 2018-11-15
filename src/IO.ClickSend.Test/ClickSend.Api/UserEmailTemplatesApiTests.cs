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
using IO.ClickSend.ClickSend.Model;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing UserEmailTemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserEmailTemplatesApiTests
    {
        private UserEmailTemplatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserEmailTemplatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserEmailTemplatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserEmailTemplatesApi
            //Assert.IsInstanceOfType(typeof(UserEmailTemplatesApi), instance, "instance is a UserEmailTemplatesApi");
        }

        
        /// <summary>
        /// Test EmailTemplateDelete
        /// </summary>
        [Test]
        public void EmailTemplateDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? templateId = null;
            //var response = instance.EmailTemplateDelete(templateId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailTemplateGet
        /// </summary>
        [Test]
        public void EmailTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? templateId = null;
            //var response = instance.EmailTemplateGet(templateId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailTemplatePost
        /// </summary>
        [Test]
        public void EmailTemplatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailTemplateNew emailTemplate = null;
            //var response = instance.EmailTemplatePost(emailTemplate);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailTemplatePut
        /// </summary>
        [Test]
        public void EmailTemplatePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? templateId = null;
            //EmailTemplateUpdate emailTemplate = null;
            //var response = instance.EmailTemplatePut(templateId, emailTemplate);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EmailTemplatesGet
        /// </summary>
        [Test]
        public void EmailTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.EmailTemplatesGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
