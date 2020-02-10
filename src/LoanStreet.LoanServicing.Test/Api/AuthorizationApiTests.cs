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
    ///  Class for testing AuthorizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthorizationApiTests : IDisposable
    {
        private AuthorizationApi instance;

        public AuthorizationApiTests()
        {
            instance = new AuthorizationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthorizationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AuthorizationApi
            //Assert.IsType(typeof(AuthorizationApi), instance, "instance is a AuthorizationApi");
        }

        
        /// <summary>
        /// Test Auth
        /// </summary>
        [Fact]
        public void AuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Auth();
            //Assert.IsType<Authentication> (response, "response is Authentication");
        }
        
        /// <summary>
        /// Test Principal
        /// </summary>
        [Fact]
        public void PrincipalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //JwtAuthenticationToken principal = null;
            //var response = instance.Principal(principal);
            //Assert.IsType<JwtAuthenticationToken> (response, "response is JwtAuthenticationToken");
        }
        
        /// <summary>
        /// Test Token
        /// </summary>
        [Fact]
        public void TokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PasswordAuthRequest passwordAuthRequest = null;
            //var response = instance.Token(passwordAuthRequest);
            //Assert.IsType<PasswordAuthResponse> (response, "response is PasswordAuthResponse");
        }
        
    }

}
