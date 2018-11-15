/* 
 * ClickSend v3 REST API
 *
 *  This is the official [ClickSend](https://clicksend.com) SDK.  *You'll need to create a free account to use the API. You can register [here](https://www.clicksend.com/signup).*  You can use our API documentation along with the SDK. Our API docs can be found [here](https://developers.clicksend.com). 
 *
 * OpenAPI spec version: 3.1.0
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using ClickSendDateConverter = IO.ClickSend.Client.ClickSendDateConverter;

namespace IO.ClickSend.ClickSend.Model
{
    /// <summary>
    /// PostRecipient model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class PostRecipient :  IEquatable<PostRecipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostRecipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostRecipient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostRecipient" /> class.
        /// </summary>
        /// <param name="addressName">Name of address (required).</param>
        /// <param name="addressLine1">First line of address (required).</param>
        /// <param name="addressLine2">Second line of address (required).</param>
        /// <param name="addressCity">City (required).</param>
        /// <param name="addressState">State (required).</param>
        /// <param name="addressPostalCode">Postal code (required).</param>
        /// <param name="addressCountry">Country (required).</param>
        /// <param name="returnAddressId">ID of return address to use (required).</param>
        /// <param name="schedule">When to send letter (0/null&#x3D;now) (default to 0).</param>
        public PostRecipient(string addressName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressCity = default(string), string addressState = default(string), string addressPostalCode = default(string), string addressCountry = default(string), int? returnAddressId = default(int?), int? schedule = 0)
        {
            // to ensure "addressName" is required (not null)
            if (addressName == null)
            {
                throw new InvalidDataException("addressName is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressName = addressName;
            }
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new InvalidDataException("addressLine1 is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressLine1 = addressLine1;
            }
            // to ensure "addressLine2" is required (not null)
            if (addressLine2 == null)
            {
                throw new InvalidDataException("addressLine2 is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressLine2 = addressLine2;
            }
            // to ensure "addressCity" is required (not null)
            if (addressCity == null)
            {
                throw new InvalidDataException("addressCity is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressCity = addressCity;
            }
            // to ensure "addressState" is required (not null)
            if (addressState == null)
            {
                throw new InvalidDataException("addressState is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressState = addressState;
            }
            // to ensure "addressPostalCode" is required (not null)
            if (addressPostalCode == null)
            {
                throw new InvalidDataException("addressPostalCode is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressPostalCode = addressPostalCode;
            }
            // to ensure "addressCountry" is required (not null)
            if (addressCountry == null)
            {
                throw new InvalidDataException("addressCountry is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.AddressCountry = addressCountry;
            }
            // to ensure "returnAddressId" is required (not null)
            if (returnAddressId == null)
            {
                throw new InvalidDataException("returnAddressId is a required property for PostRecipient and cannot be null");
            }
            else
            {
                this.ReturnAddressId = returnAddressId;
            }
            // use default value if no "schedule" provided
            if (schedule == null)
            {
                this.Schedule = 0;
            }
            else
            {
                this.Schedule = schedule;
            }
        }
        
        /// <summary>
        /// Name of address
        /// </summary>
        /// <value>Name of address</value>
        [DataMember(Name="address_name", EmitDefaultValue=false)]
        public string AddressName { get; set; }

        /// <summary>
        /// First line of address
        /// </summary>
        /// <value>First line of address</value>
        [DataMember(Name="address_line_1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of address
        /// </summary>
        /// <value>Second line of address</value>
        [DataMember(Name="address_line_2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="address_city", EmitDefaultValue=false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="address_state", EmitDefaultValue=false)]
        public string AddressState { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        [DataMember(Name="address_postal_code", EmitDefaultValue=false)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="address_country", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }

        /// <summary>
        /// ID of return address to use
        /// </summary>
        /// <value>ID of return address to use</value>
        [DataMember(Name="return_address_id", EmitDefaultValue=false)]
        public int? ReturnAddressId { get; set; }

        /// <summary>
        /// When to send letter (0/null&#x3D;now)
        /// </summary>
        /// <value>When to send letter (0/null&#x3D;now)</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostRecipient {\n");
            sb.Append("  AddressName: ").Append(AddressName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressPostalCode: ").Append(AddressPostalCode).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  ReturnAddressId: ").Append(ReturnAddressId).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as PostRecipient);
        }

        /// <summary>
        /// Returns true if PostRecipient instances are equal
        /// </summary>
        /// <param name="input">Instance of PostRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostRecipient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressName == input.AddressName ||
                    (this.AddressName != null &&
                    this.AddressName.Equals(input.AddressName))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressState == input.AddressState ||
                    (this.AddressState != null &&
                    this.AddressState.Equals(input.AddressState))
                ) && 
                (
                    this.AddressPostalCode == input.AddressPostalCode ||
                    (this.AddressPostalCode != null &&
                    this.AddressPostalCode.Equals(input.AddressPostalCode))
                ) && 
                (
                    this.AddressCountry == input.AddressCountry ||
                    (this.AddressCountry != null &&
                    this.AddressCountry.Equals(input.AddressCountry))
                ) && 
                (
                    this.ReturnAddressId == input.ReturnAddressId ||
                    (this.ReturnAddressId != null &&
                    this.ReturnAddressId.Equals(input.ReturnAddressId))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.AddressName != null)
                    hashCode = hashCode * 59 + this.AddressName.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressState != null)
                    hashCode = hashCode * 59 + this.AddressState.GetHashCode();
                if (this.AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AddressPostalCode.GetHashCode();
                if (this.AddressCountry != null)
                    hashCode = hashCode * 59 + this.AddressCountry.GetHashCode();
                if (this.ReturnAddressId != null)
                    hashCode = hashCode * 59 + this.ReturnAddressId.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
