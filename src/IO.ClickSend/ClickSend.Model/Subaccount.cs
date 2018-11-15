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
    /// Accounts that are maintained under a main account
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class Subaccount :  IEquatable<Subaccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subaccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subaccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subaccount" /> class.
        /// </summary>
        /// <param name="apiUsername">Your new api username. (required).</param>
        /// <param name="password">Your new password (required).</param>
        /// <param name="email">Your new email. (required).</param>
        /// <param name="phoneNumber">Your phone number in E.164 format. (required).</param>
        /// <param name="firstName">Your firstname (required).</param>
        /// <param name="lastName">Your lastname (required).</param>
        /// <param name="accessUsers">Your access users flag value, must be 1 or 0. (default to 1).</param>
        /// <param name="accessBilling">Your access billing flag value, must be 1 or 0. (default to 1).</param>
        /// <param name="accessReporting">Your access reporting flag value, must be 1 or 0. (default to 1).</param>
        /// <param name="accessContacts">Your access contacts flag value, must be 1 or 0. (default to 0).</param>
        /// <param name="accessSettings">Your access settings flag value, must be 1 or 0. (default to 1).</param>
        public Subaccount(string apiUsername = default(string), string password = default(string), string email = default(string), string phoneNumber = default(string), string firstName = default(string), string lastName = default(string), int? accessUsers = 1, int? accessBilling = 1, int? accessReporting = 1, int? accessContacts = 0, int? accessSettings = 1)
        {
            // to ensure "apiUsername" is required (not null)
            if (apiUsername == null)
            {
                throw new InvalidDataException("apiUsername is a required property for Subaccount and cannot be null");
            }
            else
            {
                this.ApiUsername = apiUsername;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for Subaccount and cannot be null");
            }
            else
            {
                this.Password = password;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for Subaccount and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "phoneNumber" is required (not null)
            if (phoneNumber == null)
            {
                throw new InvalidDataException("phoneNumber is a required property for Subaccount and cannot be null");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
            }
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for Subaccount and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for Subaccount and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }
            // use default value if no "accessUsers" provided
            if (accessUsers == null)
            {
                this.AccessUsers = 1;
            }
            else
            {
                this.AccessUsers = accessUsers;
            }
            // use default value if no "accessBilling" provided
            if (accessBilling == null)
            {
                this.AccessBilling = 1;
            }
            else
            {
                this.AccessBilling = accessBilling;
            }
            // use default value if no "accessReporting" provided
            if (accessReporting == null)
            {
                this.AccessReporting = 1;
            }
            else
            {
                this.AccessReporting = accessReporting;
            }
            // use default value if no "accessContacts" provided
            if (accessContacts == null)
            {
                this.AccessContacts = 0;
            }
            else
            {
                this.AccessContacts = accessContacts;
            }
            // use default value if no "accessSettings" provided
            if (accessSettings == null)
            {
                this.AccessSettings = 1;
            }
            else
            {
                this.AccessSettings = accessSettings;
            }
        }
        
        /// <summary>
        /// Your new api username.
        /// </summary>
        /// <value>Your new api username.</value>
        [DataMember(Name="api_username", EmitDefaultValue=false)]
        public string ApiUsername { get; set; }

        /// <summary>
        /// Your new password
        /// </summary>
        /// <value>Your new password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Your new email.
        /// </summary>
        /// <value>Your new email.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Your phone number in E.164 format.
        /// </summary>
        /// <value>Your phone number in E.164 format.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Your firstname
        /// </summary>
        /// <value>Your firstname</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Your lastname
        /// </summary>
        /// <value>Your lastname</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Your access users flag value, must be 1 or 0.
        /// </summary>
        /// <value>Your access users flag value, must be 1 or 0.</value>
        [DataMember(Name="access_users", EmitDefaultValue=false)]
        public int? AccessUsers { get; set; }

        /// <summary>
        /// Your access billing flag value, must be 1 or 0.
        /// </summary>
        /// <value>Your access billing flag value, must be 1 or 0.</value>
        [DataMember(Name="access_billing", EmitDefaultValue=false)]
        public int? AccessBilling { get; set; }

        /// <summary>
        /// Your access reporting flag value, must be 1 or 0.
        /// </summary>
        /// <value>Your access reporting flag value, must be 1 or 0.</value>
        [DataMember(Name="access_reporting", EmitDefaultValue=false)]
        public int? AccessReporting { get; set; }

        /// <summary>
        /// Your access contacts flag value, must be 1 or 0.
        /// </summary>
        /// <value>Your access contacts flag value, must be 1 or 0.</value>
        [DataMember(Name="access_contacts", EmitDefaultValue=false)]
        public int? AccessContacts { get; set; }

        /// <summary>
        /// Your access settings flag value, must be 1 or 0.
        /// </summary>
        /// <value>Your access settings flag value, must be 1 or 0.</value>
        [DataMember(Name="access_settings", EmitDefaultValue=false)]
        public int? AccessSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subaccount {\n");
            sb.Append("  ApiUsername: ").Append(ApiUsername).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  AccessUsers: ").Append(AccessUsers).Append("\n");
            sb.Append("  AccessBilling: ").Append(AccessBilling).Append("\n");
            sb.Append("  AccessReporting: ").Append(AccessReporting).Append("\n");
            sb.Append("  AccessContacts: ").Append(AccessContacts).Append("\n");
            sb.Append("  AccessSettings: ").Append(AccessSettings).Append("\n");
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
            return this.Equals(input as Subaccount);
        }

        /// <summary>
        /// Returns true if Subaccount instances are equal
        /// </summary>
        /// <param name="input">Instance of Subaccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subaccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiUsername == input.ApiUsername ||
                    (this.ApiUsername != null &&
                    this.ApiUsername.Equals(input.ApiUsername))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.AccessUsers == input.AccessUsers ||
                    (this.AccessUsers != null &&
                    this.AccessUsers.Equals(input.AccessUsers))
                ) && 
                (
                    this.AccessBilling == input.AccessBilling ||
                    (this.AccessBilling != null &&
                    this.AccessBilling.Equals(input.AccessBilling))
                ) && 
                (
                    this.AccessReporting == input.AccessReporting ||
                    (this.AccessReporting != null &&
                    this.AccessReporting.Equals(input.AccessReporting))
                ) && 
                (
                    this.AccessContacts == input.AccessContacts ||
                    (this.AccessContacts != null &&
                    this.AccessContacts.Equals(input.AccessContacts))
                ) && 
                (
                    this.AccessSettings == input.AccessSettings ||
                    (this.AccessSettings != null &&
                    this.AccessSettings.Equals(input.AccessSettings))
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
                if (this.ApiUsername != null)
                    hashCode = hashCode * 59 + this.ApiUsername.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.AccessUsers != null)
                    hashCode = hashCode * 59 + this.AccessUsers.GetHashCode();
                if (this.AccessBilling != null)
                    hashCode = hashCode * 59 + this.AccessBilling.GetHashCode();
                if (this.AccessReporting != null)
                    hashCode = hashCode * 59 + this.AccessReporting.GetHashCode();
                if (this.AccessContacts != null)
                    hashCode = hashCode * 59 + this.AccessContacts.GetHashCode();
                if (this.AccessSettings != null)
                    hashCode = hashCode * 59 + this.AccessSettings.GetHashCode();
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
