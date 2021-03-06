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
    /// GrantedAuthority
    /// </summary>
    [DataContract]
    public partial class GrantedAuthority :  IEquatable<GrantedAuthority>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantedAuthority" /> class.
        /// </summary>
        /// <param name="authority">authority.</param>
        public GrantedAuthority(string authority = default(string))
        {
            this.Authority = authority;
        }
        
        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantedAuthority {\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
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
            return this.Equals(input as GrantedAuthority);
        }

        /// <summary>
        /// Returns true if GrantedAuthority instances are equal
        /// </summary>
        /// <param name="input">Instance of GrantedAuthority to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantedAuthority input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authority == input.Authority ||
                    (this.Authority != null &&
                    this.Authority.Equals(input.Authority))
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
                if (this.Authority != null)
                    hashCode = hashCode * 59 + this.Authority.GetHashCode();
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
