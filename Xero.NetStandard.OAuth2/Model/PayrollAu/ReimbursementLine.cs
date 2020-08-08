/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.11
 * Contact: api@xero.com
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// ReimbursementLine
    /// </summary>
    [DataContract]
    public partial class ReimbursementLine :  IEquatable<ReimbursementLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero reimbursement type identifier
        /// </summary>
        /// <value>Xero reimbursement type identifier</value>
        [DataMember(Name="ReimbursementTypeID", EmitDefaultValue=false)]
        public Guid? ReimbursementTypeID { get; set; }

        /// <summary>
        /// Reimbursement type amount
        /// </summary>
        /// <value>Reimbursement type amount</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Reimbursement lines description (max length 50)
        /// </summary>
        /// <value>Reimbursement lines description (max length 50)</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Reimbursement expense account. For posted pay run you should be able to see expense account code.
        /// </summary>
        /// <value>Reimbursement expense account. For posted pay run you should be able to see expense account code.</value>
        [DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
        public string ExpenseAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReimbursementLine {\n");
            sb.Append("  ReimbursementTypeID: ").Append(ReimbursementTypeID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpenseAccount: ").Append(ExpenseAccount).Append("\n");
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
            return this.Equals(input as ReimbursementLine);
        }

        /// <summary>
        /// Returns true if ReimbursementLine instances are equal
        /// </summary>
        /// <param name="input">Instance of ReimbursementLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReimbursementLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReimbursementTypeID == input.ReimbursementTypeID ||
                    (this.ReimbursementTypeID != null &&
                    this.ReimbursementTypeID.Equals(input.ReimbursementTypeID))
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExpenseAccount == input.ExpenseAccount ||
                    (this.ExpenseAccount != null &&
                    this.ExpenseAccount.Equals(input.ExpenseAccount))
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
                if (this.ReimbursementTypeID != null)
                    hashCode = hashCode * 59 + this.ReimbursementTypeID.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpenseAccount != null)
                    hashCode = hashCode * 59 + this.ExpenseAccount.GetHashCode();
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
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 50.", new [] { "Description" });
            }

            yield break;
        }
    }

}
