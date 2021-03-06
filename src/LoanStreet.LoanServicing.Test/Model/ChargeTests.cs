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
    ///  Class for testing Charge
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ChargeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Charge
        //private Charge instance;

        public ChargeTests()
        {
            // TODO uncomment below to create an instance of Charge
            //instance = new Charge();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Charge
        /// </summary>
        [Fact]
        public void ChargeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Charge
            //Assert.IsInstanceOfType<Charge> (instance, "variable 'instance' is a Charge");
        }

        /// <summary>
        /// Test deserialize a InterestCharge from type Charge
        /// </summary>
        [Fact]
        public void InterestChargeDeserializeFromChargeTest()
        {
            // TODO uncomment below to test deserialize a InterestCharge from type Charge
            //Assert.IsInstanceOf<Charge>(JsonConvert.DeserializeObject<Charge>(new InterestCharge().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PrincipalCharge from type Charge
        /// </summary>
        [Fact]
        public void PrincipalChargeDeserializeFromChargeTest()
        {
            // TODO uncomment below to test deserialize a PrincipalCharge from type Charge
            //Assert.IsInstanceOf<Charge>(JsonConvert.DeserializeObject<Charge>(new PrincipalCharge().ToJson()));
        }

        /// <summary>
        /// Test the property 'ChargeId'
        /// </summary>
        [Fact]
        public void ChargeIdTest()
        {
            // TODO unit test for the property 'ChargeId'
        }
        /// <summary>
        /// Test the property 'Period'
        /// </summary>
        [Fact]
        public void PeriodTest()
        {
            // TODO unit test for the property 'Period'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
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
