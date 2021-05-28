/* 
 * Openbots Documents Connector API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = OpenBots.Server.SDK.Client.SwaggerDateConverter;

namespace OpenBots.Server.SDK.Model
{
    /// <summary>
    /// SwitchedAccountAuthenticateResultModel
    /// </summary>
    [DataContract]
        public partial class SwitchedAccountAuthenticateResultModel :  IEquatable<SwitchedAccountAuthenticateResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchedAccountAuthenticateResultModel" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="encryptedAccessToken">encryptedAccessToken.</param>
        /// <param name="expireInSeconds">expireInSeconds.</param>
        public SwitchedAccountAuthenticateResultModel(string accessToken = default(string), string encryptedAccessToken = default(string), int? expireInSeconds = default(int?))
        {
            this.AccessToken = accessToken;
            this.EncryptedAccessToken = encryptedAccessToken;
            this.ExpireInSeconds = expireInSeconds;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets EncryptedAccessToken
        /// </summary>
        [DataMember(Name="encryptedAccessToken", EmitDefaultValue=false)]
        public string EncryptedAccessToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpireInSeconds
        /// </summary>
        [DataMember(Name="expireInSeconds", EmitDefaultValue=false)]
        public int? ExpireInSeconds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchedAccountAuthenticateResultModel {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  EncryptedAccessToken: ").Append(EncryptedAccessToken).Append("\n");
            sb.Append("  ExpireInSeconds: ").Append(ExpireInSeconds).Append("\n");
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
            return this.Equals(input as SwitchedAccountAuthenticateResultModel);
        }

        /// <summary>
        /// Returns true if SwitchedAccountAuthenticateResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SwitchedAccountAuthenticateResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SwitchedAccountAuthenticateResultModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.EncryptedAccessToken == input.EncryptedAccessToken ||
                    (this.EncryptedAccessToken != null &&
                    this.EncryptedAccessToken.Equals(input.EncryptedAccessToken))
                ) && 
                (
                    this.ExpireInSeconds == input.ExpireInSeconds ||
                    (this.ExpireInSeconds != null &&
                    this.ExpireInSeconds.Equals(input.ExpireInSeconds))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.EncryptedAccessToken != null)
                    hashCode = hashCode * 59 + this.EncryptedAccessToken.GetHashCode();
                if (this.ExpireInSeconds != null)
                    hashCode = hashCode * 59 + this.ExpireInSeconds.GetHashCode();
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