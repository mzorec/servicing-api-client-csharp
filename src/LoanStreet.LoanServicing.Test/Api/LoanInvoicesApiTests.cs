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
    ///  Class for testing LoanInvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LoanInvoicesApiTests : IDisposable
    {
        private LoanInvoicesApi instance;

        public LoanInvoicesApiTests()
        {
            instance = new LoanInvoicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoanInvoicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LoanInvoicesApi
            //Assert.IsType(typeof(LoanInvoicesApi), instance, "instance is a LoanInvoicesApi");
        }

        
        /// <summary>
        /// Test CreateInvoice
        /// </summary>
        [Fact]
        public void CreateInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //Invoice invoice = null;
            //var response = instance.CreateInvoice(loanId, invoice);
            //Assert.IsType<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test GetInvoice
        /// </summary>
        [Fact]
        public void GetInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //string invoiceId = null;
            //var response = instance.GetInvoice(loanId, invoiceId);
            //Assert.IsType<Invoice> (response, "response is Invoice");
        }
        
        /// <summary>
        /// Test ListInvoiceHistory
        /// </summary>
        [Fact]
        public void ListInvoiceHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string loanId = null;
            //var response = instance.ListInvoiceHistory(loanId);
            //Assert.IsType<List<Invoice>> (response, "response is List<Invoice>");
        }
        
    }

}