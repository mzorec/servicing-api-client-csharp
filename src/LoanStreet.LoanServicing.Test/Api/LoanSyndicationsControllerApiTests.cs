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
using LoanStreet.LoanServicing.Api;
using Xunit;

namespace LoanStreet.LoanServicing.Test
{
    /// <summary>
    ///     Class for testing LoanSyndicationsControllerApi
    /// </summary>
    /// <remarks>
    ///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    ///     Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LoanSyndicationsControllerApiTests : IDisposable
    {
        public LoanSyndicationsControllerApiTests()
        {
            instance = new LoanSyndicationsControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        private LoanSyndicationsControllerApi instance;


        /// <summary>
        ///     Test CreateSyndication
        /// </summary>
        [Fact]
        public void CreateSyndicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //RecordLoanSaleRequest recordLoanSaleRequest = null;
            //var response = instance.CreateSyndication(loanId, recordLoanSaleRequest);
            //Assert.IsType<Object> (response, "response is Object");
        }

        /// <summary>
        ///     Test GetSyndication
        /// </summary>
        [Fact]
        public void GetSyndicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string institutionId = null;
            //var response = instance.GetSyndication(loanId, institutionId);
            //Assert.IsType<Object> (response, "response is Object");
        }

        /// <summary>
        ///     Test an instance of LoanSyndicationsControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LoanSyndicationsControllerApi
            //Assert.IsType(typeof(LoanSyndicationsControllerApi), instance, "instance is a LoanSyndicationsControllerApi");
        }

        /// <summary>
        ///     Test ListSyndications
        /// </summary>
        [Fact]
        public void ListSyndicationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //var response = instance.ListSyndications(loanId);
            //Assert.IsType<List<Object>> (response, "response is List<Object>");
        }
    }
}