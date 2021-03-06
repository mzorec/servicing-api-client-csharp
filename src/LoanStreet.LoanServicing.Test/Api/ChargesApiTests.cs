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
    ///  Class for testing ChargesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChargesApiTests : IDisposable
    {
        private ChargesApi instance;

        public ChargesApiTests()
        {
            instance = new ChargesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChargesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ChargesApi
            //Assert.IsType(typeof(ChargesApi), instance, "instance is a ChargesApi");
        }

        
        /// <summary>
        /// Test GetCharge
        /// </summary>
        [Fact]
        public void GetChargeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string facilityId = null;
            //string chargeId = null;
            //var response = instance.GetCharge(facilityId, chargeId);
            //Assert.IsType<Charge> (response, "response is Charge");
        }
        
        /// <summary>
        /// Test ListCharges
        /// </summary>
        [Fact]
        public void ListChargesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string facilityId = null;
            //var response = instance.ListCharges(facilityId);
            //Assert.IsType<List<Charge>> (response, "response is List<Charge>");
        }
        
    }

}
