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
    ///  Class for testing FacilitiesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FacilitiesApiTests : IDisposable
    {
        private FacilitiesApi instance;

        public FacilitiesApiTests()
        {
            instance = new FacilitiesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FacilitiesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FacilitiesApi
            //Assert.IsType(typeof(FacilitiesApi), instance, "instance is a FacilitiesApi");
        }

        
        /// <summary>
        /// Test CreateFacility
        /// </summary>
        [Fact]
        public void CreateFacilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Facility facility = null;
            //var response = instance.CreateFacility(facility);
            //Assert.IsType<Facility> (response, "response is Facility");
        }
        
        /// <summary>
        /// Test GetFacility
        /// </summary>
        [Fact]
        public void GetFacilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string facilityId = null;
            //var response = instance.GetFacility(facilityId);
            //Assert.IsType<Facility> (response, "response is Facility");
        }
        
        /// <summary>
        /// Test ListFacilities
        /// </summary>
        [Fact]
        public void ListFacilitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string borrower = null;
            //string fund = null;
            //var response = instance.ListFacilities(borrower, fund);
            //Assert.IsType<List<Facility>> (response, "response is List<Facility>");
        }
        
    }

}
