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
    /// MultipleDrawRules
    /// </summary>
    [DataContract]
    public partial class MultipleDrawRules : DrawRules,  IEquatable<MultipleDrawRules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleDrawRules" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultipleDrawRules() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleDrawRules" /> class.
        /// </summary>
        /// <param name="commitment">commitment (required).</param>
        /// <param name="maxNumDraws">maxNumDraws (required).</param>
        /// <param name="numDraws">numDraws (required).</param>
        /// <param name="minDrawAmount">minDrawAmount.</param>
        /// <param name="date">date (required).</param>
        /// <param name="type">type (required).</param>
        public MultipleDrawRules(Money commitment = default(Money), int maxNumDraws = default(int), int numDraws = default(int), Money minDrawAmount = default(Money), DateTime date = default(DateTime), string type = default(string)) : base(date, type)
        {
            // to ensure "commitment" is required (not null)
            this.Commitment = commitment ?? throw new ArgumentNullException("commitment is a required property for MultipleDrawRules and cannot be null");;
            this.MaxNumDraws = maxNumDraws;
            this.NumDraws = numDraws;
            this.MinDrawAmount = minDrawAmount;
        }
        
        /// <summary>
        /// Gets or Sets Commitment
        /// </summary>
        [DataMember(Name="commitment", EmitDefaultValue=false)]
        public Money Commitment { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumDraws
        /// </summary>
        [DataMember(Name="maxNumDraws", EmitDefaultValue=false)]
        public int MaxNumDraws { get; set; }

        /// <summary>
        /// Gets or Sets NumDraws
        /// </summary>
        [DataMember(Name="numDraws", EmitDefaultValue=false)]
        public int NumDraws { get; set; }

        /// <summary>
        /// Gets or Sets MinDrawAmount
        /// </summary>
        [DataMember(Name="minDrawAmount", EmitDefaultValue=false)]
        public Money MinDrawAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipleDrawRules {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Commitment: ").Append(Commitment).Append("\n");
            sb.Append("  MaxNumDraws: ").Append(MaxNumDraws).Append("\n");
            sb.Append("  NumDraws: ").Append(NumDraws).Append("\n");
            sb.Append("  MinDrawAmount: ").Append(MinDrawAmount).Append("\n");
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
            return this.Equals(input as MultipleDrawRules);
        }

        /// <summary>
        /// Returns true if MultipleDrawRules instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipleDrawRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipleDrawRules input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Commitment == input.Commitment ||
                    (this.Commitment != null &&
                    this.Commitment.Equals(input.Commitment))
                ) && base.Equals(input) && 
                (
                    this.MaxNumDraws == input.MaxNumDraws ||
                    this.MaxNumDraws.Equals(input.MaxNumDraws)
                ) && base.Equals(input) && 
                (
                    this.NumDraws == input.NumDraws ||
                    this.NumDraws.Equals(input.NumDraws)
                ) && base.Equals(input) && 
                (
                    this.MinDrawAmount == input.MinDrawAmount ||
                    (this.MinDrawAmount != null &&
                    this.MinDrawAmount.Equals(input.MinDrawAmount))
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
                if (this.Commitment != null)
                    hashCode = hashCode * 59 + this.Commitment.GetHashCode();
                hashCode = hashCode * 59 + this.MaxNumDraws.GetHashCode();
                hashCode = hashCode * 59 + this.NumDraws.GetHashCode();
                if (this.MinDrawAmount != null)
                    hashCode = hashCode * 59 + this.MinDrawAmount.GetHashCode();
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
