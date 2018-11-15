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
    /// Post direct mail model
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class PostDirectMail :  IEquatable<PostDirectMail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDirectMail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostDirectMail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDirectMail" /> class.
        /// </summary>
        /// <param name="name">Campaign name (required).</param>
        /// <param name="fileUrls">Campaign file URLs (maximum 2) (required).</param>
        /// <param name="size">Document size - A5 or DL (required).</param>
        /// <param name="areas">PostDirectMailArea model (required).</param>
        /// <param name="schedule">Leave blank for immediate delivery. Your schedule time in unix format. (default to 0).</param>
        /// <param name="source">Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;. (default to &quot;sdk&quot;).</param>
        /// <param name="customString">A custom string for your own reference.</param>
        public PostDirectMail(string name = default(string), List<string> fileUrls = default(List<string>), string size = default(string), List<PostDirectMailArea> areas = default(List<PostDirectMailArea>), int? schedule = 0, string source = "sdk", string customString = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PostDirectMail and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "fileUrls" is required (not null)
            if (fileUrls == null)
            {
                throw new InvalidDataException("fileUrls is a required property for PostDirectMail and cannot be null");
            }
            else
            {
                this.FileUrls = fileUrls;
            }
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new InvalidDataException("size is a required property for PostDirectMail and cannot be null");
            }
            else
            {
                this.Size = size;
            }
            // to ensure "areas" is required (not null)
            if (areas == null)
            {
                throw new InvalidDataException("areas is a required property for PostDirectMail and cannot be null");
            }
            else
            {
                this.Areas = areas;
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
            // use default value if no "source" provided
            if (source == null)
            {
                this.Source = "sdk";
            }
            else
            {
                this.Source = source;
            }
            this.CustomString = customString;
        }
        
        /// <summary>
        /// Campaign name
        /// </summary>
        /// <value>Campaign name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Campaign file URLs (maximum 2)
        /// </summary>
        /// <value>Campaign file URLs (maximum 2)</value>
        [DataMember(Name="file_urls", EmitDefaultValue=false)]
        public List<string> FileUrls { get; set; }

        /// <summary>
        /// Document size - A5 or DL
        /// </summary>
        /// <value>Document size - A5 or DL</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }

        /// <summary>
        /// PostDirectMailArea model
        /// </summary>
        /// <value>PostDirectMailArea model</value>
        [DataMember(Name="areas", EmitDefaultValue=false)]
        public List<PostDirectMailArea> Areas { get; set; }

        /// <summary>
        /// Leave blank for immediate delivery. Your schedule time in unix format.
        /// </summary>
        /// <value>Leave blank for immediate delivery. Your schedule time in unix format.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;.
        /// </summary>
        /// <value>Your method of sending e.g. &#39;wordpress&#39;, &#39;php&#39;, &#39;c#&#39;.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// A custom string for your own reference
        /// </summary>
        /// <value>A custom string for your own reference</value>
        [DataMember(Name="custom_string", EmitDefaultValue=false)]
        public string CustomString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostDirectMail {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FileUrls: ").Append(FileUrls).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CustomString: ").Append(CustomString).Append("\n");
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
            return this.Equals(input as PostDirectMail);
        }

        /// <summary>
        /// Returns true if PostDirectMail instances are equal
        /// </summary>
        /// <param name="input">Instance of PostDirectMail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostDirectMail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FileUrls == input.FileUrls ||
                    this.FileUrls != null &&
                    this.FileUrls.SequenceEqual(input.FileUrls)
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Areas == input.Areas ||
                    this.Areas != null &&
                    this.Areas.SequenceEqual(input.Areas)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.CustomString == input.CustomString ||
                    (this.CustomString != null &&
                    this.CustomString.Equals(input.CustomString))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FileUrls != null)
                    hashCode = hashCode * 59 + this.FileUrls.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Areas != null)
                    hashCode = hashCode * 59 + this.Areas.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.CustomString != null)
                    hashCode = hashCode * 59 + this.CustomString.GetHashCode();
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
