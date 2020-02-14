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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = LoanStreet.LoanServicing.Client.OpenAPIDateConverter;

namespace LoanStreet.LoanServicing.Model
{
    /// <summary>
    /// FloatingInterestTerms
    /// </summary>
    [DataContract]
    public partial class FloatingInterestTerms : InterestTerms,  IEquatable<FloatingInterestTerms>, IValidatableObject
    {
        /// <summary>
        /// Defines Benchmark
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BenchmarkEnum
        {
            /// <summary>
            /// Enum LIBOROVERNIGHT for value: LIBOR_OVERNIGHT
            /// </summary>
            [EnumMember(Value = "LIBOR_OVERNIGHT")]
            LIBOROVERNIGHT = 1,

            /// <summary>
            /// Enum LIBOR1WEEK for value: LIBOR_1_WEEK
            /// </summary>
            [EnumMember(Value = "LIBOR_1_WEEK")]
            LIBOR1WEEK = 2,

            /// <summary>
            /// Enum LIBOR1MONTH for value: LIBOR_1_MONTH
            /// </summary>
            [EnumMember(Value = "LIBOR_1_MONTH")]
            LIBOR1MONTH = 3,

            /// <summary>
            /// Enum LIBOR2MONTH for value: LIBOR_2_MONTH
            /// </summary>
            [EnumMember(Value = "LIBOR_2_MONTH")]
            LIBOR2MONTH = 4,

            /// <summary>
            /// Enum LIBOR3MONTH for value: LIBOR_3_MONTH
            /// </summary>
            [EnumMember(Value = "LIBOR_3_MONTH")]
            LIBOR3MONTH = 5,

            /// <summary>
            /// Enum LIBOR6MONTH for value: LIBOR_6_MONTH
            /// </summary>
            [EnumMember(Value = "LIBOR_6_MONTH")]
            LIBOR6MONTH = 6,

            /// <summary>
            /// Enum LIBOR12MONTH for value: LIBOR_12_MONTH
            /// </summary>
            [EnumMember(Value = "LIBOR_12_MONTH")]
            LIBOR12MONTH = 7,

            /// <summary>
            /// Enum PRIME for value: PRIME
            /// </summary>
            [EnumMember(Value = "PRIME")]
            PRIME = 8,

            /// <summary>
            /// Enum FEDERALFUNDS for value: FEDERAL_FUNDS
            /// </summary>
            [EnumMember(Value = "FEDERAL_FUNDS")]
            FEDERALFUNDS = 9,

            /// <summary>
            /// Enum SOFR for value: SOFR
            /// </summary>
            [EnumMember(Value = "SOFR")]
            SOFR = 10,

            /// <summary>
            /// Enum FHLB for value: FHLB
            /// </summary>
            [EnumMember(Value = "FHLB")]
            FHLB = 11,

            /// <summary>
            /// Enum LIBORSWAP for value: LIBOR_SWAP
            /// </summary>
            [EnumMember(Value = "LIBOR_SWAP")]
            LIBORSWAP = 12,

            /// <summary>
            /// Enum USTREASURYOTR1YEAR for value: US_TREASURY_OTR_1_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_OTR_1_YEAR")]
            USTREASURYOTR1YEAR = 13,

            /// <summary>
            /// Enum USTREASURYOTR2YEAR for value: US_TREASURY_OTR_2_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_OTR_2_YEAR")]
            USTREASURYOTR2YEAR = 14,

            /// <summary>
            /// Enum USTREASURYOTR5YEAR for value: US_TREASURY_OTR_5_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_OTR_5_YEAR")]
            USTREASURYOTR5YEAR = 15,

            /// <summary>
            /// Enum USTREASURYOTR10YEAR for value: US_TREASURY_OTR_10_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_OTR_10_YEAR")]
            USTREASURYOTR10YEAR = 16,

            /// <summary>
            /// Enum USTREASURYOTR30YEAR for value: US_TREASURY_OTR_30_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_OTR_30_YEAR")]
            USTREASURYOTR30YEAR = 17,

            /// <summary>
            /// Enum USTREASURYCMT1YEAR for value: US_TREASURY_CMT_1_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_1_YEAR")]
            USTREASURYCMT1YEAR = 18,

            /// <summary>
            /// Enum USTREASURYCMT2YEAR for value: US_TREASURY_CMT_2_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_2_YEAR")]
            USTREASURYCMT2YEAR = 19,

            /// <summary>
            /// Enum USTREASURYCMT5YEAR for value: US_TREASURY_CMT_5_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_5_YEAR")]
            USTREASURYCMT5YEAR = 20,

            /// <summary>
            /// Enum USTREASURYCMT7YEAR for value: US_TREASURY_CMT_7_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_7_YEAR")]
            USTREASURYCMT7YEAR = 21,

            /// <summary>
            /// Enum USTREASURYCMT10YEAR for value: US_TREASURY_CMT_10_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_10_YEAR")]
            USTREASURYCMT10YEAR = 22,

            /// <summary>
            /// Enum USTREASURYCMT20YEAR for value: US_TREASURY_CMT_20_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_20_YEAR")]
            USTREASURYCMT20YEAR = 23,

            /// <summary>
            /// Enum USTREASURYCMT30YEAR for value: US_TREASURY_CMT_30_YEAR
            /// </summary>
            [EnumMember(Value = "US_TREASURY_CMT_30_YEAR")]
            USTREASURYCMT30YEAR = 24

        }

        /// <summary>
        /// Gets or Sets Benchmark
        /// </summary>
        [DataMember(Name="benchmark", EmitDefaultValue=false)]
        public BenchmarkEnum Benchmark { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingInterestTerms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FloatingInterestTerms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingInterestTerms" /> class.
        /// </summary>
        /// <param name="benchmark">benchmark (required).</param>
        /// <param name="effectiveDate">effectiveDate.</param>
        /// <param name="type">type (required).</param>
        public FloatingInterestTerms(BenchmarkEnum benchmark = default(BenchmarkEnum), DateTime effectiveDate = default(DateTime), string type = default(string)) : base(effectiveDate, type)
        {
            this.Benchmark = benchmark;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloatingInterestTerms {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Benchmark: ").Append(Benchmark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FloatingInterestTerms);
        }

        /// <summary>
        /// Returns true if FloatingInterestTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of FloatingInterestTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloatingInterestTerms input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Benchmark == input.Benchmark ||
                    this.Benchmark.Equals(input.Benchmark)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                hashCode = hashCode * 59 + this.Benchmark.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
