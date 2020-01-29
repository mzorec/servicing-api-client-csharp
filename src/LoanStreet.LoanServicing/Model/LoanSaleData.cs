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
    /// LoanSaleData
    /// </summary>
    [DataContract]
    public partial class LoanSaleData :  IEquatable<LoanSaleData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanSaleData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoanSaleData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanSaleData" /> class.
        /// </summary>
        /// <param name="sellerId">sellerId (required).</param>
        /// <param name="buyerId">buyerId (required).</param>
        /// <param name="daysDelinquent">daysDelinquent (required).</param>
        /// <param name="principal">principal (required).</param>
        /// <param name="ownership">ownership (required).</param>
        /// <param name="percentOfPar">percentOfPar (required).</param>
        /// <param name="poolId">poolId (required).</param>
        /// <param name="fullAccruedInterest">fullAccruedInterest (required).</param>
        /// <param name="saleDate">saleDate (required).</param>
        /// <param name="syndicationDate">syndicationDate (required).</param>
        /// <param name="servicingSpread">servicingSpread (required).</param>
        public LoanSaleData(string sellerId = default(string), string buyerId = default(string), int daysDelinquent = default(int), Money principal = default(Money), string ownership = default(string), string percentOfPar = default(string), string poolId = default(string), Money fullAccruedInterest = default(Money), long saleDate = default(long), long syndicationDate = default(long), string servicingSpread = default(string))
        {
            // to ensure "sellerId" is required (not null)
            if (sellerId == null)
            {
                throw new InvalidDataException("sellerId is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.SellerId = sellerId;
            }

            // to ensure "buyerId" is required (not null)
            if (buyerId == null)
            {
                throw new InvalidDataException("buyerId is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.BuyerId = buyerId;
            }

            // to ensure "daysDelinquent" is required (not null)
            if (daysDelinquent == null)
            {
                throw new InvalidDataException("daysDelinquent is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.DaysDelinquent = daysDelinquent;
            }

            // to ensure "principal" is required (not null)
            if (principal == null)
            {
                throw new InvalidDataException("principal is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.Principal = principal;
            }

            // to ensure "ownership" is required (not null)
            if (ownership == null)
            {
                throw new InvalidDataException("ownership is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.Ownership = ownership;
            }

            // to ensure "percentOfPar" is required (not null)
            if (percentOfPar == null)
            {
                throw new InvalidDataException("percentOfPar is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.PercentOfPar = percentOfPar;
            }

            // to ensure "poolId" is required (not null)
            if (poolId == null)
            {
                throw new InvalidDataException("poolId is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.PoolId = poolId;
            }

            // to ensure "fullAccruedInterest" is required (not null)
            if (fullAccruedInterest == null)
            {
                throw new InvalidDataException("fullAccruedInterest is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.FullAccruedInterest = fullAccruedInterest;
            }

            // to ensure "saleDate" is required (not null)
            if (saleDate == null)
            {
                throw new InvalidDataException("saleDate is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.SaleDate = saleDate;
            }

            // to ensure "syndicationDate" is required (not null)
            if (syndicationDate == null)
            {
                throw new InvalidDataException("syndicationDate is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.SyndicationDate = syndicationDate;
            }

            // to ensure "servicingSpread" is required (not null)
            if (servicingSpread == null)
            {
                throw new InvalidDataException("servicingSpread is a required property for LoanSaleData and cannot be null");
            }
            else
            {
                this.ServicingSpread = servicingSpread;
            }

        }
        
        /// <summary>
        /// Gets or Sets SellerId
        /// </summary>
        [DataMember(Name="sellerId", EmitDefaultValue=false)]
        public string SellerId { get; set; }

        /// <summary>
        /// Gets or Sets BuyerId
        /// </summary>
        [DataMember(Name="buyerId", EmitDefaultValue=false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// Gets or Sets DaysDelinquent
        /// </summary>
        [DataMember(Name="daysDelinquent", EmitDefaultValue=false)]
        public int DaysDelinquent { get; set; }

        /// <summary>
        /// Gets or Sets Principal
        /// </summary>
        [DataMember(Name="principal", EmitDefaultValue=false)]
        public Money Principal { get; set; }

        /// <summary>
        /// Gets or Sets Ownership
        /// </summary>
        [DataMember(Name="ownership", EmitDefaultValue=false)]
        public string Ownership { get; set; }

        /// <summary>
        /// Gets or Sets PercentOfPar
        /// </summary>
        [DataMember(Name="percentOfPar", EmitDefaultValue=false)]
        public string PercentOfPar { get; set; }

        /// <summary>
        /// Gets or Sets PoolId
        /// </summary>
        [DataMember(Name="poolId", EmitDefaultValue=false)]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or Sets FullAccruedInterest
        /// </summary>
        [DataMember(Name="fullAccruedInterest", EmitDefaultValue=false)]
        public Money FullAccruedInterest { get; set; }

        /// <summary>
        /// Gets or Sets SaleDate
        /// </summary>
        [DataMember(Name="saleDate", EmitDefaultValue=false)]
        public long SaleDate { get; set; }

        /// <summary>
        /// Gets or Sets SyndicationDate
        /// </summary>
        [DataMember(Name="syndicationDate", EmitDefaultValue=false)]
        public long SyndicationDate { get; set; }

        /// <summary>
        /// Gets or Sets ServicingSpread
        /// </summary>
        [DataMember(Name="servicingSpread", EmitDefaultValue=false)]
        public string ServicingSpread { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanSaleData {\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  DaysDelinquent: ").Append(DaysDelinquent).Append("\n");
            sb.Append("  Principal: ").Append(Principal).Append("\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
            sb.Append("  PercentOfPar: ").Append(PercentOfPar).Append("\n");
            sb.Append("  PoolId: ").Append(PoolId).Append("\n");
            sb.Append("  FullAccruedInterest: ").Append(FullAccruedInterest).Append("\n");
            sb.Append("  SaleDate: ").Append(SaleDate).Append("\n");
            sb.Append("  SyndicationDate: ").Append(SyndicationDate).Append("\n");
            sb.Append("  ServicingSpread: ").Append(ServicingSpread).Append("\n");
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
            return this.Equals(input as LoanSaleData);
        }

        /// <summary>
        /// Returns true if LoanSaleData instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanSaleData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanSaleData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) && 
                (
                    this.DaysDelinquent == input.DaysDelinquent ||
                    this.DaysDelinquent.Equals(input.DaysDelinquent)
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.Ownership == input.Ownership ||
                    (this.Ownership != null &&
                    this.Ownership.Equals(input.Ownership))
                ) && 
                (
                    this.PercentOfPar == input.PercentOfPar ||
                    (this.PercentOfPar != null &&
                    this.PercentOfPar.Equals(input.PercentOfPar))
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.FullAccruedInterest == input.FullAccruedInterest ||
                    (this.FullAccruedInterest != null &&
                    this.FullAccruedInterest.Equals(input.FullAccruedInterest))
                ) && 
                (
                    this.SaleDate == input.SaleDate ||
                    this.SaleDate.Equals(input.SaleDate)
                ) && 
                (
                    this.SyndicationDate == input.SyndicationDate ||
                    this.SyndicationDate.Equals(input.SyndicationDate)
                ) && 
                (
                    this.ServicingSpread == input.ServicingSpread ||
                    (this.ServicingSpread != null &&
                    this.ServicingSpread.Equals(input.ServicingSpread))
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
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.BuyerId != null)
                    hashCode = hashCode * 59 + this.BuyerId.GetHashCode();
                hashCode = hashCode * 59 + this.DaysDelinquent.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.Ownership != null)
                    hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                if (this.PercentOfPar != null)
                    hashCode = hashCode * 59 + this.PercentOfPar.GetHashCode();
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.FullAccruedInterest != null)
                    hashCode = hashCode * 59 + this.FullAccruedInterest.GetHashCode();
                hashCode = hashCode * 59 + this.SaleDate.GetHashCode();
                hashCode = hashCode * 59 + this.SyndicationDate.GetHashCode();
                if (this.ServicingSpread != null)
                    hashCode = hashCode * 59 + this.ServicingSpread.GetHashCode();
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
