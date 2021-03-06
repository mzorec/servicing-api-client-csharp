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
    /// Jwt
    /// </summary>
    [DataContract]
    public partial class Jwt :  IEquatable<Jwt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jwt" /> class.
        /// </summary>
        /// <param name="tokenValue">tokenValue.</param>
        /// <param name="issuedAt">issuedAt.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="headers">headers.</param>
        /// <param name="claims">claims.</param>
        /// <param name="subject">subject.</param>
        /// <param name="notBefore">notBefore.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="audience">audience.</param>
        /// <param name="id">id.</param>
        public Jwt(string tokenValue = default(string), long issuedAt = default(long), long expiresAt = default(long), Dictionary<string, Object> headers = default(Dictionary<string, Object>), Dictionary<string, Object> claims = default(Dictionary<string, Object>), string subject = default(string), long notBefore = default(long), string issuer = default(string), List<string> audience = default(List<string>), string id = default(string))
        {
            this.TokenValue = tokenValue;
            this.IssuedAt = issuedAt;
            this.ExpiresAt = expiresAt;
            this.Headers = headers;
            this.Claims = claims;
            this.Subject = subject;
            this.NotBefore = notBefore;
            this.Issuer = issuer;
            this.Audience = audience;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets TokenValue
        /// </summary>
        [DataMember(Name="tokenValue", EmitDefaultValue=false)]
        public string TokenValue { get; set; }

        /// <summary>
        /// Gets or Sets IssuedAt
        /// </summary>
        [DataMember(Name="issuedAt", EmitDefaultValue=false)]
        public long IssuedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name="expiresAt", EmitDefaultValue=false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Dictionary<string, Object> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Claims
        /// </summary>
        [DataMember(Name="claims", EmitDefaultValue=false)]
        public Dictionary<string, Object> Claims { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets NotBefore
        /// </summary>
        [DataMember(Name="notBefore", EmitDefaultValue=false)]
        public long NotBefore { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name="issuer", EmitDefaultValue=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name="audience", EmitDefaultValue=false)]
        public List<string> Audience { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Jwt {\n");
            sb.Append("  TokenValue: ").Append(TokenValue).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Claims: ").Append(Claims).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as Jwt);
        }

        /// <summary>
        /// Returns true if Jwt instances are equal
        /// </summary>
        /// <param name="input">Instance of Jwt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Jwt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenValue == input.TokenValue ||
                    (this.TokenValue != null &&
                    this.TokenValue.Equals(input.TokenValue))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    this.IssuedAt.Equals(input.IssuedAt)
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Claims == input.Claims ||
                    this.Claims != null &&
                    input.Claims != null &&
                    this.Claims.SequenceEqual(input.Claims)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.NotBefore == input.NotBefore ||
                    this.NotBefore.Equals(input.NotBefore)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Audience == input.Audience ||
                    this.Audience != null &&
                    input.Audience != null &&
                    this.Audience.SequenceEqual(input.Audience)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.TokenValue != null)
                    hashCode = hashCode * 59 + this.TokenValue.GetHashCode();
                hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Claims != null)
                    hashCode = hashCode * 59 + this.Claims.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                if (this.Issuer != null)
                    hashCode = hashCode * 59 + this.Issuer.GetHashCode();
                if (this.Audience != null)
                    hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
