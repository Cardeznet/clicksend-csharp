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
    /// AccountForgotPasswordVerify
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class AccountForgotPasswordVerify :  IEquatable<AccountForgotPasswordVerify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountForgotPasswordVerify" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountForgotPasswordVerify() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountForgotPasswordVerify" /> class.
        /// </summary>
        /// <param name="subaccountId">ID of subaccount (required).</param>
        /// <param name="activationToken">Activation token (required).</param>
        /// <param name="password">Password (required).</param>
        public AccountForgotPasswordVerify(int? subaccountId = default(int?), string activationToken = default(string), string password = default(string))
        {
            // to ensure "subaccountId" is required (not null)
            if (subaccountId == null)
            {
                throw new InvalidDataException("subaccountId is a required property for AccountForgotPasswordVerify and cannot be null");
            }
            else
            {
                this.SubaccountId = subaccountId;
            }
            // to ensure "activationToken" is required (not null)
            if (activationToken == null)
            {
                throw new InvalidDataException("activationToken is a required property for AccountForgotPasswordVerify and cannot be null");
            }
            else
            {
                this.ActivationToken = activationToken;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for AccountForgotPasswordVerify and cannot be null");
            }
            else
            {
                this.Password = password;
            }
        }
        
        /// <summary>
        /// ID of subaccount
        /// </summary>
        /// <value>ID of subaccount</value>
        [DataMember(Name="subaccount_id", EmitDefaultValue=false)]
        public int? SubaccountId { get; set; }

        /// <summary>
        /// Activation token
        /// </summary>
        /// <value>Activation token</value>
        [DataMember(Name="activation_token", EmitDefaultValue=false)]
        public string ActivationToken { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountForgotPasswordVerify {\n");
            sb.Append("  SubaccountId: ").Append(SubaccountId).Append("\n");
            sb.Append("  ActivationToken: ").Append(ActivationToken).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as AccountForgotPasswordVerify);
        }

        /// <summary>
        /// Returns true if AccountForgotPasswordVerify instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountForgotPasswordVerify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountForgotPasswordVerify input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubaccountId == input.SubaccountId ||
                    (this.SubaccountId != null &&
                    this.SubaccountId.Equals(input.SubaccountId))
                ) && 
                (
                    this.ActivationToken == input.ActivationToken ||
                    (this.ActivationToken != null &&
                    this.ActivationToken.Equals(input.ActivationToken))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.SubaccountId != null)
                    hashCode = hashCode * 59 + this.SubaccountId.GetHashCode();
                if (this.ActivationToken != null)
                    hashCode = hashCode * 59 + this.ActivationToken.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
