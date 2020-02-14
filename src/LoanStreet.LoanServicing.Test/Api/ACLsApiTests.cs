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
    ///  Class for testing ACLsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ACLsApiTests : IDisposable
    {
        private ACLsApi instance;

        public ACLsApiTests()
        {
            instance = new ACLsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ACLsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ACLsApi
            //Assert.IsType(typeof(ACLsApi), instance, "instance is a ACLsApi");
        }

        
        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string oid = null;
            //var response = instance.List(oid);
            //Assert.IsType<AclDto> (response, "response is AclDto");
        }
        
    }

}