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
    /// SmsMessage model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class SmsMessage :  IEquatable<SmsMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMessage" /> class.
        /// </summary>
        /// <param name="from">Your sender id - more info: http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number..</param>
        /// <param name="body">Your message. (required).</param>
        /// <param name="to">Recipient phone number in E.164 format. (required).</param>
        /// <param name="source">Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;. (default to &quot;sdk&quot;).</param>
        /// <param name="schedule">Leave blank for immediate delivery. Your schedule time in unix format http://help.clicksend.com/what-is-a-unix-timestamp (default to 0).</param>
        /// <param name="customString">Your reference. Will be passed back with all replies and delivery reports..</param>
        /// <param name="listId">Your list ID if sending to a whole list. Can be used instead of &#39;to&#39;..</param>
        /// <param name="country">Recipient country..</param>
        /// <param name="fromEmail">An email address where the reply should be emailed to. If omitted, the reply will be emailed back to the user who sent the outgoing SMS..</param>
        public SmsMessage(string from = default(string), string body = default(string), string to = default(string), string source = "sdk", int? schedule = 0, string customString = default(string), int? listId = default(int?), string country = default(string), string fromEmail = default(string))
        {
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for SmsMessage and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for SmsMessage and cannot be null");
            }
            else
            {
                this.To = to;
            }
            this.From = from;
            // use default value if no "source" provided
            if (source == null)
            {
                this.Source = "sdk";
            }
            else
            {
                this.Source = source;
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
            this.CustomString = customString;
            this.ListId = listId;
            this.Country = country;
            this.FromEmail = fromEmail;
        }
        
        /// <summary>
        /// Your sender id - more info: http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number.
        /// </summary>
        /// <value>Your sender id - more info: http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// Your message.
        /// </summary>
        /// <value>Your message.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Recipient phone number in E.164 format.
        /// </summary>
        /// <value>Recipient phone number in E.164 format.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;.
        /// </summary>
        /// <value>Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Leave blank for immediate delivery. Your schedule time in unix format http://help.clicksend.com/what-is-a-unix-timestamp
        /// </summary>
        /// <value>Leave blank for immediate delivery. Your schedule time in unix format http://help.clicksend.com/what-is-a-unix-timestamp</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Your reference. Will be passed back with all replies and delivery reports.
        /// </summary>
        /// <value>Your reference. Will be passed back with all replies and delivery reports.</value>
        [DataMember(Name="custom_string", EmitDefaultValue=false)]
        public string CustomString { get; set; }

        /// <summary>
        /// Your list ID if sending to a whole list. Can be used instead of &#39;to&#39;.
        /// </summary>
        /// <value>Your list ID if sending to a whole list. Can be used instead of &#39;to&#39;.</value>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public int? ListId { get; set; }

        /// <summary>
        /// Recipient country.
        /// </summary>
        /// <value>Recipient country.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// An email address where the reply should be emailed to. If omitted, the reply will be emailed back to the user who sent the outgoing SMS.
        /// </summary>
        /// <value>An email address where the reply should be emailed to. If omitted, the reply will be emailed back to the user who sent the outgoing SMS.</value>
        [DataMember(Name="from_email", EmitDefaultValue=false)]
        public string FromEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsMessage {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  CustomString: ").Append(CustomString).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  FromEmail: ").Append(FromEmail).Append("\n");
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
            return this.Equals(input as SmsMessage);
        }

        /// <summary>
        /// Returns true if SmsMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.CustomString == input.CustomString ||
                    (this.CustomString != null &&
                    this.CustomString.Equals(input.CustomString))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.FromEmail == input.FromEmail ||
                    (this.FromEmail != null &&
                    this.FromEmail.Equals(input.FromEmail))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.CustomString != null)
                    hashCode = hashCode * 59 + this.CustomString.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.FromEmail != null)
                    hashCode = hashCode * 59 + this.FromEmail.GetHashCode();
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
