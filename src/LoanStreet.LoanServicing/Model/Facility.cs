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
        /// <param name="name">name.</param>
        /// <param name="timeZoneId">timeZoneId.</param>
        /// <param name="institutions">institutions (required).</param>
        /// <param name="tranches">tranches (required).</param>
        /// <param name="borrowings">borrowings (required).</param>
        public Facility(string name = default(string), string timeZoneId = default(string), List<FacilityInstitutionDto> institutions = default(List<FacilityInstitutionDto>), List<Tranche> tranches = default(List<Tranche>), List<Borrowing> borrowings = default(List<Borrowing>))
        {
            // to ensure "institutions" is required (not null)
            this.Institutions = institutions ?? throw new ArgumentNullException("institutions is a required property for Facility and cannot be null");;
            // to ensure "tranches" is required (not null)
            this.Tranches = tranches ?? throw new ArgumentNullException("tranches is a required property for Facility and cannot be null");;
            // to ensure "borrowings" is required (not null)
            this.Borrowings = borrowings ?? throw new ArgumentNullException("borrowings is a required property for Facility and cannot be null");;
            this.Name = name;
            this.TimeZoneId = timeZoneId;
        }
        
        /// <summary>
        /// Gets or Sets FacilityId
        /// </summary>
        [DataMember(Name="facilityId", EmitDefaultValue=false)]
        public string FacilityId { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TimeZoneId
        /// </summary>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or Sets Institutions
        /// </summary>
        [DataMember(Name="institutions", EmitDefaultValue=false)]
        public List<FacilityInstitutionDto> Institutions { get; set; }

        /// <summary>
        /// Gets or Sets Tranches
        /// </summary>
        [DataMember(Name="tranches", EmitDefaultValue=false)]
        public List<Tranche> Tranches { get; set; }

        /// <summary>
        /// Gets or Sets Borrowings
        /// </summary>
        [DataMember(Name="borrowings", EmitDefaultValue=false)]
        public List<Borrowing> Borrowings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Facility {\n");
            sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  Institutions: ").Append(Institutions).Append("\n");
            sb.Append("  Tranches: ").Append(Tranches).Append("\n");
            sb.Append("  Borrowings: ").Append(Borrowings).Append("\n");
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
                    this.FacilityId == input.FacilityId ||
                    (this.FacilityId != null &&
                    this.FacilityId.Equals(input.FacilityId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TimeZoneId == input.TimeZoneId ||
                    (this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(input.TimeZoneId))
                ) && 
                (
                    this.Institutions == input.Institutions ||
                    this.Institutions != null &&
                    input.Institutions != null &&
                    this.Institutions.SequenceEqual(input.Institutions)
                ) && 
                (
                    this.Tranches == input.Tranches ||
                    this.Tranches != null &&
                    input.Tranches != null &&
                    this.Tranches.SequenceEqual(input.Tranches)
                ) && 
                (
                    this.Borrowings == input.Borrowings ||
                    this.Borrowings != null &&
                    input.Borrowings != null &&
                    this.Borrowings.SequenceEqual(input.Borrowings)
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
                if (this.FacilityId != null)
                    hashCode = hashCode * 59 + this.FacilityId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TimeZoneId != null)
                    hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                if (this.Institutions != null)
                    hashCode = hashCode * 59 + this.Institutions.GetHashCode();
                if (this.Tranches != null)
                    hashCode = hashCode * 59 + this.Tranches.GetHashCode();
                if (this.Borrowings != null)
                    hashCode = hashCode * 59 + this.Borrowings.GetHashCode();
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
