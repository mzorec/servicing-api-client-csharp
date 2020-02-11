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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test Create1
        /// </summary>
        [Fact]
        public void Create1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserRequest createUserRequest = null;
            //var response = instance.Create1(createUserRequest);
            //Assert.IsType<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test Fetch1
        /// </summary>
        [Fact]
        public void Fetch1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.Fetch1(userId);
            //Assert.IsType<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.List();
            //Assert.IsType<List<User>> (response, "response is List<User>");
        }
        
    }

}