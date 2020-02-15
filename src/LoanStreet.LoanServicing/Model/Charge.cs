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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = LoanStreet.LoanServicing.Client.OpenAPIDateConverter;

namespace LoanStreet.LoanServicing.Model
{
    /// <summary>
    /// Charge
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(InterestCharge), "InterestCharge")]
    [JsonSubtypes.KnownSubType(typeof(PrincipalCharge), "PrincipalCharge")]
    [JsonSubtypes.KnownSubType(typeof(InterestCharge), "INTEREST")]
    [JsonSubtypes.KnownSubType(typeof(PrincipalCharge), "PRINCIPAL")]
    public partial class Charge :  IEquatable<Charge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Charge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="chargeId">chargeId (required).</param>
        /// <param name="period">period.</param>
        /// <param name="type">type (required).</param>
        public Charge(Money amount = default(Money), string chargeId = default(string), LocalDatePeriod period = default(LocalDatePeriod), string type = default(string))
        {
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount is a required property for Charge and cannot be null");;
            // to ensure "chargeId" is required (not null)
            this.ChargeId = chargeId ?? throw new ArgumentNullException("chargeId is a required property for Charge and cannot be null");;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for Charge and cannot be null");;
            this.Period = period;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public Money Amount { get; set; }

        /// <summary>
        /// Gets or Sets ChargeId
        /// </summary>
        [DataMember(Name="chargeId", EmitDefaultValue=false)]
        public string ChargeId { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public LocalDatePeriod Period { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Charge);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="input">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ChargeId == input.ChargeId ||
                    (this.ChargeId != null &&
                    this.ChargeId.Equals(input.ChargeId))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ChargeId != null)
                    hashCode = hashCode * 59 + this.ChargeId.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
