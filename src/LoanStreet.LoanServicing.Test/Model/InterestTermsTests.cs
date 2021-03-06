/* 
 * OpenAPI definition
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using LoanStreet.LoanServicing.Api;
using LoanStreet.LoanServicing.Model;
using LoanStreet.LoanServicing.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace LoanStreet.LoanServicing.Test
{
    /// <summary>
    ///  Class for testing InterestTerms
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InterestTermsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InterestTerms
        //private InterestTerms instance;

        public InterestTermsTests()
        {
            // TODO uncomment below to create an instance of InterestTerms
            //instance = new InterestTerms();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InterestTerms
        /// </summary>
        [Fact]
        public void InterestTermsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InterestTerms
            //Assert.IsInstanceOfType<InterestTerms> (instance, "variable 'instance' is a InterestTerms");
        }

        /// <summary>
        /// Test deserialize a FixedPaymentInterestTerms from type InterestTerms
        /// </summary>
        [Fact]
        public void FixedPaymentInterestTermsDeserializeFromInterestTermsTest()
        {
            // TODO uncomment below to test deserialize a FixedPaymentInterestTerms from type InterestTerms
            //Assert.IsInstanceOf<InterestTerms>(JsonConvert.DeserializeObject<InterestTerms>(new FixedPaymentInterestTerms().ToJson()));
        }
        /// <summary>
        /// Test deserialize a FloatingInterestTerms from type InterestTerms
        /// </summary>
        [Fact]
        public void FloatingInterestTermsDeserializeFromInterestTermsTest()
        {
            // TODO uncomment below to test deserialize a FloatingInterestTerms from type InterestTerms
            //Assert.IsInstanceOf<InterestTerms>(JsonConvert.DeserializeObject<InterestTerms>(new FloatingInterestTerms().ToJson()));
        }

        /// <summary>
        /// Test the property 'EffectiveDate'
        /// </summary>
        [Fact]
        public void EffectiveDateTest()
        {
            // TODO unit test for the property 'EffectiveDate'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

    }

}
