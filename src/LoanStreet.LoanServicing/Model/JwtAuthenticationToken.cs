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
    /// JwtAuthenticationToken
    /// </summary>
    [DataContract]
    public partial class JwtAuthenticationToken :  IEquatable<JwtAuthenticationToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JwtAuthenticationToken" /> class.
        /// </summary>
        /// <param name="authorities">authorities.</param>
        /// <param name="details">details.</param>
        /// <param name="authenticated">authenticated.</param>
        /// <param name="principal">principal.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="token">token.</param>
        /// <param name="name">name.</param>
        /// <param name="tokenAttributes">tokenAttributes.</param>
        public JwtAuthenticationToken(List<GrantedAuthority> authorities = default(List<GrantedAuthority>), Object details = default(Object), bool authenticated = default(bool), Object principal = default(Object), Object credentials = default(Object), Jwt token = default(Jwt), string name = default(string), Dictionary<string, Object> tokenAttributes = default(Dictionary<string, Object>))
        {
            this.Authorities = authorities;
            this.Details = details;
            this.Authenticated = authenticated;
            this.Principal = principal;
            this.Credentials = credentials;
            this.Token = token;
            this.Name = name;
            this.TokenAttributes = tokenAttributes;
        }
        
        /// <summary>
        /// Gets or Sets Authorities
        /// </summary>
        [DataMember(Name="authorities", EmitDefaultValue=false)]
        public List<GrantedAuthority> Authorities { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Object Details { get; set; }

        /// <summary>
        /// Gets or Sets Authenticated
        /// </summary>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool Authenticated { get; set; }

        /// <summary>
        /// Gets or Sets Principal
        /// </summary>
        [DataMember(Name="principal", EmitDefaultValue=false)]
        public Object Principal { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public Object Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Jwt Token { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TokenAttributes
        /// </summary>
        [DataMember(Name="tokenAttributes", EmitDefaultValue=false)]
        public Dictionary<string, Object> TokenAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JwtAuthenticationToken {\n");
            sb.Append("  Authorities: ").Append(Authorities).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TokenAttributes: ").Append(TokenAttributes).Append("\n");
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
            return this.Equals(input as JwtAuthenticationToken);
        }

        /// <summary>
        /// Returns true if JwtAuthenticationToken instances are equal
        /// </summary>
        /// <param name="input">Instance of JwtAuthenticationToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JwtAuthenticationToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Authorities == input.Authorities ||
                    this.Authorities != null &&
                    input.Authorities != null &&
                    this.Authorities.SequenceEqual(input.Authorities)
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Authenticated == input.Authenticated ||
                    this.Authenticated.Equals(input.Authenticated)
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TokenAttributes == input.TokenAttributes ||
                    this.TokenAttributes != null &&
                    input.TokenAttributes != null &&
                    this.TokenAttributes.SequenceEqual(input.TokenAttributes)
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
                if (this.Authorities != null)
                    hashCode = hashCode * 59 + this.Authorities.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                hashCode = hashCode * 59 + this.Authenticated.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TokenAttributes != null)
                    hashCode = hashCode * 59 + this.TokenAttributes.GetHashCode();
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