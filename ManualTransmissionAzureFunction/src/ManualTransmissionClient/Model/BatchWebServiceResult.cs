/* 
 * ManualTransmissionService
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.0.0
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
using SwaggerDateConverter = ManualTransmissionClient.Client.SwaggerDateConverter;

namespace ManualTransmissionClient.Model
{
    /// <summary>
    /// BatchWebServiceResult
    /// </summary>
    [DataContract]
    public partial class BatchWebServiceResult :  IEquatable<BatchWebServiceResult>, IValidatableObject
    {
        /// <summary>
        /// State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.
        /// </summary>
        /// <value>State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum InProgress for "inProgress"
            /// </summary>
            [EnumMember(Value = "inProgress")]
            InProgress,
            
            /// <summary>
            /// Enum Ready for "ready"
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready,
            
            /// <summary>
            /// Enum Complete for "complete"
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete
        }

        /// <summary>
        /// State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.
        /// </summary>
        /// <value>State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchWebServiceResult" /> class.
        /// </summary>
        /// <param name="State">State of the execution. Can be of the following values:  - Pending: The batch execution was submitted but is not yet scheduled. Ready: The batch execution was submitted and can be executed. InProgress: The batch execution is currently being processed. Complete: The batch execution has been completed..</param>
        /// <param name="CompletedItemCount">Number of completed items in this batch operation..</param>
        /// <param name="TotalItemCount">Number of total items in this batch operation..</param>
        /// <param name="BatchExecutionResults">The responses of the individual executions..</param>
        public BatchWebServiceResult(StateEnum? State = default(StateEnum?), int? CompletedItemCount = default(int?), int? TotalItemCount = default(int?), List<WebServiceResult> BatchExecutionResults = default(List<WebServiceResult>))
        {
            this.State = State;
            this.CompletedItemCount = CompletedItemCount;
            this.TotalItemCount = TotalItemCount;
            this.BatchExecutionResults = BatchExecutionResults;
        }
        

        /// <summary>
        /// Number of completed items in this batch operation.
        /// </summary>
        /// <value>Number of completed items in this batch operation.</value>
        [DataMember(Name="completedItemCount", EmitDefaultValue=false)]
        public int? CompletedItemCount { get; set; }

        /// <summary>
        /// Number of total items in this batch operation.
        /// </summary>
        /// <value>Number of total items in this batch operation.</value>
        [DataMember(Name="totalItemCount", EmitDefaultValue=false)]
        public int? TotalItemCount { get; set; }

        /// <summary>
        /// The responses of the individual executions.
        /// </summary>
        /// <value>The responses of the individual executions.</value>
        [DataMember(Name="batchExecutionResults", EmitDefaultValue=false)]
        public List<WebServiceResult> BatchExecutionResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchWebServiceResult {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CompletedItemCount: ").Append(CompletedItemCount).Append("\n");
            sb.Append("  TotalItemCount: ").Append(TotalItemCount).Append("\n");
            sb.Append("  BatchExecutionResults: ").Append(BatchExecutionResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BatchWebServiceResult);
        }

        /// <summary>
        /// Returns true if BatchWebServiceResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchWebServiceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchWebServiceResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.CompletedItemCount == other.CompletedItemCount ||
                    this.CompletedItemCount != null &&
                    this.CompletedItemCount.Equals(other.CompletedItemCount)
                ) && 
                (
                    this.TotalItemCount == other.TotalItemCount ||
                    this.TotalItemCount != null &&
                    this.TotalItemCount.Equals(other.TotalItemCount)
                ) && 
                (
                    this.BatchExecutionResults == other.BatchExecutionResults ||
                    this.BatchExecutionResults != null &&
                    this.BatchExecutionResults.SequenceEqual(other.BatchExecutionResults)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.CompletedItemCount != null)
                    hash = hash * 59 + this.CompletedItemCount.GetHashCode();
                if (this.TotalItemCount != null)
                    hash = hash * 59 + this.TotalItemCount.GetHashCode();
                if (this.BatchExecutionResults != null)
                    hash = hash * 59 + this.BatchExecutionResults.GetHashCode();
                return hash;
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
