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
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="streetOne">streetOne (required).</param>
        /// <param name="streetTwo">streetTwo (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="zip">zip (required).</param>
        public Address(string streetOne = default(string), string streetTwo = default(string), string city = default(string), string state = default(string), string zip = default(string))
        {
            // to ensure "streetOne" is required (not null)
            this.StreetOne = streetOne ?? throw new ArgumentNullException("streetOne is a required property for Address and cannot be null");;
            // to ensure "streetTwo" is required (not null)
            this.StreetTwo = streetTwo ?? throw new ArgumentNullException("streetTwo is a required property for Address and cannot be null");;
            // to ensure "city" is required (not null)
            this.City = city ?? throw new ArgumentNullException("city is a required property for Address and cannot be null");;
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for Address and cannot be null");;
            // to ensure "zip" is required (not null)
            this.Zip = zip ?? throw new ArgumentNullException("zip is a required property for Address and cannot be null");;
        }
        
        /// <summary>
        /// Gets or Sets StreetOne
        /// </summary>
        [DataMember(Name="streetOne", EmitDefaultValue=false)]
        public string StreetOne { get; set; }

        /// <summary>
        /// Gets or Sets StreetTwo
        /// </summary>
        [DataMember(Name="streetTwo", EmitDefaultValue=false)]
        public string StreetTwo { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  StreetOne: ").Append(StreetOne).Append("\n");
            sb.Append("  StreetTwo: ").Append(StreetTwo).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StreetOne == input.StreetOne ||
                    (this.StreetOne != null &&
                    this.StreetOne.Equals(input.StreetOne))
                ) && 
                (
                    this.StreetTwo == input.StreetTwo ||
                    (this.StreetTwo != null &&
                    this.StreetTwo.Equals(input.StreetTwo))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                int hashCode = 41;
                if (this.StreetOne != null)
                    hashCode = hashCode * 59 + this.StreetOne.GetHashCode();
                if (this.StreetTwo != null)
                    hashCode = hashCode * 59 + this.StreetTwo.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
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
            yield break;
        }
    }

}
