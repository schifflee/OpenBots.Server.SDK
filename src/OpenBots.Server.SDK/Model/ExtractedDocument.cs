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
    /// ExtractedDocument
    /// </summary>
    [DataContract]
        public partial class ExtractedDocument :  IEquatable<ExtractedDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractedDocument" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="documentClassificationType">documentClassificationType.</param>
        /// <param name="isExtractedContentStructured">isExtractedContentStructured.</param>
        /// <param name="schema">schema.</param>
        /// <param name="extractedContent">extractedContent.</param>
        /// <param name="sessionID">sessionID.</param>
        /// <param name="isVerified">isVerified.</param>
        /// <param name="hasErrors">hasErrors.</param>
        /// <param name="qualityScore">qualityScore.</param>
        /// <param name="isDeletedByUser">isDeletedByUser.</param>
        /// <param name="version">version.</param>
        /// <param name="documentId">documentId.</param>
        /// <param name="isReadOnly">isReadOnly.</param>
        /// <param name="hasNewerVersion">hasNewerVersion.</param>
        /// <param name="imageBlobContainerID">imageBlobContainerID.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="updatedOn">updatedOn.</param>
        /// <param name="updatedByUser">updatedByUser.</param>
        /// <param name="isSkipped">isSkipped.</param>
        /// <param name="extractedFileId">extractedFileId.</param>
        /// <param name="extractedFileFk">extractedFileFk.</param>
        /// <param name="organizationUnitId">organizationUnitId.</param>
        /// <param name="organizationUnitFk">organizationUnitFk.</param>
        /// <param name="id">id.</param>
        public ExtractedDocument(int? tenantId = default(int?), string documentClassificationType = default(string), bool? isExtractedContentStructured = default(bool?), string schema = default(string), string extractedContent = default(string), Guid? sessionID = default(Guid?), bool? isVerified = default(bool?), bool? hasErrors = default(bool?), double? qualityScore = default(double?), bool? isDeletedByUser = default(bool?), int? version = default(int?), Guid? documentId = default(Guid?), bool? isReadOnly = default(bool?), bool? hasNewerVersion = default(bool?), Guid? imageBlobContainerID = default(Guid?), Guid? entityId = default(Guid?), DateTime? updatedOn = default(DateTime?), long? updatedByUser = default(long?), bool? isSkipped = default(bool?), Guid? extractedFileId = default(Guid?), ExtractedFile extractedFileFk = default(ExtractedFile), long? organizationUnitId = default(long?), OrganizationUnit organizationUnitFk = default(OrganizationUnit), Guid? id = default(Guid?))
        {
            this.TenantId = tenantId;
            this.DocumentClassificationType = documentClassificationType;
            this.IsExtractedContentStructured = isExtractedContentStructured;
            this.Schema = schema;
            this.ExtractedContent = extractedContent;
            this.SessionID = sessionID;
            this.IsVerified = isVerified;
            this.HasErrors = hasErrors;
            this.QualityScore = qualityScore;
            this.IsDeletedByUser = isDeletedByUser;
            this.Version = version;
            this.DocumentId = documentId;
            this.IsReadOnly = isReadOnly;
            this.HasNewerVersion = hasNewerVersion;
            this.ImageBlobContainerID = imageBlobContainerID;
            this.EntityId = entityId;
            this.UpdatedOn = updatedOn;
            this.UpdatedByUser = updatedByUser;
            this.IsSkipped = isSkipped;
            this.ExtractedFileId = extractedFileId;
            this.ExtractedFileFk = extractedFileFk;
            this.OrganizationUnitId = organizationUnitId;
            this.OrganizationUnitFk = organizationUnitFk;
            this.Id = id;
        }
        
        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentClassificationType
        /// </summary>
        [DataMember(Name="documentClassificationType", EmitDefaultValue=false)]
        public string DocumentClassificationType { get; set; }

        /// <summary>
        /// Gets or Sets IsExtractedContentStructured
        /// </summary>
        [DataMember(Name="isExtractedContentStructured", EmitDefaultValue=false)]
        public bool? IsExtractedContentStructured { get; set; }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or Sets ExtractedContent
        /// </summary>
        [DataMember(Name="extractedContent", EmitDefaultValue=false)]
        public string ExtractedContent { get; set; }

        /// <summary>
        /// Gets or Sets SessionID
        /// </summary>
        [DataMember(Name="sessionID", EmitDefaultValue=false)]
        public Guid? SessionID { get; set; }

        /// <summary>
        /// Gets or Sets IsVerified
        /// </summary>
        [DataMember(Name="isVerified", EmitDefaultValue=false)]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Gets or Sets HasErrors
        /// </summary>
        [DataMember(Name="hasErrors", EmitDefaultValue=false)]
        public bool? HasErrors { get; set; }

        /// <summary>
        /// Gets or Sets QualityScore
        /// </summary>
        [DataMember(Name="qualityScore", EmitDefaultValue=false)]
        public double? QualityScore { get; set; }

        /// <summary>
        /// Gets or Sets IsDeletedByUser
        /// </summary>
        [DataMember(Name="isDeletedByUser", EmitDefaultValue=false)]
        public bool? IsDeletedByUser { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public Guid? DocumentId { get; set; }

        /// <summary>
        /// Gets or Sets IsReadOnly
        /// </summary>
        [DataMember(Name="isReadOnly", EmitDefaultValue=false)]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets HasNewerVersion
        /// </summary>
        [DataMember(Name="hasNewerVersion", EmitDefaultValue=false)]
        public bool? HasNewerVersion { get; set; }

        /// <summary>
        /// Gets or Sets ImageBlobContainerID
        /// </summary>
        [DataMember(Name="imageBlobContainerID", EmitDefaultValue=false)]
        public Guid? ImageBlobContainerID { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public Guid? EntityId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name="updatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedByUser
        /// </summary>
        [DataMember(Name="updatedByUser", EmitDefaultValue=false)]
        public long? UpdatedByUser { get; set; }

        /// <summary>
        /// Gets or Sets IsSkipped
        /// </summary>
        [DataMember(Name="isSkipped", EmitDefaultValue=false)]
        public bool? IsSkipped { get; set; }

        /// <summary>
        /// Gets or Sets ExtractedFileId
        /// </summary>
        [DataMember(Name="extractedFileId", EmitDefaultValue=false)]
        public Guid? ExtractedFileId { get; set; }

        /// <summary>
        /// Gets or Sets ExtractedFileFk
        /// </summary>
        [DataMember(Name="extractedFileFk", EmitDefaultValue=false)]
        public ExtractedFile ExtractedFileFk { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationUnitId
        /// </summary>
        [DataMember(Name="organizationUnitId", EmitDefaultValue=false)]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationUnitFk
        /// </summary>
        [DataMember(Name="organizationUnitFk", EmitDefaultValue=false)]
        public OrganizationUnit OrganizationUnitFk { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtractedDocument {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  DocumentClassificationType: ").Append(DocumentClassificationType).Append("\n");
            sb.Append("  IsExtractedContentStructured: ").Append(IsExtractedContentStructured).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  ExtractedContent: ").Append(ExtractedContent).Append("\n");
            sb.Append("  SessionID: ").Append(SessionID).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  HasErrors: ").Append(HasErrors).Append("\n");
            sb.Append("  QualityScore: ").Append(QualityScore).Append("\n");
            sb.Append("  IsDeletedByUser: ").Append(IsDeletedByUser).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
            sb.Append("  HasNewerVersion: ").Append(HasNewerVersion).Append("\n");
            sb.Append("  ImageBlobContainerID: ").Append(ImageBlobContainerID).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  UpdatedByUser: ").Append(UpdatedByUser).Append("\n");
            sb.Append("  IsSkipped: ").Append(IsSkipped).Append("\n");
            sb.Append("  ExtractedFileId: ").Append(ExtractedFileId).Append("\n");
            sb.Append("  ExtractedFileFk: ").Append(ExtractedFileFk).Append("\n");
            sb.Append("  OrganizationUnitId: ").Append(OrganizationUnitId).Append("\n");
            sb.Append("  OrganizationUnitFk: ").Append(OrganizationUnitFk).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ExtractedDocument);
        }

        /// <summary>
        /// Returns true if ExtractedDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtractedDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtractedDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.DocumentClassificationType == input.DocumentClassificationType ||
                    (this.DocumentClassificationType != null &&
                    this.DocumentClassificationType.Equals(input.DocumentClassificationType))
                ) && 
                (
                    this.IsExtractedContentStructured == input.IsExtractedContentStructured ||
                    (this.IsExtractedContentStructured != null &&
                    this.IsExtractedContentStructured.Equals(input.IsExtractedContentStructured))
                ) && 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.ExtractedContent == input.ExtractedContent ||
                    (this.ExtractedContent != null &&
                    this.ExtractedContent.Equals(input.ExtractedContent))
                ) && 
                (
                    this.SessionID == input.SessionID ||
                    (this.SessionID != null &&
                    this.SessionID.Equals(input.SessionID))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    (this.IsVerified != null &&
                    this.IsVerified.Equals(input.IsVerified))
                ) && 
                (
                    this.HasErrors == input.HasErrors ||
                    (this.HasErrors != null &&
                    this.HasErrors.Equals(input.HasErrors))
                ) && 
                (
                    this.QualityScore == input.QualityScore ||
                    (this.QualityScore != null &&
                    this.QualityScore.Equals(input.QualityScore))
                ) && 
                (
                    this.IsDeletedByUser == input.IsDeletedByUser ||
                    (this.IsDeletedByUser != null &&
                    this.IsDeletedByUser.Equals(input.IsDeletedByUser))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.IsReadOnly == input.IsReadOnly ||
                    (this.IsReadOnly != null &&
                    this.IsReadOnly.Equals(input.IsReadOnly))
                ) && 
                (
                    this.HasNewerVersion == input.HasNewerVersion ||
                    (this.HasNewerVersion != null &&
                    this.HasNewerVersion.Equals(input.HasNewerVersion))
                ) && 
                (
                    this.ImageBlobContainerID == input.ImageBlobContainerID ||
                    (this.ImageBlobContainerID != null &&
                    this.ImageBlobContainerID.Equals(input.ImageBlobContainerID))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.UpdatedByUser == input.UpdatedByUser ||
                    (this.UpdatedByUser != null &&
                    this.UpdatedByUser.Equals(input.UpdatedByUser))
                ) && 
                (
                    this.IsSkipped == input.IsSkipped ||
                    (this.IsSkipped != null &&
                    this.IsSkipped.Equals(input.IsSkipped))
                ) && 
                (
                    this.ExtractedFileId == input.ExtractedFileId ||
                    (this.ExtractedFileId != null &&
                    this.ExtractedFileId.Equals(input.ExtractedFileId))
                ) && 
                (
                    this.ExtractedFileFk == input.ExtractedFileFk ||
                    (this.ExtractedFileFk != null &&
                    this.ExtractedFileFk.Equals(input.ExtractedFileFk))
                ) && 
                (
                    this.OrganizationUnitId == input.OrganizationUnitId ||
                    (this.OrganizationUnitId != null &&
                    this.OrganizationUnitId.Equals(input.OrganizationUnitId))
                ) && 
                (
                    this.OrganizationUnitFk == input.OrganizationUnitFk ||
                    (this.OrganizationUnitFk != null &&
                    this.OrganizationUnitFk.Equals(input.OrganizationUnitFk))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.DocumentClassificationType != null)
                    hashCode = hashCode * 59 + this.DocumentClassificationType.GetHashCode();
                if (this.IsExtractedContentStructured != null)
                    hashCode = hashCode * 59 + this.IsExtractedContentStructured.GetHashCode();
                if (this.Schema != null)
                    hashCode = hashCode * 59 + this.Schema.GetHashCode();
                if (this.ExtractedContent != null)
                    hashCode = hashCode * 59 + this.ExtractedContent.GetHashCode();
                if (this.SessionID != null)
                    hashCode = hashCode * 59 + this.SessionID.GetHashCode();
                if (this.IsVerified != null)
                    hashCode = hashCode * 59 + this.IsVerified.GetHashCode();
                if (this.HasErrors != null)
                    hashCode = hashCode * 59 + this.HasErrors.GetHashCode();
                if (this.QualityScore != null)
                    hashCode = hashCode * 59 + this.QualityScore.GetHashCode();
                if (this.IsDeletedByUser != null)
                    hashCode = hashCode * 59 + this.IsDeletedByUser.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.IsReadOnly != null)
                    hashCode = hashCode * 59 + this.IsReadOnly.GetHashCode();
                if (this.HasNewerVersion != null)
                    hashCode = hashCode * 59 + this.HasNewerVersion.GetHashCode();
                if (this.ImageBlobContainerID != null)
                    hashCode = hashCode * 59 + this.ImageBlobContainerID.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.UpdatedByUser != null)
                    hashCode = hashCode * 59 + this.UpdatedByUser.GetHashCode();
                if (this.IsSkipped != null)
                    hashCode = hashCode * 59 + this.IsSkipped.GetHashCode();
                if (this.ExtractedFileId != null)
                    hashCode = hashCode * 59 + this.ExtractedFileId.GetHashCode();
                if (this.ExtractedFileFk != null)
                    hashCode = hashCode * 59 + this.ExtractedFileFk.GetHashCode();
                if (this.OrganizationUnitId != null)
                    hashCode = hashCode * 59 + this.OrganizationUnitId.GetHashCode();
                if (this.OrganizationUnitFk != null)
                    hashCode = hashCode * 59 + this.OrganizationUnitFk.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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