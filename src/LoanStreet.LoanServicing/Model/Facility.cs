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
    /// Facility
    /// </summary>
    [DataContract]
    public partial class Facility :  IEquatable<Facility>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facility" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Facility() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Facility" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="totalCommitmentAmount">totalCommitmentAmount (required).</param>
        public Facility(string name = default(string), Money totalCommitmentAmount = default(Money))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Facility and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "totalCommitmentAmount" is required (not null)
            if (totalCommitmentAmount == null)
            {
                throw new InvalidDataException("totalCommitmentAmount is a required property for Facility and cannot be null");
            }
            else
            {
                this.TotalCommitmentAmount = totalCommitmentAmount;
            }

        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TotalCommitmentAmount
        /// </summary>
        [DataMember(Name="totalCommitmentAmount", EmitDefaultValue=false)]
        public Money TotalCommitmentAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Facility {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TotalCommitmentAmount: ").Append(TotalCommitmentAmount).Append("\n");
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
            return this.Equals(input as Facility);
        }

        /// <summary>
        /// Returns true if Facility instances are equal
        /// </summary>
        /// <param name="input">Instance of Facility to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Facility input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TotalCommitmentAmount == input.TotalCommitmentAmount ||
                    (this.TotalCommitmentAmount != null &&
                    this.TotalCommitmentAmount.Equals(input.TotalCommitmentAmount))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TotalCommitmentAmount != null)
                    hashCode = hashCode * 59 + this.TotalCommitmentAmount.GetHashCode();
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
