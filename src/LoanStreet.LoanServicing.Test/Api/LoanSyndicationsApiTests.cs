/* 
 * OpenAPI definition
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using LoanStreet.LoanServicing.Client;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Model;

namespace LoanStreet.LoanServicing.Test
{
    /// <summary>
    ///  Class for testing LoanSyndicationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LoanSyndicationsApiTests : IDisposable
    {
        private LoanSyndicationsApi instance;

        public LoanSyndicationsApiTests()
        {
            instance = new LoanSyndicationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoanSyndicationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LoanSyndicationsApi
            //Assert.IsType(typeof(LoanSyndicationsApi), instance, "instance is a LoanSyndicationsApi");
        }

        
        /// <summary>
        /// Test CreateSyndication
        /// </summary>
        [Fact]
        public void CreateSyndicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //Sale sale = null;
            //var response = instance.CreateSyndication(loanId, sale);
            //Assert.IsType<Sale> (response, "response is Sale");
        }
        
    }

}