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
    /// Tranche
    /// </summary>
    [DataContract]
    public partial class Tranche :  IEquatable<Tranche>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tranche" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="draw">draw.</param>
        /// <param name="interest">interest.</param>
        public Tranche(string name = default(string), DrawRules draw = default(DrawRules), InterestRules interest = default(InterestRules))
        {
            this.Name = name;
            this.Draw = draw;
            this.Interest = interest;
        }
        
        /// <summary>
        /// Gets or Sets TrancheId
        /// </summary>
        [DataMember(Name="trancheId", EmitDefaultValue=false)]
        public string TrancheId { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Draw
        /// </summary>
        [DataMember(Name="draw", EmitDefaultValue=false)]
        public DrawRules Draw { get; set; }

        /// <summary>
        /// Gets or Sets Interest
        /// </summary>
        [DataMember(Name="interest", EmitDefaultValue=false)]
        public InterestRules Interest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tranche {\n");
            sb.Append("  TrancheId: ").Append(TrancheId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Draw: ").Append(Draw).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
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
            return this.Equals(input as Tranche);
        }

        /// <summary>
        /// Returns true if Tranche instances are equal
        /// </summary>
        /// <param name="input">Instance of Tranche to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tranche input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrancheId == input.TrancheId ||
                    (this.TrancheId != null &&
                    this.TrancheId.Equals(input.TrancheId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Draw == input.Draw ||
                    (this.Draw != null &&
                    this.Draw.Equals(input.Draw))
                ) && 
                (
                    this.Interest == input.Interest ||
                    (this.Interest != null &&
                    this.Interest.Equals(input.Interest))
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
                if (this.TrancheId != null)
                    hashCode = hashCode * 59 + this.TrancheId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Draw != null)
                    hashCode = hashCode * 59 + this.Draw.GetHashCode();
                if (this.Interest != null)
                    hashCode = hashCode * 59 + this.Interest.GetHashCode();
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
