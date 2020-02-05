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
    /// PrincipalCharge
    /// </summary>
    [DataContract]
    public partial class PrincipalCharge : Charge,  IEquatable<PrincipalCharge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalCharge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrincipalCharge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalCharge" /> class.
        /// </summary>
        /// <param name="date">date (required).</param>
        /// <param name="chargeId">chargeId (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="type">type (required).</param>
        public PrincipalCharge(DateTime date = default(DateTime), string chargeId = default(string), Money amount = default(Money), TypeEnum type = default(TypeEnum)) : base(date, chargeId, amount, type)
        {
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrincipalCharge {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            return this.Equals(input as PrincipalCharge);
        }

        /// <summary>
        /// Returns true if PrincipalCharge instances are equal
        /// </summary>
        /// <param name="input">Instance of PrincipalCharge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrincipalCharge input)
        {
            if (input == null)
                return false;

            return base.Equals(input);
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
